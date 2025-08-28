using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Guia_8
{
    internal interface IPago
    {
        string ProcesarPago(decimal monto);
    }
}
