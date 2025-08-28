using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Guia_8
{
    internal class PagoConBitcoin:IPago
    {
        public string ProcesarPago(decimal monto)
        {
            return $"Pago con Bitcoin procesado por ${monto}";
        }
    }
}
