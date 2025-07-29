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

namespace VISTA.Informes
{
    public partial class Form_motivosCancelacionInformes : Form
    {
        CONTROLADORA.Controladora_reservas contro_reser = new CONTROLADORA.Controladora_reservas();
        public Form_motivosCancelacionInformes()
        {
            InitializeComponent();
        }

        private void Form_motivosCancelacionInformes_Load(object sender, EventArgs e)
        {
            //var reservasCanceladas = contro_reser.ListarReservas()
            //    .Where(r => r.Estado == "Cancelada" && r.MotivosCancelacion != null && r.MotivosCancelacion.Any())
            //    .ToList();

            //// 2. Agrupar por motivo y contar
            //var motivosAgrupados = reservasCanceladas
            //    .SelectMany(r => r.MotivosCancelacion)
            //    .GroupBy(m => m.Descripcion)
            //    .Select(g => new { Motivo = g.Key, Cantidad = g.Count() })
            //    .ToList();

            //if (motivosAgrupados.Count == 0)
            //{
            //    MessageBox.Show("No hay cancelaciones registradas para mostrar en el gráfico.", "Información");
            //    return;
            //}

            //// 3. Colores automáticos (si no tenés predefinidos)
            //Color[] coloresDisponibles = new Color[]
            //{
            //    Color.LightBlue, Color.LightGreen, Color.LightCoral, Color.Orange, Color.Violet, Color.Tomato,
            //    Color.MediumSeaGreen, Color.SteelBlue, Color.Gold, Color.Salmon
            //};

            //// 4. Crear gráfico
            //Chart chart = new Chart();
            //chart.Dock = DockStyle.Fill;

            //ChartArea area = new ChartArea("Area");
            //chart.ChartAreas.Add(area);

            //Series serie = new Series("Motivos");
            //serie.ChartType = SeriesChartType.Pie;
            //serie.Label = "#PERCENT{P0}"; // Muestra porcentaje
            //serie.LegendText = "#VALX";   // Muestra el texto del motivo

            //foreach (var motivo in motivosAgrupados)
            //{
            //    serie.Points.AddXY(motivo.Motivo, motivo.Cantidad);
            //}

            //chart.Series.Add(serie);

            //Legend leyenda = new Legend();
            //chart.Legends.Add(leyenda);

            //panel_grafico.Controls.Clear();
            //panel_grafico.Controls.Add(chart);

            //// Mostrar los datos también en panel_datos si querés
            //panel_datos.Controls.Clear();
            //int y = 10;

            //foreach (var motivo in motivosAgrupados)
            //{
            //    Label lbl = new Label();
            //    lbl.Text = $"{motivo.Motivo}: {motivo.Cantidad} cancelaciones";
            //    lbl.Location = new Point(10, y);
            //    lbl.AutoSize = true;
            //    panel_datos.Controls.Add(lbl);
            //    y += 25;

            //}


            var motivos = new Dictionary<string, int>
            {
                { "Clima", 5 },
                { "Salud", 3 },
                { "Otros", 2 }
            };

            // 2. Colores predefinidos para los motivos
            var colores = new Dictionary<string, Color>
            {
                { "Clima", Color.LightBlue },
                { "Salud", Color.LightGreen },
                { "Otros", Color.LightCoral }
            };

            // 3. Crear y configurar el gráfico
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);

            Series serie = new Series
            {
                Name = "Motivos",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Label = "#PERCENT", // Muestra porcentaje
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            chart.Series.Add(serie);

            // 4. Cargar datos y colores
            int total = motivos.Values.Sum();
            foreach (var motivo in motivos)
            {
                int punto = serie.Points.AddXY(motivo.Key, motivo.Value);
                serie.Points[punto].Color = colores[motivo.Key];
            }

            // 5. Agregar gráfico al panel de gráficos
            panel_grafico.Controls.Clear();
            panel_grafico.Controls.Add(chart);

            // 6. Crear etiquetas de motivo en panel_datos
            panel_datos.Controls.Clear();
            panel_datos.AutoScroll = true;

            int y = 10;
            foreach (var motivo in motivos)
            {
                Panel colorBox = new Panel
                {
                    BackColor = colores[motivo.Key],
                    Width = 20,
                    Height = 20,
                    Left = 10,
                    Top = y
                };

                Label label = new Label
                {
                    Text = motivo.Key,
                    Left = 40,
                    Top = y,
                    AutoSize = true
                };

                panel_datos.Controls.Add(colorBox);
                panel_datos.Controls.Add(label);

                y += 30;
            }
        }
    }
}
