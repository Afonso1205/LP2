using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1, num2, num3;


        private void btnTeste_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtbNum1.Text, out num1)) && (double.TryParse(txtbNum2.Text, out num2)) && (double.TryParse(txtbNum3.Text, out num3)))
                {
                if (num1 <= 0 || num2 <= 0 || num3 <= 0)
                {
                    MessageBox.Show("Os números não podem ser menor ou igual a 0");
                }else
                {
                    if (Math.Abs(num2 - num3) < num1 && num1 < (num2 + num3) && Math.Abs(num1- num3) < num2 && num2 < (num1 + num3) && Math.Abs(num1 - num2) < num3 && num3 < (num1 + num2))
                    {
                        if (num1 == num2 && num2 == num3)
                        {
                            txtResultado.Text = "Pode formar um triangulo equilátero";
                        }else if (num1 == num2 || num2 == num3)
                        {
                            txtResultado.Text = "Pode formar um triangulo isóceles";
                        }else
                        {
                            txtResultado.Text = "Pode formar um triangulo escaleno";
                        }
                    }
                    else
                    {
                        txtResultado.Text = "Não pode ser um triangulo";
                    }
                }


            } else
                MessageBox.Show("As entradas devem ser números");



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbNum1.Clear();
            txtbNum2.Clear();
            txtbNum3.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
