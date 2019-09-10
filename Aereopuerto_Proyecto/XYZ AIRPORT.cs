using System;
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
    public partial class XYZ_AIRPORT : Form
    {
        Form1 form1;
        public XYZ_AIRPORT(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            load();
            car();
            button1.Visible = true;

        }
        private void load()
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox1.Visible = true;
            

        }
        private void car(){
            if (pictureBox1.Visible == true && pictureBox2.Visible == true && pictureBox3.Visible == true)
            {
                Thread.Sleep(20);
               
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
