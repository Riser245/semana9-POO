using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Eje3_Guia8
{
    internal class triangulo : FiguraGeometrica, InterfaceFiguras
    {
        public int Base { get; set; }

        public int Altura { get; set; }

        public triangulo(int b, int h)
        {
            Base = b; Altura = h;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2.0;
        }

        public void Dibujar(Graphics g)
        {
            Point[] puntos =
            {
                new Point(10, 10 + Altura),
                new Point(10 + Base, 10 + Altura),
                new Point(10 + Base/2,10)
            };
            g.FillPolygon(Brushes.Green, puntos);
        }
    }
}
