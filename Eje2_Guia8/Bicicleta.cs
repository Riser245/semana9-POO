using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2_Guia8
{
    internal class Bicicleta: IVehiculocs
    {
        public string MostrarInformacion()
        {
            return $"Soy una bicicleta y tengo capacidad para 1 o 2 paajeros";
        }
    }
}
