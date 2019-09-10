using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aereopuerto_Proyecto
{
    public partial class Contacto : Form
    {
        List<Propiertario> prop = new List<Propiertario>();
        private Form1 form3;
        public Contacto(Form1 form3 )
        {
            InitializeComponent();
            this.form3=form3;
            conta();
        }
        private void conta()
        {
            var nueva = new Propiertario()
            {
                 Propetario = "XYZ AIRPORT",
                Tel = 55874589,
                fAX = 55874589,
                Direccion = " zona 10, 89-75",
                Em = "xyzairport@air.com",

            };

            label1.Text = "Nombre:" + nueva.Propetario + "\r\n" + "Dirección: " + nueva.Direccion + "\r\n" + "Teléfono: " + nueva.Tel + "\r\n" + "FAX: " + nueva.fAX + "\r\n" + "Email: " + nueva.Em;


        }
        

        private void Contacto_Load(object sender, EventArgs e)
        {

        }
    }
}
