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

namespace Aereopuerto_Proyecto
{
    public partial class Calificar_Experiencia : Form
    {
        private Form1 form4;
        public Calificar_Experiencia(Form1 form4)
        {
            InitializeComponent();
            this.form4 = form4;
            estadi();
        }
        private void estadi()
        {
            string[] series = { "Excelente", "Muy Bueno", "Bueno", "Mejorar" };
            int[] puntos = { 90, 8, 2, 0 };
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            chart1.Titles.Add("Estadística Buen Servicio");
            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }
    }
}

