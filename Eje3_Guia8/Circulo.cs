using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Eje3_Guia8
{
    internal class Circulo : FiguraGeometrica, InterfaceFiguras
    {
        public int Radio { get; set; }

        public Circulo(int radio) { Radio = radio; }


        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public void Dibujar(Graphics g)
        {
            g.FillEllipse(Brushes.Red, 10, 10, Radio * 2, Radio * 2);
        }
    }
}