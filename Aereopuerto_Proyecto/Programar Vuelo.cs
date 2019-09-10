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
    public partial class Programar_Vuelo : Form
    {
        private Form1 form2;
        public Programar_Vuelo(Form1 form2)
        {
            InitializeComponent();
            this.form2 = form2;

        }
        public void aleatorio()
        {
            for (int alea = 1; alea < 4; alea++)
            {
                textBox2.Text = Convert.ToString(alea);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = "";
            if (comboBox6.Text=="Helicóptero")
            {
                n = "4082.021 ft.";
            }
            if (comboBox6.Text == "Comercial")
            {
                n = "42000 ft";
            }
            if (comboBox6.Text == "Jet")
            {
                n = "52000 ft.";
            }
            if (comboBox6.Text == "Avioneta")
            {
                n = "11205.2 ft";
            }
            if (comboBox6.Text == "Jumbo")
            {
                n = "52000 ft.";
                textBox2.Enabled = false;
                textBox2.Text = "5";
            }
            if (comboBox6.Text == "Carga")
            {
                n = "11205.2 ft";
                textBox2.Enabled = false ;
                textBox2.Text = "9";
            }
            var pas = int.Parse(textBox1.Text);
           
            //pasajeros
            if (pas<=200)
            {
                aleatorio();
            }
           
            if (pas>=2000)
            {
                textBox2.Text = "5";
            }

            bool condi;
            if (checkBox1.Checked)
            {
                condi = true;
            }
            else
            {
                condi = false;
            }
            var nueva = new Nombre_Aerolinea_Avion
            {
                Nom_Aerolinea=txtaerolinea.Text,
                Nu_Vuelo=noVuelo.Text,
                Reserva=condi,
                no_Semana=int.Parse(comboBox1.Text),
                Mes=comboBox2.Text,
                dia=int.Parse(comboBox5.Text),
                pasajeros=int.Parse(textBox1.Text),
                No_Pista=int.Parse(textBox2.Text),
                Tipo=comboBox4.Text,
                Piloto=pilotonom.Text,
                tel=int.Parse(telef.Text),
                av=comboBox6.Text,
                Altura_Máxima=n,
               Tipo_Motor=comboBox8.Text,
               Uso=comboBox7.Text,
               Destino=comboBox10.Text,
               Origen=comboBox9.Text

            };
            form2.Aerolis(nueva);
            if (comboBox2.Text == "Marzo")
            {
                form2.Marzo(nueva);
            }
            if (comboBox2.Text == "Abril")
            {
                form2.Abril(nueva);
            }
            if (comboBox2.Text == "Mayo")
            {
                form2.Mayo(nueva);
            }
            if (comboBox2.Text == "Junio")
            {
                form2.Junio(nueva);
            }
            if (comboBox2.Text == "Julio")
            {
                form2.Julio(nueva);
            }
            if (comboBox2.Text == "Agosto")
            {
                form2.Agosto(nueva);
            }
            if (comboBox2.Text == "Septiembre")
            {
                form2.Septiembre(nueva);
            }
            if (comboBox2.Text == "Octubre")
            {
                form2.Octubre(nueva);
            }
            if (comboBox2.Text == "Noviembre")
            {
                form2.Noviembre(nueva);
            }
            if (comboBox2.Text == "Diciembre")
            {
                form2.Diciembre(nueva);
            }
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
