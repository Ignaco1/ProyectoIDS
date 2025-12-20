using iTextSharp.text.pdf;
using iTextSharp.text;
using MODELO.Composite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;

namespace VISTA.Informes
{
    public partial class Form_motivosCancelacionInformes : Form
    {
        CONTROLADORA.Controladora_reservas contro_reser = new CONTROLADORA.Controladora_reservas();
        private Chart chartMotivos;
        int numPDF = 0;
        int numExcel = 0;
        DateTime fechaPDF = DateTime.Now;
        DateTime fechaExcel = DateTime.Now;


        public Form_motivosCancelacionInformes()
        {
            InitializeComponent();
        }

        private void Form_motivosCancelacionInformes_Load(object sender, EventArgs e)
        {
            label_nroCabañas.Visible = false;
        }

        private void CargarGraficoCancelacionReservas()
        {
            var fechaEntrada = dtp_desde.Value.Date;
            var fechaSalida = dtp_hasta.Value.Date;

            var reservasCanceladas = contro_reser.ListarReservas()
            .Where(r => r.Estado == "Cancelada" && r.MotivosCancelacion.Any() && r.FechaEntrada >= fechaEntrada && r.FechaEntrada <= fechaSalida)
            .ToList();

            label_nroCabañas.Text = $"Cantidad de reservas canceladas entre las fechas {fechaEntrada.Date.ToString("dd/MM/yyyy")} - {fechaSalida.Date.ToString("dd/MM/yyyy")} = {reservasCanceladas.Count.ToString()}";

            if (reservasCanceladas.Count == 0)
            {
                MessageBox.Show("No hay reservas registradas con cancelaciones para mostrar en el gráfico.", "AVISO");
                return;
            }

            var motivosAgrupados = reservasCanceladas
            .SelectMany(r => r.MotivosCancelacion)
            .Where(m => !string.IsNullOrEmpty(m.Descripcion))
            .GroupBy(m => m.Descripcion)
            .Select(g => new { Motivo = g.Key, Cantidad = g.Count() })
            .ToList();

            if (motivosAgrupados.Count == 0)
            {
                MessageBox.Show("No hay cancelaciones registradas para mostrar en el gráfico.", "AVISO");
                return;
            }

            flowLayoutPanel_datos.Controls.Clear();
            panel_grafico.Controls.Clear();


            Dictionary<string, Color> coloresMotivos = new Dictionary<string, Color>
            {
                { "Precio elevado", Color.Orange },
                { "Otro", Color.Gold },
                { "Rotura o arreglo de cabaña", Color.Red },
                { "Error de carga en el sistema", Color.Gray },
                { "Cancelación por motivos de salud", Color.Teal },
                { "Cancelación por parte del cliente", Color.YellowGreen },
                { "Condiciones climáticas", Color.LightBlue }
            };

            chartMotivos = new Chart();
            chartMotivos.BackColor = this.BackColor;
            chartMotivos.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea();
            area.BackColor = this.BackColor;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.LineWidth = 0;
            area.AxisY.LineWidth = 0;
            chartMotivos.ChartAreas.Add(area);

            Series serie = new Series("Motivos")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White,
                Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold)
            };


            chartMotivos.Series.Add(serie);

            int total = motivosAgrupados.Sum(m => m.Cantidad);

            for (int i = 0; i < motivosAgrupados.Count; i++)
            {
                var motivo = motivosAgrupados[i];
                int idx = serie.Points.AddXY(motivo.Motivo, motivo.Cantidad);
                Color color = coloresMotivos.ContainsKey(motivo.Motivo)? coloresMotivos[motivo.Motivo]: Color.LightGray;

                serie.Points[idx].Color = color;
                double porcentaje = (double)motivo.Cantidad * 100 / total;
                serie.Points[idx].Label = $"{porcentaje:F1}%";
                serie.Points[idx].ToolTip = $"{motivo.Motivo}: {motivo.Cantidad} cancelaciones ({porcentaje:F1}%)";

                Panel contenedor = new Panel
                {
                    Width = flowLayoutPanel_datos.Width - 20,
                    Height = 28,
                    BackColor = Color.Transparent,
                    Margin = new Padding(0, 3, 0, 3),
                    Padding = new Padding(0)
                };

                PictureBox cuadrado = new PictureBox
                {
                    Width = 16,
                    Height = 16,
                    BackColor = color,
                    Location = new Point(5, 6)
                };

                Label lbl = new Label
                {
                    Text = $"{motivo.Motivo} ({motivo.Cantidad})",
                    AutoSize = false,
                    Location = new Point(28, 5),
                    Width = contenedor.Width - 35,
                    Height = 25,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new System.Drawing.Font("Century Gothic", 9)
                };

                contenedor.Controls.Add(cuadrado);
                contenedor.Controls.Add(lbl);
                flowLayoutPanel_datos.Controls.Add(contenedor);
            }

            panel_grafico.Controls.Add(chartMotivos);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                var fechaEntrada = dtp_desde.Value.Date;
                var fechaSalida = dtp_hasta.Value.Date;

                var reservasCanceladas = contro_reser.ListarReservas()
                .Where(r => r.Estado == "Cancelada" && r.MotivosCancelacion.Any() && r.FechaEntrada >= fechaEntrada && r.FechaEntrada <= fechaSalida)
                .ToList();

                var motivosAgrupados = reservasCanceladas
                .SelectMany(r => r.MotivosCancelacion)
                .Where(m => !string.IsNullOrEmpty(m.Descripcion))
                .GroupBy(m => m.Descripcion)
                .Select(g => new { Motivo = g.Key, Cantidad = g.Count() })
                .ToList();

                if (reservasCanceladas.Count == 0)
                {
                    MessageBox.Show("No hay reservas registradas con cancelaciones para exportar un informe.", "AVISO");
                    return;
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "PDF (*.pdf)|*.pdf";
                numPDF = numPDF + 1;
                var fecha = fechaPDF.Date.ToString("dd-MM-yyyy");
                var hora = fechaPDF.ToString("HHHH-mm-ss");
                saveFile.FileName = $"Informe_MotivosCancelacion_{fecha}_{hora}_{numPDF}.pdf";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFile.FileName;

                    string imgPath = Path.Combine(Path.GetTempPath(), "grafico_motivos.png");
                    chartMotivos.SaveImage(imgPath, ChartImageFormat.Png);

                    using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        var doc = new iTextSharp.text.Document(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        var titulo = new iTextSharp.text.Paragraph($"Informe de Motivos de Cancelación de reservas entre {fechaEntrada.Date.ToString("dd/MM/yyyy")} - {fechaSalida.Date.ToString("dd/MM/yyyy")}\n\n\n", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                        titulo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titulo);

                        var text = new iTextSharp.text.Paragraph($"Cantidad de reservas canceladas: {reservasCanceladas.Count}\n\n\n", FontFactory.GetFont(FontFactory.HELVETICA, 12));
                        doc.Add(text);

                        var porcen = new iTextSharp.text.Paragraph($"Porcentajes de motivos de cancelacion de reservas:", FontFactory.GetFont(FontFactory.HELVETICA, 12));
                        var guion = new iTextSharp.text.Paragraph($"---------------------------------------------------------------------\n\n", FontFactory.GetFont(FontFactory.HELVETICA, 12));
                        doc.Add(porcen);
                        doc.Add(guion);

                        iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(imgPath);
                        chartImage.Alignment = Element.ALIGN_CENTER;
                        chartImage.ScaleToFit(400f, 400f);
                        doc.Add(chartImage);

                        doc.Add(new Paragraph("\n\n\n"));

                        var texto = new iTextSharp.text.Paragraph("Motivos de cancelación de las reservas:", FontFactory.GetFont(FontFactory.HELVETICA, 12));
                        var guion2 = new iTextSharp.text.Paragraph($"-----------------------------------------------------\n\n", FontFactory.GetFont(FontFactory.HELVETICA, 12));
                        doc.Add(texto);
                        doc.Add(guion2);

                        PdfPTable tablaMotivos = new PdfPTable(2);
                        tablaMotivos.WidthPercentage = 50;


                        float[] anchos = new float[] { 10f, 90f };
                        tablaMotivos.SetWidths(anchos);

                        tablaMotivos.HorizontalAlignment = Element.ALIGN_LEFT;
                        tablaMotivos.SpacingBefore = 15f;
                        tablaMotivos.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                        Dictionary<string, Color> coloresMotivos = new Dictionary<string, Color>
                        {
                            { "Precio elevado", Color.Orange },
                            { "Otro", Color.Gold },
                            { "Rotura o arreglo de cabaña", Color.Red },
                            { "Error de carga en el sistema", Color.Gray },
                            { "Cancelación por motivos de salud", Color.Teal },
                            { "Cancelación por parte del cliente", Color.YellowGreen },
                            { "Condiciones climáticas", Color.LightBlue }
                        };

                        for (int i = 0; i < motivosAgrupados.Count; i++)
                        {
                            var motivo = motivosAgrupados[i];
                            BaseColor color = new BaseColor(coloresMotivos.ContainsKey(motivo.Motivo) ? coloresMotivos[motivo.Motivo] : Color.LightGray);

                            PdfPCell celdaColor = new PdfPCell();
                            celdaColor.BackgroundColor = color;
                            celdaColor.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            celdaColor.FixedHeight = 12f;
                            celdaColor.HorizontalAlignment = Element.ALIGN_CENTER;
                            celdaColor.VerticalAlignment = Element.ALIGN_MIDDLE;
                            tablaMotivos.AddCell(celdaColor);

                            PdfPCell celdaTexto = new PdfPCell(new Phrase($" {motivo.Motivo} ({motivo.Cantidad})", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                            celdaTexto.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            celdaTexto.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celdaTexto.PaddingBottom = 3f;
                            tablaMotivos.AddCell(celdaTexto);
                        }

                        doc.Add(tablaMotivos);

                        doc.Close();
                    }

                    MessageBox.Show("PDF generado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PDF: " + ex.Message);
            }
        }

        private void btn_exportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var fechaEntrada = dtp_desde.Value.Date;
                var fechaSalida = dtp_hasta.Value.Date;

                var reservasCanceladas = contro_reser.ListarReservas()
                .Where(r => r.Estado == "Cancelada" && r.MotivosCancelacion.Any() && r.FechaEntrada >= fechaEntrada && r.FechaEntrada <= fechaSalida)
                .ToList();

                var motivosAgrupados = reservasCanceladas
                .SelectMany(r => r.MotivosCancelacion)
                .Where(m => !string.IsNullOrEmpty(m.Descripcion))
                .GroupBy(m => m.Descripcion)
                .Select(g => new { Motivo = g.Key, Cantidad = g.Count() })
                .ToList();

                if (reservasCanceladas.Count == 0)
                {
                    MessageBox.Show("No hay reservas registradas con cancelaciones para exportar un informe.", "AVISO");
                    return;
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Excel Workbook|*.xlsx";
                numExcel = numExcel + 1;
                var fecha = fechaExcel.Date.ToString("dd-MM-yyyy");
                var hora = fechaExcel.ToString("HHHH-mm-ss");
                saveFile.FileName = $"Motivos_Cancelacion_{fecha}_{hora}_{numExcel}.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFile.FileName;

                    string imgPath = Path.Combine(Path.GetTempPath(), "grafico_excel.png");
                    chartMotivos.SaveImage(imgPath, ChartImageFormat.Png);

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Motivos Cancelación");

                        worksheet.Cell(2, 1).Value = $"Motivos de cancelación entre {fechaEntrada.Date.ToString("dd/MM/yyyy")} y {fechaSalida.Date.ToString("dd/MM/yyyy")}";
                        worksheet.Range("A2:E2").Merge();
                        worksheet.Cell(2, 1).Style.Font.Bold = true;
                        worksheet.Cell(2, 1).Style.Font.FontSize = 13;
                        worksheet.Cell(2, 1).Style.Font.FontName = "Calibri";
                        worksheet.Cell(2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        int totalCanceladas = reservasCanceladas.Count;
                        worksheet.Cell(4, 1).Value = $"Total de reservas canceladas: {totalCanceladas}";
                        worksheet.Range("A4:E4").Merge();
                        worksheet.Cell(4, 1).Style.Font.FontSize = 12;
                        worksheet.Cell(4, 1).Style.Font.FontName = "Calibri";
                        worksheet.Cell(4, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        worksheet.Cell(7, 1).Value = "Color";
                        worksheet.Cell(7, 2).Value = "Motivo";
                        worksheet.Cell(7, 3).Value = "Cantidad";

                        var headers = worksheet.Range("A7:C7");
                        headers.Style.Font.Bold = true;
                        headers.Style.Font.FontName = "Calibri";
                        headers.Style.Font.FontSize = 13;
                        headers.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        Dictionary<string, XLColor> coloresMotivos = new Dictionary<string, XLColor>
                        {
                            { "Precio elevado", XLColor.Orange },
                            { "Otro", XLColor.Gold },
                            { "Rotura o arreglo de cabaña", XLColor.Red },
                            { "Error de carga en el sistema", XLColor.Gray },
                            { "Cancelación por motivos de salud", XLColor.Teal },
                            { "Cancelación por parte del cliente", XLColor.YellowGreen },
                            { "Condiciones climáticas", XLColor.LightBlue }
                        };

                        int fila = 8;
                        foreach (var motivo in motivosAgrupados)
                        {
                            var celdaColor = worksheet.Cell(fila, 1);
                            celdaColor.Value = "";
                            celdaColor.Style.Fill.BackgroundColor = coloresMotivos.ContainsKey(motivo.Motivo)
                                ? coloresMotivos[motivo.Motivo]
                                : XLColor.LightGray;
                            celdaColor.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                            worksheet.Cell(fila, 2).Value = motivo.Motivo;

                            worksheet.Cell(fila, 3).Value = motivo.Cantidad;

                            for (int col = 1; col <= 3; col++)
                            {
                                var celda = worksheet.Cell(fila, col);
                                celda.Style.Font.FontName = "Calibri";
                                celda.Style.Font.FontSize = 12;
                                celda.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                            }

                            fila++;
                        }

                        worksheet.Columns("A:C").AdjustToContents();

                        worksheet.AddPicture(imgPath)
                            .MoveTo(worksheet.Cell(2, 7))
                            .WithSize(400, 800);

                        workbook.SaveAs(path);
                    }

                    MessageBox.Show("Excel exportado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar Excel: " + ex.Message);
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (dtp_desde.Value > dtp_hasta.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error");
                return;
            }

            label_nroCabañas.Visible = true;
            CargarGraficoCancelacionReservas();
        }
    }
}
