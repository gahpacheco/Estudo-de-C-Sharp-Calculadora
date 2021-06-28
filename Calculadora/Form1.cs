using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal storage1 = 0, storage2 = 0;
        string operacao = ""; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") {
                storage2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                if (operacao == "Soma")
                {
                    txtResultado.Text = Convert.ToString(storage1 + storage2);
                }
                else if (operacao == "Subtração")
                {
                    txtResultado.Text = Convert.ToString(storage1 - storage2);
                }
                else if (operacao == "Divisão")
                {
                    txtResultado.Text = Convert.ToString(storage1 / storage2);
                }
                else
                {
                    txtResultado.Text = Convert.ToString(storage1 * storage2);
                }
            }
            
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") 
            {
                storage1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Subtração";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") { 
            storage1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "Multiplicação";
            }
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                storage1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Divisão";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            storage1 = 0;
            storage2 = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                storage1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Soma";
            }
        }
    }
}
