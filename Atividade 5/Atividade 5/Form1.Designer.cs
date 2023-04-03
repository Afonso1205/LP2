namespace Atividade_5
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
            this.CxFilhos = new System.Windows.Forms.NumericUpDown();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalf = new System.Windows.Forms.Label();
            this.lblSall = new System.Windows.Forms.Label();
            this.lblDINSS = new System.Windows.Forms.Label();
            this.lblDIRFF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnDesc = new System.Windows.Forms.Button();
            this.txtBoxTexto = new System.Windows.Forms.TextBox();
            this.txtBoxAINSS = new System.Windows.Forms.TextBox();
            this.txtBoxAIRPF = new System.Windows.Forms.TextBox();
            this.txtBoxSalF = new System.Windows.Forms.TextBox();
            this.txtBoxSalLiq = new System.Windows.Forms.TextBox();
            this.txtBoxDINSS = new System.Windows.Forms.TextBox();
            this.txtBoxDIRPF = new System.Windows.Forms.TextBox();
            this.mskbxSal = new System.Windows.Forms.MaskedTextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.pnl = new System.Windows.Forms.Panel();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CxFilhos)).BeginInit();
            this.gbxSexo.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CxFilhos
            // 
            this.CxFilhos.Location = new System.Drawing.Point(280, 219);
            this.CxFilhos.Margin = new System.Windows.Forms.Padding(4);
            this.CxFilhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CxFilhos.Name = "CxFilhos";
            this.CxFilhos.Size = new System.Drawing.Size(165, 22);
            this.CxFilhos.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(113, 47);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(136, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(113, 134);
            this.lblSal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(84, 16);
            this.lblSal.TabIndex = 2;
            this.lblSal.Text = "Salário Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(113, 222);
            this.lblFilhos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(113, 16);
            this.lblFilhos.TabIndex = 3;
            this.lblFilhos.Text = "Número de Filhos";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(53, 394);
            this.lblINSS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(90, 16);
            this.lblINSS.TabIndex = 4;
            this.lblINSS.Text = "Alíquota INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(53, 481);
            this.lblIRPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(88, 16);
            this.lblIRPF.TabIndex = 5;
            this.lblIRPF.Text = "Alíquota IRFF";
            // 
            // lblSalf
            // 
            this.lblSalf.AutoSize = true;
            this.lblSalf.Location = new System.Drawing.Point(53, 569);
            this.lblSalf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalf.Name = "lblSalf";
            this.lblSalf.Size = new System.Drawing.Size(97, 16);
            this.lblSalf.TabIndex = 6;
            this.lblSalf.Text = "Salário Família";
            // 
            // lblSall
            // 
            this.lblSall.AutoSize = true;
            this.lblSall.Location = new System.Drawing.Point(53, 656);
            this.lblSall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSall.Name = "lblSall";
            this.lblSall.Size = new System.Drawing.Size(97, 16);
            this.lblSall.TabIndex = 7;
            this.lblSall.Text = "Salário Líquido";
            // 
            // lblDINSS
            // 
            this.lblDINSS.AutoSize = true;
            this.lblDINSS.Location = new System.Drawing.Point(560, 394);
            this.lblDINSS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDINSS.Name = "lblDINSS";
            this.lblDINSS.Size = new System.Drawing.Size(99, 16);
            this.lblDINSS.TabIndex = 8;
            this.lblDINSS.Text = "Desconto INSS";
            // 
            // lblDIRFF
            // 
            this.lblDIRFF.AutoSize = true;
            this.lblDIRFF.Location = new System.Drawing.Point(560, 481);
            this.lblDIRFF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDIRFF.Name = "lblDIRFF";
            this.lblDIRFF.Size = new System.Drawing.Size(98, 16);
            this.lblDIRFF.TabIndex = 9;
            this.lblDIRFF.Text = "Desconto IRPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(280, 43);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 22);
            this.txtNome.TabIndex = 10;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(280, 268);
            this.btnDesc.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(197, 28);
            this.btnDesc.TabIndex = 12;
            this.btnDesc.Text = "Verificar Desconto";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.BtnDesc_Click);
            // 
            // txtBoxTexto
            // 
            this.txtBoxTexto.Location = new System.Drawing.Point(117, 325);
            this.txtBoxTexto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTexto.Name = "txtBoxTexto";
            this.txtBoxTexto.ReadOnly = true;
            this.txtBoxTexto.Size = new System.Drawing.Size(549, 22);
            this.txtBoxTexto.TabIndex = 13;
            // 
            // txtBoxAINSS
            // 
            this.txtBoxAINSS.Location = new System.Drawing.Point(199, 390);
            this.txtBoxAINSS.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAINSS.Name = "txtBoxAINSS";
            this.txtBoxAINSS.ReadOnly = true;
            this.txtBoxAINSS.Size = new System.Drawing.Size(277, 22);
            this.txtBoxAINSS.TabIndex = 14;
            // 
            // txtBoxAIRPF
            // 
            this.txtBoxAIRPF.Location = new System.Drawing.Point(199, 478);
            this.txtBoxAIRPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAIRPF.Name = "txtBoxAIRPF";
            this.txtBoxAIRPF.ReadOnly = true;
            this.txtBoxAIRPF.Size = new System.Drawing.Size(277, 22);
            this.txtBoxAIRPF.TabIndex = 15;
            // 
            // txtBoxSalF
            // 
            this.txtBoxSalF.Location = new System.Drawing.Point(199, 565);
            this.txtBoxSalF.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSalF.Name = "txtBoxSalF";
            this.txtBoxSalF.ReadOnly = true;
            this.txtBoxSalF.Size = new System.Drawing.Size(277, 22);
            this.txtBoxSalF.TabIndex = 16;
            // 
            // txtBoxSalLiq
            // 
            this.txtBoxSalLiq.Location = new System.Drawing.Point(199, 652);
            this.txtBoxSalLiq.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSalLiq.Name = "txtBoxSalLiq";
            this.txtBoxSalLiq.ReadOnly = true;
            this.txtBoxSalLiq.Size = new System.Drawing.Size(277, 22);
            this.txtBoxSalLiq.TabIndex = 17;
            // 
            // txtBoxDINSS
            // 
            this.txtBoxDINSS.Location = new System.Drawing.Point(699, 390);
            this.txtBoxDINSS.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDINSS.Name = "txtBoxDINSS";
            this.txtBoxDINSS.ReadOnly = true;
            this.txtBoxDINSS.Size = new System.Drawing.Size(277, 22);
            this.txtBoxDINSS.TabIndex = 18;
            // 
            // txtBoxDIRPF
            // 
            this.txtBoxDIRPF.Location = new System.Drawing.Point(699, 478);
            this.txtBoxDIRPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDIRPF.Name = "txtBoxDIRPF";
            this.txtBoxDIRPF.ReadOnly = true;
            this.txtBoxDIRPF.Size = new System.Drawing.Size(277, 22);
            this.txtBoxDIRPF.TabIndex = 19;
            // 
            // mskbxSal
            // 
            this.mskbxSal.Location = new System.Drawing.Point(280, 130);
            this.mskbxSal.Margin = new System.Windows.Forms.Padding(4);
            this.mskbxSal.Mask = "999990.00";
            this.mskbxSal.Name = "mskbxSal";
            this.mskbxSal.Size = new System.Drawing.Size(164, 22);
            this.mskbxSal.TabIndex = 20;
            this.mskbxSal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskbxSal_KeyPress);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnM);
            this.gbxSexo.Controls.Add(this.rbtnF);
            this.gbxSexo.Location = new System.Drawing.Point(711, 43);
            this.gbxSexo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSexo.Size = new System.Drawing.Size(267, 123);
            this.gbxSexo.TabIndex = 21;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Location = new System.Drawing.Point(48, 74);
            this.rbtnM.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(39, 20);
            this.rbtnM.TabIndex = 1;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "M";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Location = new System.Drawing.Point(48, 34);
            this.rbtnF.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(36, 20);
            this.rbtnF.TabIndex = 0;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "F";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.rbtnSolteiro);
            this.pnl.Controls.Add(this.rbtnCasado);
            this.pnl.Location = new System.Drawing.Point(711, 193);
            this.pnl.Margin = new System.Windows.Forms.Padding(4);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(267, 123);
            this.pnl.TabIndex = 0;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(48, 25);
            this.rbtnCasado.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(76, 20);
            this.rbtnCasado.TabIndex = 2;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(48, 75);
            this.rbtnSolteiro.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(74, 20);
            this.rbtnSolteiro.TabIndex = 3;
            this.rbtnSolteiro.TabStop = true;
            this.rbtnSolteiro.Text = "Solteiro";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 699);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.mskbxSal);
            this.Controls.Add(this.txtBoxDIRPF);
            this.Controls.Add(this.txtBoxDINSS);
            this.Controls.Add(this.txtBoxSalLiq);
            this.Controls.Add(this.txtBoxSalF);
            this.Controls.Add(this.txtBoxAIRPF);
            this.Controls.Add(this.txtBoxAINSS);
            this.Controls.Add(this.txtBoxTexto);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblDIRFF);
            this.Controls.Add(this.lblDINSS);
            this.Controls.Add(this.lblSall);
            this.Controls.Add(this.lblSalf);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.CxFilhos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CxFilhos)).EndInit();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CxFilhos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSalf;
        private System.Windows.Forms.Label lblSall;
        private System.Windows.Forms.Label lblDINSS;
        private System.Windows.Forms.Label lblDIRFF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.TextBox txtBoxTexto;
        private System.Windows.Forms.TextBox txtBoxAINSS;
        private System.Windows.Forms.TextBox txtBoxAIRPF;
        private System.Windows.Forms.TextBox txtBoxSalF;
        private System.Windows.Forms.TextBox txtBoxSalLiq;
        private System.Windows.Forms.TextBox txtBoxDINSS;
        private System.Windows.Forms.TextBox txtBoxDIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSal;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.RadioButton rbtnCasado;
    }
}

