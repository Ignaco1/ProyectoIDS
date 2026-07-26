using iTextSharp.text.pdf;
using iTextSharp.text;
using MODELO.State;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;

namespace VISTA.Informes
{
    public partial class Form_gastosMantenimientosInforme : Form
    {
        private readonly CONTROLADORA.Controladora_AsignacionesMantenimiento contro_asig = new CONTROLADORA.Controladora_AsignacionesMantenimiento();
        private readonly CONTROLADORA.Controladora_cabañas contro_cab = new CONTROLADORA.Controladora_cabañas();

        private static readonly Color ColorSeleccionado = Color.FromArgb(0, 84, 168);
        private static readonly Color ColorNoSeleccionado = Color.Gray;

        private static readonly Color[] PaletaCabañas = new[]
        {
            Color.SteelBlue, Color.Orange, Color.Teal, Color.YellowGreen, Color.Gold,
            Color.MediumPurple, Color.IndianRed, Color.LightSeaGreen, Color.DarkKhaki, Color.CadetBlue
        };

        private List<InformeGenerado> informesActuales = new List<InformeGenerado>();

        private int numPDF = 0;
        private int numExcel = 0;

        private enum TipoInforme { GastoMes, GastoRango, Ranking }

        private class DetalleMantenimiento
        {
            public string Nombre { get; set; }
            public decimal Costo { get; set; }
            public DateTime Fecha { get; set; }
        }

        private class GastoCabaña
        {
            public string NombreCabaña { get; set; }
            public decimal Total { get; set; }
            public List<DetalleMantenimiento> Detalle { get; set; } = new List<DetalleMantenimiento>();
        }

        private class InformeGenerado
        {
            public TipoInforme Tipo { get; set; }
            public string Titulo { get; set; }
            public List<GastoCabaña> Datos { get; set; }
            public Control Visual { get; set; }
        }

        public Form_gastosMantenimientosInforme()
        {
            InitializeComponent();
        }

        private void Form_gastosMantenimientosInforme_Load(object sender, EventArgs e)
        {
        }

        private void btn_gastoMes_Click(object sender, EventArgs e) => ToggleSeleccion(btn_gastoMes);

        private void btn_gastoPorRango_Click(object sender, EventArgs e) => ToggleSeleccion(btn_gastoPorRango);

        private void btn_rankingCabañas_Click(object sender, EventArgs e) => ToggleSeleccion(btn_rankingCabañas);

        private void ToggleSeleccion(Button boton)
        {
            boton.BackColor = EstaSeleccionado(boton) ? ColorNoSeleccionado : ColorSeleccionado;
        }

        private bool EstaSeleccionado(Button boton) => boton.BackColor == ColorSeleccionado;

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private List<GastoCabaña> ObtenerGastosPorCabaña(DateTime? desde, DateTime? hasta)
        {
            var cabañas = contro_cab.ListarCabañas();

            IEnumerable<MODELO.AsignacionMantenimiento> asignaciones = contro_asig.ListarAsignaciones()
                .Where(a => a.EstadoActual is not EstadoAsignacionMantenimientoCancelada);

            if (desde.HasValue && hasta.HasValue)
            {
                asignaciones = asignaciones.Where(a => a.FechaInicio.Date >= desde.Value.Date && a.FechaInicio.Date <= hasta.Value.Date);
            }

            var asigList = asignaciones.ToList();

            return cabañas
                .Select(c =>
                {
                    var detalle = asigList
                        .Where(a => a.CabañaId == c.CabañaId)
                        .OrderBy(a => a.FechaInicio)
                        .Select(a => new DetalleMantenimiento
                        {
                            Nombre = a.Mantenimiento?.Nombre ?? "Mantenimiento",
                            Costo = a.Costo,
                            Fecha = a.FechaInicio
                        })
                        .ToList();

                    return new GastoCabaña
                    {
                        NombreCabaña = c.Nombre,
                        Detalle = detalle,
                        Total = detalle.Sum(d => d.Costo)
                    };
                })
                .OrderBy(g => g.NombreCabaña)
                .ToList();
        }

        private string FormatearDatos(List<GastoCabaña> datos)
        {
            return string.Join(Environment.NewLine + Environment.NewLine, datos.Select(d => $"Cabaña: {d.NombreCabaña} - {d.Total:C2}"));
        }

        private InformeGenerado ConstruirInforme(TipoInforme tipo, Size tamaño)
        {
            switch (tipo)
            {
                case TipoInforme.GastoMes:
                    {
                        var hoy = DateTime.Now.Date;
                        var desde = new DateTime(hoy.Year, hoy.Month, 1);
                        var hasta = desde.AddMonths(1).AddDays(-1);
                        var datos = ObtenerGastosPorCabaña(desde, hasta);
                        string titulo = $"Gasto mensual de mantenimientos en cada una de las cabañas ({desde:MMMM yyyy}):";
                        return new InformeGenerado { Tipo = tipo, Titulo = titulo, Datos = datos, Visual = ConstruirGraficoBarras(datos, tamaño) };
                    }
                case TipoInforme.GastoRango:
                    {
                        var desde = dtp_desde.Value.Date;
                        var hasta = dtp_hasta.Value.Date;
                        var datos = ObtenerGastosPorCabaña(desde, hasta);
                        string titulo = $"Gastos de mantenimiento por rango de fechas: {desde:dd/MM/yyyy} - {hasta:dd/MM/yyyy}";
                        return new InformeGenerado { Tipo = tipo, Titulo = titulo, Datos = datos, Visual = ConstruirGraficoBarras(datos, tamaño) };
                    }
                case TipoInforme.Ranking:
                default:
                    {
                        var datos = ObtenerGastosPorCabaña(null, null).OrderByDescending(d => d.Total).ToList();
                        string titulo = "Ranking de gastos en mantenimientos según cabaña:";
                        return new InformeGenerado { Tipo = tipo, Titulo = titulo, Datos = datos, Visual = ConstruirPodio(datos, tamaño) };
                    }
            }
        }


        private void btn_generar_Click(object sender, EventArgs e)
        {
            var seleccionados = new List<TipoInforme>();
            if (EstaSeleccionado(btn_gastoMes)) seleccionados.Add(TipoInforme.GastoMes);
            if (EstaSeleccionado(btn_gastoPorRango)) seleccionados.Add(TipoInforme.GastoRango);
            if (EstaSeleccionado(btn_rankingCabañas)) seleccionados.Add(TipoInforme.Ranking);

            if (seleccionados.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un informe para generar.", "AVISO");
                return;
            }

            if (seleccionados.Contains(TipoInforme.GastoRango) && dtp_desde.Value.Date > dtp_hasta.Value.Date)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error");
                return;
            }

            Size tamañoVisual = seleccionados.Count == 1 ? panel_grafico.ClientSize : new Size(1200, 700);

            informesActuales = seleccionados.Select(tipo => ConstruirInforme(tipo, tamañoVisual)).ToList();

            panel_grafico.Controls.Clear();

            label_titulo.Visible = true;
            label_datosGrafico.Visible = true;

            if (informesActuales.Count == 1)
            {
                var informe = informesActuales[0];
                label_titulo.Text = informe.Titulo;
                label_datosGrafico.Text = FormatearDatos(informe.Datos);
                informe.Visual.Dock = DockStyle.Fill;
                panel_grafico.Controls.Add(informe.Visual);
            }
            else
            {
                label_titulo.Text = "Informes generados";
                label_datosGrafico.Text = "Se generaron varios informes. Utilice los botones de exportar para verlos en detalle.";
                MessageBox.Show("Informes generados de forma exitosa.", "AVISO");
            }
        }


        private Chart ConstruirGraficoBarras(List<GastoCabaña> datos, Size tamaño)
        {
            Chart chart = new Chart();
            chart.BackColor = this.BackColor;
            chart.Size = tamaño;

            ChartArea area = new ChartArea();
            area.BackColor = this.BackColor;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisX.LineColor = Color.White;
            area.AxisY.LineColor = Color.White;
            chart.ChartAreas.Add(area);

            Series serie = new Series("Gastos")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White,
                Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold)
            };
            chart.Series.Add(serie);

            for (int i = 0; i < datos.Count; i++)
            {
                var d = datos[i];
                int idx = serie.Points.AddXY(d.NombreCabaña, d.Total);
                serie.Points[idx].Color = PaletaCabañas[i % PaletaCabañas.Length];
                serie.Points[idx].Label = d.Total.ToString("C0");
                serie.Points[idx].ToolTip = $"Cabaña: {d.NombreCabaña} - {d.Total:C2}";
            }

            return chart;
        }


        private Panel ConstruirPodio(List<GastoCabaña> ranking, Size tamaño)
        {
            Panel contenedor = new Panel { Size = tamaño, BackColor = this.BackColor };

            var top3 = ranking.Take(3).ToList();
            if (top3.Count == 0) return contenedor;

            int anchoColumna = 260;
            int centroX = tamaño.Width / 2;
            int baseY = tamaño.Height - 60;

            var colorOro = Color.FromArgb(244, 196, 48);
            var colorPlata = Color.FromArgb(176, 190, 197);
            var colorBronce = Color.FromArgb(184, 115, 51);

            if (top3.Count >= 1)
                PosicionarColumnaPodio(contenedor, centroX, baseY, 220, colorOro, 110, "1", top3[0].NombreCabaña, top3[0].Total.ToString("C2"));

            if (top3.Count >= 2)
                PosicionarColumnaPodio(contenedor, centroX - anchoColumna, baseY, 160, colorPlata, 90, "2", top3[1].NombreCabaña, top3[1].Total.ToString("C2"));

            if (top3.Count >= 3)
                PosicionarColumnaPodio(contenedor, centroX + anchoColumna, baseY, 110, colorBronce, 90, "3", top3[2].NombreCabaña, top3[2].Total.ToString("C2"));

            return contenedor;
        }

        private void PosicionarColumnaPodio(Panel contenedor, int centroX, int baseY, int alturaBarra, Color color, int diametroCirculo, string rankTexto, string nombreCabaña, string monto)
        {
            Panel barra = new Panel
            {
                BackColor = color,
                Size = new Size(220, alturaBarra),
                Location = new Point(centroX - 110, baseY - alturaBarra)
            };
            contenedor.Controls.Add(barra);

            int cursorBottom = baseY - alturaBarra - 8;

            Label lblMonto = new Label
            {
                Text = monto,
                AutoSize = true,
                ForeColor = Color.Gainsboro,
                Font = new System.Drawing.Font("Century Gothic", 11)
            };
            contenedor.Controls.Add(lblMonto);
            lblMonto.Location = new Point(centroX - lblMonto.PreferredWidth / 2, cursorBottom - lblMonto.PreferredHeight);
            cursorBottom = lblMonto.Top - 4;

            Label lblNombre = new Label
            {
                Text = nombreCabaña,
                AutoSize = true,
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Century Gothic", 13, FontStyle.Bold)
            };
            contenedor.Controls.Add(lblNombre);
            lblNombre.Location = new Point(centroX - lblNombre.PreferredWidth / 2, cursorBottom - lblNombre.PreferredHeight);
            cursorBottom = lblNombre.Top - 8;

            Panel circulo = CrearCirculo(diametroCirculo, color, rankTexto, Color.FromArgb(30, 30, 30));
            circulo.Location = new Point(centroX - diametroCirculo / 2, cursorBottom - diametroCirculo);
            contenedor.Controls.Add(circulo);
        }

        private Panel CrearCirculo(int diametro, Color color, string texto, Color colorTexto)
        {
            Panel circulo = new Panel
            {
                Size = new Size(diametro, diametro),
                BackColor = color
            };

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, diametro, diametro);
            circulo.Region = new Region(path);

            Label lbl = new Label
            {
                Text = texto,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = colorTexto,
                Font = new System.Drawing.Font("Century Gothic", diametro / 4f, FontStyle.Bold)
            };
            circulo.Controls.Add(lbl);

            return circulo;
        }


        private void GuardarImagenVisual(Control visual, string path)
        {
            if (visual is Chart chart)
            {
                if (chart.Width == 0 || chart.Height == 0) chart.Size = new Size(1200, 700);
                chart.SaveImage(path, ChartImageFormat.Png);
            }
            else
            {
                if (visual.Width == 0 || visual.Height == 0) visual.Size = new Size(1200, 700);
                visual.CreateControl();
                using (Bitmap bmp = new Bitmap(visual.Width, visual.Height))
                {
                    visual.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, visual.Size));
                    bmp.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private string SanearNombreHoja(string nombre)
        {
            foreach (char c in new[] { '\\', '/', '*', '?', ':', '[', ']' })
                nombre = nombre.Replace(c, '-');
            return nombre.Length > 31 ? nombre.Substring(0, 31) : nombre;
        }

        private void btn_exportarPDF_Click(object sender, EventArgs e)
        {
            if (informesActuales == null || informesActuales.Count == 0)
            {
                MessageBox.Show("Primero debe generar un informe.", "AVISO");
                return;
            }

            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "PDF (*.pdf)|*.pdf";
                numPDF++;
                var fecha = DateTime.Now.ToString("dd-MM-yyyy");
                var hora = DateTime.Now.ToString("HH-mm-ss");
                saveFile.FileName = $"Informe_GastosMantenimientos_{fecha}_{hora}_{numPDF}.pdf";

                if (saveFile.ShowDialog() != DialogResult.OK) return;

                using (FileStream fs = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    var doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    for (int i = 0; i < informesActuales.Count; i++)
                    {
                        var informe = informesActuales[i];
                        if (i > 0) doc.NewPage();

                        var titulo = new Paragraph($"{informe.Titulo}\n\n", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 15));
                        titulo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titulo);

                        string imgPath = Path.Combine(Path.GetTempPath(), $"grafico_mantenimiento_{i}.png");
                        GuardarImagenVisual(informe.Visual, imgPath);

                        iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(imgPath);
                        chartImage.Alignment = Element.ALIGN_CENTER;
                        chartImage.ScaleToFit(500f, 350f);
                        doc.Add(chartImage);
                        doc.Add(new Paragraph("\n"));

                        doc.Add(new Paragraph("Detalle de gastos por cabaña:", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                        doc.Add(new Paragraph("---------------------------------------------------------------------\n", FontFactory.GetFont(FontFactory.HELVETICA, 12)));

                        foreach (var cabaña in informe.Datos)
                        {
                            var linea = new Paragraph($"Cabaña: {cabaña.NombreCabaña} - {cabaña.Total:C2}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12));
                            linea.SpacingBefore = 8f;
                            doc.Add(linea);

                            if (cabaña.Detalle.Count == 0)
                            {
                                doc.Add(new Paragraph("   - Sin mantenimientos registrados en el período.", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10)));
                            }
                            else
                            {
                                foreach (var det in cabaña.Detalle)
                                {
                                    doc.Add(new Paragraph($"   - {det.Nombre} ({det.Fecha:dd/MM/yyyy}) - {det.Costo:C2}", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                                }
                            }
                        }
                    }

                    doc.Close();
                }

                MessageBox.Show("PDF generado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PDF: " + ex.Message);
            }
        }

        private void btn_exportarExcel_Click(object sender, EventArgs e)
        {
            if (informesActuales == null || informesActuales.Count == 0)
            {
                MessageBox.Show("Primero debe generar un informe.", "AVISO");
                return;
            }

            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Excel Workbook|*.xlsx";
                numExcel++;
                var fecha = DateTime.Now.ToString("dd-MM-yyyy");
                var hora = DateTime.Now.ToString("HH-mm-ss");
                saveFile.FileName = $"GastosMantenimientos_{fecha}_{hora}_{numExcel}.xlsx";

                if (saveFile.ShowDialog() != DialogResult.OK) return;

                using (var workbook = new XLWorkbook())
                {
                    for (int i = 0; i < informesActuales.Count; i++)
                    {
                        var informe = informesActuales[i];
                        var worksheet = workbook.Worksheets.Add(SanearNombreHoja($"Informe {i + 1}"));

                        worksheet.Cell(2, 1).Value = informe.Titulo;
                        worksheet.Range("A2:F2").Merge();
                        worksheet.Cell(2, 1).Style.Font.Bold = true;
                        worksheet.Cell(2, 1).Style.Font.FontSize = 13;
                        worksheet.Cell(2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        worksheet.Cell(5, 1).Value = "Cabaña";
                        worksheet.Cell(5, 2).Value = "Mantenimiento";
                        worksheet.Cell(5, 3).Value = "Fecha";
                        worksheet.Cell(5, 4).Value = "Costo";
                        var headers = worksheet.Range("A5:D5");
                        headers.Style.Font.Bold = true;
                        headers.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        int fila = 6;
                        foreach (var cabaña in informe.Datos)
                        {
                            worksheet.Cell(fila, 1).Value = cabaña.NombreCabaña;
                            worksheet.Cell(fila, 4).Value = cabaña.Total;
                            worksheet.Cell(fila, 4).Style.NumberFormat.Format = "$#,##0.00";
                            worksheet.Range(fila, 1, fila, 4).Style.Font.Bold = true;
                            fila++;

                            foreach (var det in cabaña.Detalle)
                            {
                                worksheet.Cell(fila, 2).Value = det.Nombre;
                                worksheet.Cell(fila, 3).Value = det.Fecha.ToString("dd/MM/yyyy");
                                worksheet.Cell(fila, 4).Value = det.Costo;
                                worksheet.Cell(fila, 4).Style.NumberFormat.Format = "$#,##0.00";
                                fila++;
                            }

                            if (cabaña.Detalle.Count == 0)
                            {
                                worksheet.Cell(fila, 2).Value = "Sin mantenimientos registrados en el período.";
                                fila++;
                            }
                        }

                        worksheet.Columns("A:D").AdjustToContents();

                        string imgPath = Path.Combine(Path.GetTempPath(), $"grafico_excel_mantenimiento_{i}.png");
                        GuardarImagenVisual(informe.Visual, imgPath);

                        worksheet.AddPicture(imgPath)
                            .MoveTo(worksheet.Cell(2, 7))
                            .WithSize(600, 350);
                    }

                    workbook.SaveAs(saveFile.FileName);
                }

                MessageBox.Show("Excel exportado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar Excel: " + ex.Message);
            }
        }
    }
}
