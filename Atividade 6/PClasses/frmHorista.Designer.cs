namespace PClasses
{
    partial class frmHorista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.txtBoxMatricula = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxSalario = new System.Windows.Forms.TextBox();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.txtBoxData = new System.Windows.Forms.TextBox();
            this.txtBoxDias = new System.Windows.Forms.TextBox();
            this.gBoxHome = new System.Windows.Forms.GroupBox();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.gBoxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(84, 94);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(84, 122);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(84, 150);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(83, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário por Hora";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(84, 178);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(90, 13);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Número de Horas";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(84, 206);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(144, 13);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data de Entrada na Empresa";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(84, 234);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(69, 13);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "Dias de Falta";
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Location = new System.Drawing.Point(244, 278);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(75, 23);
            this.btnInstanciar.TabIndex = 6;
            this.btnInstanciar.Text = "Instanciar";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            // 
            // txtBoxMatricula
            // 
            this.txtBoxMatricula.Location = new System.Drawing.Point(234, 91);
            this.txtBoxMatricula.Name = "txtBoxMatricula";
            this.txtBoxMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMatricula.TabIndex = 7;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(234, 119);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNome.TabIndex = 8;
            // 
            // txtBoxSalario
            // 
            this.txtBoxSalario.Location = new System.Drawing.Point(234, 147);
            this.txtBoxSalario.Name = "txtBoxSalario";
            this.txtBoxSalario.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSalario.TabIndex = 9;
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(234, 175);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumero.TabIndex = 10;
            // 
            // txtBoxData
            // 
            this.txtBoxData.Location = new System.Drawing.Point(234, 203);
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(100, 20);
            this.txtBoxData.TabIndex = 11;
            // 
            // txtBoxDias
            // 
            this.txtBoxDias.Location = new System.Drawing.Point(234, 231);
            this.txtBoxDias.Name = "txtBoxDias";
            this.txtBoxDias.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDias.TabIndex = 12;
            // 
            // gBoxHome
            // 
            this.gBoxHome.Controls.Add(this.rbtnNao);
            this.gBoxHome.Controls.Add(this.rbtnSim);
            this.gBoxHome.Location = new System.Drawing.Point(466, 82);
            this.gBoxHome.Name = "gBoxHome";
            this.gBoxHome.Size = new System.Drawing.Size(200, 100);
            this.gBoxHome.TabIndex = 13;
            this.gBoxHome.TabStop = false;
            this.gBoxHome.Text = "groupBox1";
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(6, 19);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(85, 17);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "radioButton1";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(6, 42);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(85, 17);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "radioButton2";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxHome);
            this.Controls.Add(this.txtBoxDias);
            this.Controls.Add(this.txtBoxData);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.txtBoxSalario);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.txtBoxMatricula);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.gBoxHome.ResumeLayout(false);
            this.gBoxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Button btnInstanciar;
        private System.Windows.Forms.TextBox txtBoxMatricula;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxSalario;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.TextBox txtBoxData;
        private System.Windows.Forms.TextBox txtBoxDias;
        private System.Windows.Forms.GroupBox gBoxHome;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
    }
}