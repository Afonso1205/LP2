using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double altura, peso, imc;

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            textBoxAltura.Clear();
            textBoxPeso.Clear();
            textBoxIMC.Clear();
        }

        private void textBoxPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(textBoxAltura.Text, out altura)) && (double.TryParse(textBoxPeso.Text, out peso)))
            {
                if (altura <= 0 || peso <= 0)
                {
                    MessageBox.Show("A altura e o peso não pode ser igual ou menor que zero");
                }
                else
                {
                    imc = peso / Math.Pow((altura / 100),2);
                    imc = Math.Round(imc, 1); // arredonda 1 primeira casa decimal
                    textBoxIMC.Text = imc.ToString();

                    if (imc < 1.8)
                    {
                        txtFrase.Text = "Esta classificado com Magreza";
                    }else if (imc < 24.9)
                    {
                        txtFrase.Text = "Esta classificado com Normal";
                    }
                    else if (imc < 29.9)
                    {
                        txtFrase.Text = "Esta classificado com Sobrepeso";
                    }
                    else if(imc < 39.9)
                    {
                        txtFrase.Text = "Esta classificado com Obesidade";
                    }
                    else if(imc > 40)
                    {
                        txtFrase.Text = "Esta classificado com Obesidade Grave";
                    }







                }
            }
            else
                MessageBox.Show("Numeros Inváldos");
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
