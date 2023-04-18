using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnRemova1_Click(object sender, EventArgs e)
        {
            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            //ss
            //assessoria
            //posição = 1

            while (posicao >= 1)
            {

                txtPalavra2.Text = txtPalavra2.Text.Substring(0,posicao)+
                txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length, txtPalavra2.Text.Length - txtPalavra1.Text.Length - posicao);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void BtnRemova2_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void BtnInverte_Click(object sender, EventArgs e)
        {
            char[] vetor = txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor);

            string retorno = "";
            foreach (char c in vetor)
                retorno += c;

            MessageBox.Show(retorno);
        }
    }
}
