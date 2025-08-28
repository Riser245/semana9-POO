using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eje3_Guia8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFiguras.Items.Add("Cuadrado");
            cmbFiguras.Items.Add("Circulo");
            cmbFiguras.Items.Add("Triangulo");

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Graphics g = picCanvas.CreateGraphics();
            g.Clear(Color.LightGray);

            FiguraGeometrica figura = null;
            InterfaceFiguras dibujable = null;

            try
            {
                string seleccion = cmbFiguras.SelectedItem.ToString();

                if (seleccion == "Cuadrado")
                {
                    int lado = int.Parse(txtValor1.Text);
                    figura = new Cuadrado(lado);
                    dibujable = (InterfaceFiguras)figura;
                }
                else if (seleccion == "Circulo")
                {
                    int radio = int.Parse(txtValor1.Text);
                    figura = new Circulo(radio);
                    dibujable = (InterfaceFiguras)figura;
                }
                else if (seleccion == "Triangulo") 
                {
                    int b = int.Parse(txtValor1.Text);
                    int h = int.Parse(txtValor2.Text);
                    figura = new triangulo(b, h);
                    dibujable = (InterfaceFiguras)figura;
                }

                dibujable?.Dibujar(g);
                lblArea.Text = $"Area: {figura.CalcularArea()}";

            }
            catch
            {
                MessageBox.Show("Por favor ingresar valores validos");
            }
        }
    }
}
