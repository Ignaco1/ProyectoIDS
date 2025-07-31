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

            
        }
    }
}
