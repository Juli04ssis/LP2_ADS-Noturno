using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Cilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtRaio_Validating(object sender, CancelEventArgs e)
        {
            if (txtRaio.Text == "")
            {
                MessageBox.Show("Digite um valor para o Raio");
                e.Cancel = true;
            }
        }

        private void txtAltura_Validating(object sender, CancelEventArgs e)
        {
            if (txtRaio.Text == "")
            {
                MessageBox.Show("Digite um valor para Altura");
                e.Cancel = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valRaio, valAltura, valVolume;

            valAltura = Convert.ToDouble(txtAltura.Text);
            valRaio = Convert.ToDouble(txtRaio.Text);

            valVolume = 3.14 * (valRaio * valRaio) * valAltura;

            txtVolume.Text = String.Format("{0} cm3", valVolume);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
