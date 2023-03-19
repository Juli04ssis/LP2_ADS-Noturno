using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_de_Eventos._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13)) //tecla que foi pressionada, 'enter'
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e) //Já saiu do componente, precisa do focus pra voltar
        {
            if ((textBox2.Text == "") || (textBox2.Text.Length < 10)) //comrpimento < 20. Text é tipo de dado que estou pegando
            {
                MessageBox.Show("Endereço Ínvalido");
                textBox2.Focus();
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e) //ainda está  no componente, e.Cancel = True permite encerrar o looping
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Email Vazio");
                e.Cancel = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13)) //tecla que foi pressionada, 'enter'
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13)) //tecla que foi pressionada, 'enter'
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        { }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13)) //tecla que foi pressionada, 'enter'
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13)) //tecla que foi pressionada, 'enter'
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("celular-textbox4 perdeu o foco");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("cpf-textbox5 ganhou o foco");
        }
    }
}
