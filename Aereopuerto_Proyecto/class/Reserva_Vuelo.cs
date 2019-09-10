using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aereopuerto_Proyecto
{
   public class Reserva_Vuelo:Instalacion_aereopuerto
    {
        public bool Reserva { get; set; }
        public int no_Semana { get; set; }
        public int dia { get; set; }
        public string Mes { get; set; }
        public string Destino { get; set; }
        public string Origen { get; set; }

    }
}
