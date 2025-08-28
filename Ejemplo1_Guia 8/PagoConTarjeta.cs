using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Guia_8
{
    internal class PagoConTarjeta:IPago
    {
        public string ProcesarPago(decimal monto)
        {
            return $"Pago con tarjeta procesado por ${monto}";
        }
    }
}
