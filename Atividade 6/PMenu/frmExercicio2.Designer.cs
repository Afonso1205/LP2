namespace PMenu
{
    partial class frmExercicio2
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnEmpurra = new System.Windows.Forms.Button();
            this.btnEmpurra2 = new System.Windows.Forms.Button();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(172, 103);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(172, 188);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(175, 293);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 39);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar Iguais";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // btnEmpurra
            // 
            this.btnEmpurra.Location = new System.Drawing.Point(300, 293);
            this.btnEmpurra.Name = "btnEmpurra";
            this.btnEmpurra.Size = new System.Drawing.Size(75, 39);
            this.btnEmpurra.TabIndex = 3;
            this.btnEmpurra.Text = "Inserir Meio";
            this.btnEmpurra.UseVisualStyleBackColor = true;
            this.btnEmpurra.Click += new System.EventHandler(this.BtnEmpurra_Click);
            // 
            // btnEmpurra2
            // 
            this.btnEmpurra2.Location = new System.Drawing.Point(425, 293);
            this.btnEmpurra2.Name = "btnEmpurra2";
            this.btnEmpurra2.Size = new System.Drawing.Size(75, 39);
            this.btnEmpurra2.TabIndex = 4;
            this.btnEmpurra2.Text = "Inserir Asteriscos";
            this.btnEmpurra2.UseVisualStyleBackColor = true;
            this.btnEmpurra2.Click += new System.EventHandler(this.BtnEmpurra2_Click);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(275, 100);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 5;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(275, 185);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 6;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 544);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.btnEmpurra2);
            this.Controls.Add(this.btnEmpurra);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnEmpurra;
        private System.Windows.Forms.Button btnEmpurra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
    }
}