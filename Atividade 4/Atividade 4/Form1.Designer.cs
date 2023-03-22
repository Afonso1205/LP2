namespace Atividade_4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNum1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.Label();
            this.txtNum3 = new System.Windows.Forms.Label();
            this.txtbNum1 = new System.Windows.Forms.TextBox();
            this.txtbNum2 = new System.Windows.Forms.TextBox();
            this.txtbNum3 = new System.Windows.Forms.TextBox();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.AutoSize = true;
            this.txtNum1.Location = new System.Drawing.Point(271, 47);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(65, 16);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.Text = "Numero 1";
            // 
            // txtNum2
            // 
            this.txtNum2.AutoSize = true;
            this.txtNum2.Location = new System.Drawing.Point(271, 106);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(65, 16);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.Text = "Numero 2";
            // 
            // txtNum3
            // 
            this.txtNum3.AutoSize = true;
            this.txtNum3.Location = new System.Drawing.Point(271, 165);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(65, 16);
            this.txtNum3.TabIndex = 2;
            this.txtNum3.Text = "Numero 3";
            // 
            // txtbNum1
            // 
            this.txtbNum1.Location = new System.Drawing.Point(356, 44);
            this.txtbNum1.Name = "txtbNum1";
            this.txtbNum1.Size = new System.Drawing.Size(100, 22);
            this.txtbNum1.TabIndex = 3;
            // 
            // txtbNum2
            // 
            this.txtbNum2.Location = new System.Drawing.Point(356, 103);
            this.txtbNum2.Name = "txtbNum2";
            this.txtbNum2.Size = new System.Drawing.Size(100, 22);
            this.txtbNum2.TabIndex = 4;
            // 
            // txtbNum3
            // 
            this.txtbNum3.Location = new System.Drawing.Point(356, 162);
            this.txtbNum3.Name = "txtbNum3";
            this.txtbNum3.Size = new System.Drawing.Size(100, 22);
            this.txtbNum3.TabIndex = 5;
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(245, 224);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(75, 23);
            this.btnTeste.TabIndex = 6;
            this.btnTeste.Text = "Testar";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(369, 224);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(493, 224);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(245, 281);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(323, 22);
            this.txtResultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.txtbNum3);
            this.Controls.Add(this.txtbNum2);
            this.Controls.Add(this.txtbNum1);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNum1;
        private System.Windows.Forms.Label txtNum2;
        private System.Windows.Forms.Label txtNum3;
        private System.Windows.Forms.TextBox txtbNum1;
        private System.Windows.Forms.TextBox txtbNum2;
        private System.Windows.Forms.TextBox txtbNum3;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

