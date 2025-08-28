using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2_Guia8
{
    internal class Microbus:IVehiculocs
    {
        public string MostrarInformacion()
        {
            return $"Soy un microbus y tengo capacidad para 5 a 20 paajeros";
        }
    }
}
