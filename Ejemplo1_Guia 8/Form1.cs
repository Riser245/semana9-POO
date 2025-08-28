using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Guia_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal monto = Convert.ToDecimal(txtMonto.Text);
            IPago metodoPago;

            if (rbTarjeta.Checked)
                metodoPago = new PagoConTarjeta();
            else if (rbBitcoin.Checked)
                metodoPago = new PagoConBitcoin();
            else  
                metodoPago = new PagoConEfectivo();

            string resultado = metodoPago.ProcesarPago(monto);
            MessageBox.Show(resultado, "Resultado del Pago");

        }
    }
}
