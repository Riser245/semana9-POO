using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Eje3_Guia8
{
    internal class Cuadrado:FiguraGeometrica,InterfaceFiguras
    {
        public int lado { get; set; }

        public Cuadrado(int Lado)
        {
            lado = Lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public void Dibujar(Graphics g)
        {
            g.FillRectangle(Brushes.Blue, 10,10, lado,lado);
        }
    }
}
