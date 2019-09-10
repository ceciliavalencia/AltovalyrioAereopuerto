using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aereopuerto_Proyecto
{
   public class Datos_Piloto:CaracteristicasExtraAvion
   {    public string Piloto { get; set; }
        public int tel { get; set; }
        List<Datos_Piloto> listapilotos = new List<Datos_Piloto>();

   }
}
