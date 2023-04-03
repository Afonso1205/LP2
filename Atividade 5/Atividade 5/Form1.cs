using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atividade_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double sal, DINSS, DIRPF, salFam, salLiq;








        private void mskbxSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Digite Somente Numeros");
            }

        }

        private void BtnDesc_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length < 10)
            {
                MessageBox.Show("Nome Inválido");
            }else if (double.TryParse(mskbxSal.Text, out sal))
            // INSS
            {
                
                if (sal <= 800.47)
                {
                    txtBoxAINSS.Text = "7,65%";
                    DINSS = 0.0765 * sal;
                } else if (sal <= 1050) 
                { 
                    txtBoxAINSS.Text = "8,65%";
                    DINSS = 0.0865 * sal;
                }
                else if (sal <= 1400.77)
                {
                    txtBoxAINSS.Text = "9%";
                    DINSS = 0.09 * sal;
                }
                else if (sal <= 2801.56)
                {
                    txtBoxAINSS.Text = "11%";
                    DINSS = 0.11 * sal;
                }
                else if (sal > 2801.56)
                {
                    txtBoxAINSS.Text = "R$ 308.17";
                    DINSS = 308.17;
                }

                // IRFF


                if (sal <= 1257.12)
                {
                    txtBoxAIRPF.Text = "Isento";
                    DIRPF = 0;
                }else if (sal <= 2512.08)
                {
                    txtBoxAIRPF.Text = "15%";
                    DIRPF = 0.15 * sal;
                }else if (sal <= 2512.08)
                {
                    txtBoxAIRPF.Text = "27.5%";
                    DIRPF = 0.275 * sal;
                }

                // Salario Familia

                if (sal <= 435.52)
                {
                    salFam = 22.33 * Convert.ToDouble(CxFilhos);                    
                }else if (sal <= 654.61)
                {
                    salFam = 15.74 * Convert.ToDouble(CxFilhos);
                }else if (sal > 654.61)
                {
                    salFam = 0;
                }

                // Cálculo salário líquido

                salLiq = sal - DINSS - DIRPF + salFam;

                // Impressão de Resultados

                txtBoxDINSS.Text = "R$ " + Convert.ToString(DINSS);
                txtBoxDIRPF.Text = "R$ " + Convert.ToString(DIRPF);
                txtBoxSalF.Text = "R$ " + Convert.ToString(salFam);
                txtBoxSalLiq.Text = "R$ " + Convert.ToString(salLiq);


                if (rbtnM.Checked && rbtnSolteiro.Checked)
                {
                    txtBoxTexto.Text = "Os descontos do salário do Sr " + txtNome.Text + " que é solteiro e tem " + CxFilhos.Text + " filhos.";
                }else if (rbtnF.Checked && rbtnSolteiro.Checked)
                {
                    txtBoxTexto.Text = "Os descontos do salário da Sra " + txtNome.Text + " que é solteira e tem " + CxFilhos.Text + " filhos.";
                }else if (rbtnM.Checked && rbtnCasado.Checked)
                {
                    txtBoxTexto.Text = "Os descontos do salário do Sr " + txtNome.Text + " que é casado e tem " + CxFilhos.Text + " filhos.";
                }else if (rbtnF.Checked && rbtnCasado.Checked)
                {
                    txtBoxTexto.Text = "Os descontos do salário da Sra " + txtNome.Text + " que é casada e tem " + CxFilhos.Text + " filhos.";
                }





            }









        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Char.IsNumber(e.KeyChar)) || Char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Caracter Inválido");
            }
        }






    }
}
