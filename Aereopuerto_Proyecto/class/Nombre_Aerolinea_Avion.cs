using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aereopuerto_Proyecto
{
  public  class Nombre_Aerolinea_Avion:Reserva_Vuelo
{
        public string Nom_Aerolinea { get; set; }
        public string Nu_Vuelo { get; set; }
        private string tipAvion = "Comercial";
        public string av
        {
            get
            {
                return tipAvion;
            }
            set
            {
                tipAvion = value;
            }
        }
        public int pasajeros { get; set; }
        public string Altura_Máxima { get; set; }
        



    }
}
