namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxIMC = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelIMC = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(101, 94);
            this.labelPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(145, 31);
            this.labelPeso.TabIndex = 0;
            this.labelPeso.Text = "Peso Atual";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.Location = new System.Drawing.Point(101, 169);
            this.labelAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(146, 31);
            this.labelAltura.TabIndex = 1;
            this.labelAltura.Text = "Altura (cm)";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(285, 176);
            this.textBoxAltura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(132, 22);
            this.textBoxAltura.TabIndex = 2;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(285, 101);
            this.textBoxPeso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(132, 22);
            this.textBoxPeso.TabIndex = 3;
            this.textBoxPeso.TextChanged += new System.EventHandler(this.textBoxPeso_TextChanged);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(109, 336);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(127, 44);
            this.buttonCalcular.TabIndex = 4;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // textBoxIMC
            // 
            this.textBoxIMC.Enabled = false;
            this.textBoxIMC.Location = new System.Drawing.Point(285, 252);
            this.textBoxIMC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIMC.Name = "textBoxIMC";
            this.textBoxIMC.Size = new System.Drawing.Size(132, 22);
            this.textBoxIMC.TabIndex = 5;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(289, 336);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(127, 44);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(469, 336);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(127, 44);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMC.Location = new System.Drawing.Point(145, 246);
            this.labelIMC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(64, 31);
            this.labelIMC.TabIndex = 8;
            this.labelIMC.Text = "IMC";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(109, 414);
            this.txtFrase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(485, 22);
            this.txtFrase.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.textBoxIMC);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelPeso);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxIMC;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelIMC;
        private System.Windows.Forms.TextBox txtFrase;
    }
}

