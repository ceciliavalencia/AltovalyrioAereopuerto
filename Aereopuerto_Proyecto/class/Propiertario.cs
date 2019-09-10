using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aereopuerto_Proyecto
{
    public class Propiertario
{
        private string Nombre = "XYZ AIRPORT";
        private int no = 55874589;
        private int Fax = 55874589;
        private string direccion =" zona 10, 89-75";
        private string Email = "xyzairport@air.com";
        

        public string Propetario
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public int Tel
        {
            get
            {
                return no;
            }
            set
            {
                no = value;
            }
        }
        
        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }
        public string Em
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        public int fAX
        {
            get
            {
                return Fax;
            }
            set
            {
                Fax = value;
            }
        }
      
    }
}
