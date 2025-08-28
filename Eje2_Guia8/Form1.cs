using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eje2_Guia8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbVehiculos.Items.Add("Carro");
            cmbVehiculos.Items.Add("Bicleta");
            cmbVehiculos.Items.Add("Motocicleta");
            cmbVehiculos.Items.Add("Microbus");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            IVehiculocs vehiculo = null;

            if (cmbVehiculos.SelectedItem.ToString() == "Carro")
                vehiculo = new Carro();
            else if (cmbVehiculos.SelectedItem.ToString() == "Bicicleta")
                vehiculo = new Bicicleta();
            else if (cmbVehiculos.SelectedItem.ToString() == "Motocicleta")
                vehiculo = new Moto();
            else 
                vehiculo = new Microbus();

            lblResultado.Text = vehiculo?.MostrarInformacion();

        }
    }
}
