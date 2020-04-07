using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double imc = 0;
            string situacao = "";

            imc = Double.Parse(textBoxPeso.Text) / (Double.Parse(textBoxAltura.Text) * Double.Parse(textBoxAltura.Text));
            situacao = (imc < 17) ? "Muito abaixo do peso" : (imc < 18.50) ? "Abaixo do Peso" : (imc < 25) ? "Peso Normal" : (imc < 30) ? "Acima do Peso" : (imc < 35) ? "Obesidade I" : (imc < 40) ? "Obesidade II" : "Obesidade III";

            MessageBox.Show("Seu IMC é : " + Convert.ToString(imc) + "\n" + "Sua situação é : " + situacao);
          

        }
    }
}
