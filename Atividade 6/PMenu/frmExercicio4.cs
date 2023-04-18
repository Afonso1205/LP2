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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int i, cont = 0;
            for (i= 0; i < (rtxtboxTexto.Text.Length); i++)
            {
                char caracter = (Convert.ToChar(rtxtboxTexto.Text[i]));

                if (Char.IsNumber(caracter))                {
                    cont++;
                }               
            }
            MessageBox.Show(Convert.ToString(cont));


        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            int i = 0, cont = 0;

            do
            {
                
                char caracter = (Convert.ToChar(rtxtboxTexto.Text[i]));

                if (Char.IsWhiteSpace(caracter))
                {
                    cont++;
                }
                i++;

            }while (i < (rtxtboxTexto.Text.Length));


                MessageBox.Show(Convert.ToString(cont));
        }

        private void btnCarac_Click(object sender, EventArgs e)
        {
            int i, cont = 0;
            for (i = 0; i < (rtxtboxTexto.Text.Length); i++)
            {
                char caracter = (Convert.ToChar(rtxtboxTexto.Text[i]));

                if (Char.IsLetter(caracter))
                {
                    cont++;
                }
            }
            MessageBox.Show(Convert.ToString(cont));
        }
    }
}
