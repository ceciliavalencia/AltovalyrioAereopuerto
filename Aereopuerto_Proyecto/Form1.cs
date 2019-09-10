using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aereopuerto_Proyecto
{
    public partial class Form1 : Form
    {
        Queue cola1 = new Queue();
        Queue cola2 = new Queue();
        Queue cola3 = new Queue();
        Queue cola4 = new Queue();
        Queue cola5 = new Queue();
        Queue cola6 = new Queue();
        Queue cola7 = new Queue();
        Queue cola8 = new Queue();
        Queue cola9 = new Queue();
        Queue cola10 = new Queue();

        List<Nombre_Aerolinea_Avion> Aerolineas = new List<Nombre_Aerolinea_Avion>();

        //LISTA MESES DEL ANIO
        List<Nombre_Aerolinea_Avion> marzo = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> abril = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> mayo = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> junio = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> julio = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> agosto = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> septiembre = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> octubre = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> noviembre = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> diciembre = new List<Nombre_Aerolinea_Avion>();
       
        List<Nombre_Aerolinea_Avion> aterri = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> despe = new List<Nombre_Aerolinea_Avion>();

        /// ------AGREGADO DE EXAMEN 
        List<Nombre_Aerolinea_Avion> Carga = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> VIP = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> Pasajeros = new List<Nombre_Aerolinea_Avion>();
        List<Nombre_Aerolinea_Avion> Jumbo = new List<Nombre_Aerolinea_Avion>();
        //pista10 emergencia
        List<Instalacion_aereopuerto> EMER = new List<Instalacion_aereopuerto>();


        public Form1()
        {
            InitializeComponent();
        
            bienve();
            button4.Visible=true;
           

        }
        private void ingresodatos()
        {
            var empre1 = new Nombre_Aerolinea_Avion
            {
                Nom_Aerolinea = "TACA",
                Nu_Vuelo = "TA001",
                pasajeros = 200,
                Reserva = true,
                Mes = "Marzo",
                no_Semana = 3,
                dia=6,
                No_Pista = 1,
                Tipo = "Aterrizaje",
                Piloto = "Juanito Bosques",
                tel = 5412222,
                Altura_Máxima = "42000 ft",
                Tipo_Motor = "Turbohélice",
                Uso = "Comercial",
                Origen = "Colombia",
                Destino = "Guatemala"

            };
            Aerolineas.Add(empre1);
            aterri.Add(empre1);
            Pasajeros.Add(empre1);
         
            var empre2 = new Nombre_Aerolinea_Avion
            {
                Nom_Aerolinea = "Avianca",
                Nu_Vuelo = "001",
                pasajeros=2000,
                Reserva = true,
                no_Semana = 2,
                Mes = "Marzo",
                dia=6,
                No_Pista = 5,
                Tipo = "Aterrizaje",
                Piloto = "Pedro Vasquez",
                tel = 89742222,
                Altura_Máxima = "42000 ft",
                Tipo_Motor = "Turbohélice",
                Uso = "Jumbo",
                Origen = "Estados Unidos",
                Destino = "Guatemala"


            };
            Aerolineas.Add(empre2);
            aterri.Add(empre2);
            Jumbo.Add(empre2);
           
            
            var empre3 = new Nombre_Aerolinea_Avion
            {
                Nom_Aerolinea = "EUROWINGS",
                Nu_Vuelo = "EW001",
                Reserva = true,
                pasajeros=2,
                no_Semana = 3,
                Mes = "Marzo",
                dia=2,
                No_Pista = 9,
                Tipo = "Despegar",
                Piloto = "Andres Bermudez",
                tel = 86325417,
                Altura_Máxima= "42000 ft",
                Tipo_Motor="Turbohélice",
                Uso="Carga",
                Origen = "Puerto Rico",
                Destino = "Guatemala"

            };
            Aerolineas.Add(empre3);
            despe.Add(empre3);
            Carga.Add(empre3);
         
            var empre4 = new Nombre_Aerolinea_Avion
            {
                Nom_Aerolinea = "PRIV",
                Nu_Vuelo = "PRIV002",
                pasajeros=2,
                av="Helicoptero",
                Reserva = true,
                no_Semana = 2,
                Mes = "Abril",
                dia=4,
                No_Pista = 8,
                Tipo = "Despegar",
                Piloto = "Armando Casas",
                tel = 89745632,
                Altura_Máxima= "4082.021 ft.",
                Tipo_Motor = "Turbohélice",
                Uso = "Privado",
                Origen="Guatemala",
                Destino="Puerto Rico"

            };
            Aerolineas.Add(empre4);
            despe.Add(empre4);
            abril.Add(empre4);
            VIP.Add(empre4);

            marzo.Add(empre1);
            marzo.Add(empre2);
            marzo.Add(empre3);
            
        }
        private void ingresodatos(string Nom_Aerolinea, string Nu_Vuelo, string Mes, string Tipo,string Piloto,int pasajeros, int no_Semana, int dia, int No_Pista,bool Reserva, int tel,string Motor, string Origen, string Destino, string Alt, string uso)
        {
            var emerg = new Nombre_Aerolinea_Avion
            {
                Nom_Aerolinea = Nom_Aerolinea,
                Nu_Vuelo = Nu_Vuelo,
                Reserva = Reserva,
                no_Semana = no_Semana,
                Mes = Mes,
                No_Pista = No_Pista,
                Tipo = Tipo,
                Piloto = Piloto,
                tel = tel,
                av="NO INDICA",
                Tipo_Motor=Motor,
                Altura_Máxima=Alt,
                Destino=Destino,
                Origen=Origen,
                Uso=uso

            };
            Aerolineas.Add(emerg);
            EMER.Add(emerg);
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            label1.Visible = true;
            textBox1.Visible = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button2.Visible = true;
            comboBox2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView3.Rows.Clear();

            ingresodatos();
            ingresodatos("EMERGENCIA", "PRIORIDAD", "INDEFINIDO", "PRIORIDAD", "NO INDICA",0,0,0,10,false,0,"NO INDICA","PRIORIDAD","PRIORIDAD","NO INDICA","EMERGENCIA");
            dataGridView1.Visible = true;
            //fuente de llenado para DataGriedView
            BindingSource bs = new BindingSource();
            bs.DataSource = Aerolineas;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    r.Visible = false;

                }
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper().IndexOf(textBox1.Text.ToUpper())) == 0)
                        {
                            r.Visible = true;

                            break;
                        }
                    }

                }
            }
            else
            {

                MessageBox.Show("Usted no se encuentra en la base de datos registrese \n PRECIONE EL EL BOTÓN VUELOS DE NUEVO", "NO REGISTRADO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }
        //pasar datos de datagrid1 a data2
        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            comboBox1.Visible = true;
            button3.Visible = true;
            radioButton2.Visible = true;
            label2.Visible = true;
            label13.Visible = true;
            dataGridView2.Rows.Add(new string[] {
                Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[4, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[5, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[6, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[7, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[8, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[9, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[10, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[11, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[12, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[13, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[14, dataGridView1.CurrentRow.Index].Value),
                Convert.ToString(dataGridView1[15, dataGridView1.CurrentRow.Index].Value),
              
            });
        }

      
        //despegue o aterrizaje
        private void button3_Click(object sender, EventArgs e)
        {
           
            button4.Visible = true;
           
            if (radioButton1.Checked==true && radioButton2.Checked==false)
            {
                pictureBox2.Visible = false;
                button5.Visible = true;
                pictureBox1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                textBox3.Text = "";
                textBox4.Text = "";
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
            if (radioButton2.Checked == true && radioButton1.Checked == false)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
               

               button5.Visible = true;
                 button4.Visible = true;
                 label3.Visible = false;
                 label4.Visible = false;
                 label5.Visible = false;
                 label6.Visible = false;
                 label7.Visible = false;
                 label8.Visible = false;
                 label9.Visible = false;
                 label10.Visible = false;
                 label11.Visible = false;
                 label12.Visible = false;
                 label13.Visible = false;
                 textBox3.Text = "";
                 textBox4.Text = "";
                 textBox3.Visible = false;
                 textBox4.Visible = false;

                despegue();
            }
        }

        private void despegue()
        {
            int dis=15;
            double titiempo;
            
            
            titiempo = dis / 80;
           
            //tiempo en minutos
            double tm = titiempo * 60;
          
            MessageBox.Show("tiempo estimado: "+tm);

        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            var x = e.X;
            var y = e.Y;
            textBox3.Text = Convert.ToString(x);
            textBox4.Text = Convert.ToString(y);
            int aereo = 141;
            //cálculo de distancia a partir de coordenadas
            double distancia;
            distancia = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y, 2));
            if (distancia>141)
            {
                distancia = distancia - 141;
                distancia = distancia * -1;

            }
            if (distancia<141)
            {
                distancia = distancia - 141;
                distancia = distancia * -1;
            }

           //calculo de tiempo en base a la distancia
            double tiempo;
            Math.Round(distancia, 2);
            //tiempo en horas
            tiempo = distancia / 800;
            Math.Round(tiempo,2);
            label8.Text = Convert.ToString(tiempo.ToString().Substring(0, 4) + " h");
            label4.Text = Convert.ToString(distancia.ToString().Substring(0, 4)) +" km.";
            //tiempo en minutos
            double tm = tiempo * 60;
            Math.Round(tm,2);
            label9.Text = Convert.ToString(tm.ToString().Substring(0, 4) + " min.");

           //tiempo en segundos
            double ts = tm * 60;
            Math.Round(ts,2);
            label10.Text = Convert.ToString(ts.ToString().Substring(0, 4) + " s.");
        }

        //método para ejecución de cálculo cuando la pista está llena ** AUMENTA
        private void calcu()
        {
            double tmret;
            double tiemptraso;
            tiemptraso = Convert.ToDouble(label8.Text.Substring(0, 4));
            tmret=1+ tiemptraso;
            Math.Round(tmret,2);
            label8.Text = Convert.ToString(tmret);
            double tm = tmret * 60;
            Math.Round(tm,2);
            label9.Text = Convert.ToString(tm);
            double ts = tm * 60;
            Math.Round(ts,2);
            label10.Text = Convert.ToString(ts);

        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            var x = e.X;
            var y = e.Y;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string men = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            Thread.Sleep(50);
            int poc;
            poc = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows.RemoveAt(poc);
            MessageBox.Show("EJECUTANDO ACCION");
            Thread.Sleep(200);
            if (comboBox1.Text == "1")
            {

                cola1.Dequeue();

            }
            if (comboBox1.Text == "2")
            {
              
                cola2.Dequeue();
            }
            if (comboBox1.Text == "3")
            {
                
                cola3.Dequeue();
            }
            if (comboBox1.Text == "4")
            {
              
                cola4.Dequeue();

            }
            if (comboBox1.Text == "5")
            {
               
                cola5.Dequeue();
            }
            if (comboBox1.Text == "6")
            {
                
                cola6.Dequeue();
            }
            if (comboBox1.Text == "7")
            {
               
                cola7.Dequeue();

            }
            if (comboBox1.Text == "8")
            {
              
                cola8.Dequeue();
            }
            if (comboBox1.Text == "9")
            {
              
                cola9.Dequeue();
            }
            if (comboBox1.Text == "10")
            {
               
                cola10.Dequeue();
            }

            
        }
        public void Aerolis(Nombre_Aerolinea_Avion nueva)
        {
           
            Aerolineas.Add(nueva);
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = nueva;
            dataGridView1.DataSource = bs1;
            dataGridView1.Refresh();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var Programar_Vuelo = new Programar_Vuelo(this))
            {
                Programar_Vuelo.ShowDialog();
            }
        }
 

        private void button5_Click(object sender, EventArgs e)
        {
            string mensaje;
            mensaje = "";
            textBox2.Text = mensaje;

            if (comboBox1.Text == "1")
            {
                cola1.Enqueue((mensaje));
                if (cola1.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola1.Count > 1)
                {
                    MessageBox.Show("   La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    calcu();
                }
            }
            if (comboBox1.Text == "2")
            {
                cola2.Enqueue((mensaje));
                if (cola2.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola2.Count > 1)
                {
                    MessageBox.Show("   La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    calcu();
                }
            }
            if (comboBox1.Text == "3")
            {
                cola3.Enqueue((mensaje));
                if (cola3.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola3.Count > 1)
                {
                    MessageBox.Show("   La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    calcu();
                }
            }
            if (comboBox1.Text == "4")
            {
                cola4.Enqueue((mensaje));
                if (cola4.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola4.Count > 1)
                {
                    MessageBox.Show("   La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    calcu();
                }
            }
            if (comboBox1.Text == "5")
            {
                cola5.Enqueue((mensaje));
                if (cola5.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola5.Count > 1)
                {
                    MessageBox.Show("La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    calcu();
                }
            }
            if (comboBox1.Text == "6")
            {
                cola6.Enqueue((mensaje));
                if (cola6.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola6.Count > 1)
                {
                    MessageBox.Show("La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    calcu();
                }
            }
            if (comboBox1.Text == "7")
            {
                cola7.Enqueue((mensaje));
                if (cola7.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola7.Count > 1)
                {
                    MessageBox.Show("La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    calcu();
                }
            }
            if (comboBox1.Text == "8")
            {
                cola8.Enqueue((mensaje));
                if (cola8.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola8.Count > 1)
                {
                    MessageBox.Show("La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    calcu();
                }
            }
            if (comboBox1.Text == "9")
            {
                cola9.Enqueue((mensaje));
                if (cola9.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola9.Count > 1)
                {
                    MessageBox.Show("La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    calcu();
                }
            }
            if (comboBox1.Text == "10")
            {
                cola10.Enqueue((mensaje));
                if (cola10.Count == 2)
                { MessageBox.Show("PISTA DE EMERGENCIA"); }
                if (cola10.Count > 2)
                { MessageBox.Show("PISTA DE EMERGENCIA LLENA, ESPERE", "PISTA LLENA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            }
        }
        private void jjj()
        {
            button4.Visible = true;
            string mensaje;
            mensaje = "";
            textBox2.Text = mensaje;

            if (comboBox1.Text == "1")
            {
                cola1.Enqueue((mensaje));
                if (cola1.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola1.Count > 1)
                {
                    MessageBox.Show("   La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                   
                }
            }
            if (comboBox1.Text == "2")
            {
                cola2.Enqueue((mensaje));
                if (cola2.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola2.Count > 1)
                {
                    MessageBox.Show("   La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                }
            }
            if (comboBox1.Text == "3")
            {
                cola3.Enqueue((mensaje));
                if (cola3.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola3.Count > 1)
                {
                    MessageBox.Show("   La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                }
            }
            if (comboBox1.Text == "4")
            {
                cola4.Enqueue((mensaje));
                if (cola4.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola4.Count > 1)
                {
                    MessageBox.Show("   La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                }
            }
            if (comboBox1.Text == "5")
            {
                cola5.Enqueue((mensaje));
                if (cola5.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola5.Count > 1)
                {
                    MessageBox.Show("La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                   
                }
            }
            if (comboBox1.Text == "6")
            {
                cola6.Enqueue((mensaje));
                if (cola6.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola6.Count > 1)
                {
                    MessageBox.Show("La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                }
            }
            if (comboBox1.Text == "7")
            {
                cola7.Enqueue((mensaje));
                if (cola7.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola7.Count > 1)
                {
                    MessageBox.Show("La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                }
            }
            if (comboBox1.Text == "8")
            {
                cola8.Enqueue((mensaje));
                if (cola8.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola8.Count > 1)
                {
                    MessageBox.Show("La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                }
            }
            if (comboBox1.Text == "9")
            {
                cola9.Enqueue((mensaje));
                if (cola9.Count == 1)
                { MessageBox.Show("Verificando pista...\n PROCEDA", "VERIFICANDO...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                if (cola9.Count > 1)
                {
                    MessageBox.Show("La pista se encuentra en uso, \n ESPERE EN EL AIRE\n RETRASO DE 1 HORA", "PISTA EN USO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                  
                }
            }
            if (comboBox1.Text == "10")
            {
                cola10.Enqueue((mensaje));
                if (cola10.Count == 2)
                { MessageBox.Show("PISTA DE EMERGENCIA"); }
                if (cola10.Count > 2)
                { MessageBox.Show("PISTA DE EMERGENCIA LLENA, ESPERE", "PISTA LLENA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            BindingSource bsaterri = new BindingSource();
            bsaterri.DataSource = aterri;
            dataGridView1.DataSource = bsaterri;
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            BindingSource bsdespegue = new BindingSource();
            bsdespegue.DataSource = despe;
            dataGridView1.DataSource = bsdespegue;
            dataGridView1.Refresh();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            dataGridView1.Visible=false;
            if (comboBox2.Text.Equals("Marzo"))
            {
                dataGridView3.Rows.Clear();
                BindingSource bsmarzo = new BindingSource();
                bsmarzo.DataSource = marzo;
                dataGridView3.DataSource = bsmarzo;
                dataGridView3.Refresh();
            }
            if (comboBox2.Text.Equals("Abril"))
            {
                dataGridView3.Rows.Clear();
                BindingSource bsabril = new BindingSource();
                bsabril.DataSource = abril;
                dataGridView3.DataSource = bsabril;
                dataGridView3.Refresh();
            }
            if (comboBox2.Text.Equals("Mayo"))
            {
                dataGridView3.Rows.Clear();
                BindingSource bsmayo = new BindingSource();
                bsmayo.DataSource = mayo;
                dataGridView3.DataSource = bsmayo;
                dataGridView3.Refresh();
            }
            if (comboBox2.Text.Equals("Junio"))
            {
                dataGridView3.Rows.Clear();
                BindingSource bsjunio = new BindingSource();
                bsjunio.DataSource = junio;
                dataGridView3.DataSource = bsjunio;
                dataGridView3.Refresh();
            }
            if (comboBox2.Text.Equals("Julio"))
            {
                dataGridView3.Rows.Clear();
                BindingSource bsjulio = new BindingSource();
                bsjulio.DataSource = julio;
                dataGridView3.DataSource = bsjulio;
                dataGridView3.Refresh();
            }
            if (comboBox2.Text.Equals("Agosto"))
            {
                dataGridView3.Rows.Clear();
                BindingSource bsagosto = new BindingSource();
                bsagosto.DataSource = agosto;
                dataGridView3.DataSource = bsagosto;
                dataGridView3.Refresh();
            }
            if (comboBox2.Text.Equals("Septiembre"))
            {
                dataGridView3.Rows.Clear();
                BindingSource bsseptiembre = new BindingSource();
                bsseptiembre.DataSource = septiembre;
                dataGridView3.DataSource = bsseptiembre;
                dataGridView3.Refresh();
            }
            if (comboBox2.Text.Equals("Octubre"))
            {
                dataGridView3.Rows.Clear();
                BindingSource bsoctubre = new BindingSource();
                bsoctubre.DataSource = octubre;
                dataGridView3.DataSource = bsoctubre;
                dataGridView3.Refresh();
            }
            if (comboBox2.Text.Equals("Noviembre"))
            {
                dataGridView3.Rows.Clear();
                BindingSource msnov = new BindingSource();
                msnov.DataSource = noviembre;
                dataGridView3.DataSource = msnov;
                dataGridView3.Refresh();
            }
            if (comboBox2.Text.Equals("Diciembre"))
            {
                dataGridView3.Rows.Clear();
                BindingSource bsdici = new BindingSource();
                bsdici.DataSource = diciembre;
                dataGridView3.DataSource = bsdici;
                dataGridView3.Refresh();
            }


        }
        public void Marzo(Nombre_Aerolinea_Avion nueva)
        {
            marzo.Add(nueva);
        }
        public void Abril(Nombre_Aerolinea_Avion nueva)
        {
            abril.Add(nueva);
        }
        public void Mayo(Nombre_Aerolinea_Avion nueva)
        {
            mayo.Add(nueva);
        }
        public void Junio(Nombre_Aerolinea_Avion nueva)
        {
            junio.Add(nueva);
        }
        public void Julio(Nombre_Aerolinea_Avion nueva)
        {
            julio.Add(nueva);
        }
        public void Agosto(Nombre_Aerolinea_Avion nueva)
        {
            agosto.Add(nueva);
        }
        public void Septiembre(Nombre_Aerolinea_Avion nueva)
        {
            septiembre.Add(nueva);
        }
        public void Octubre(Nombre_Aerolinea_Avion nueva)
        {
            octubre.Add(nueva);
        }
        public void Noviembre(Nombre_Aerolinea_Avion nueva)
        {
            noviembre.Add(nueva);
        }
        public void Diciembre(Nombre_Aerolinea_Avion nueva)
        {
            diciembre.Add(nueva);
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var Contacto = new Contacto(this))
            {
                Contacto.ShowDialog();
            }

        }

        private void calificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var Exper = new Calificar_Experiencia(this))
            {
                Exper.ShowDialog();
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var acerc = new Acerca_de_XYZ_AIRPORT(this))
            {
                acerc.ShowDialog();
            }
        }

        private void aplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var acercade = new Acerca_De(this))
            {
                acercade.ShowDialog();
            }
        }
        private void bienve()
        {
            using (var bvn = new XYZ_AIRPORT(this))
            {
                bvn.ShowDialog();
            }
           ;
           
        }

        private void reservaDeNuevoVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
       
      
    
    
}
