namespace PMenu
{
    partial class frmExercicio4
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
            this.rtxtboxTexto = new System.Windows.Forms.RichTextBox();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnCarac = new System.Windows.Forms.Button();
            this.txtboxRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtxtboxTexto
            // 
            this.rtxtboxTexto.Location = new System.Drawing.Point(420, 91);
            this.rtxtboxTexto.Name = "rtxtboxTexto";
            this.rtxtboxTexto.Size = new System.Drawing.Size(100, 96);
            this.rtxtboxTexto.TabIndex = 0;
            this.rtxtboxTexto.Text = "";
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(282, 255);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 23);
            this.btnNum.TabIndex = 1;
            this.btnNum.Text = "Números";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.Location = new System.Drawing.Point(434, 255);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(75, 23);
            this.btnSpace.TabIndex = 2;
            this.btnSpace.Text = "Espaços";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // btnCarac
            // 
            this.btnCarac.Location = new System.Drawing.Point(586, 255);
            this.btnCarac.Name = "btnCarac";
            this.btnCarac.Size = new System.Drawing.Size(75, 23);
            this.btnCarac.TabIndex = 3;
            this.btnCarac.Text = "Caracter";
            this.btnCarac.UseVisualStyleBackColor = true;
            this.btnCarac.Click += new System.EventHandler(this.btnCarac_Click);
            // 
            // txtboxRes
            // 
            this.txtboxRes.Location = new System.Drawing.Point(367, 306);
            this.txtboxRes.Name = "txtboxRes";
            this.txtboxRes.ReadOnly = true;
            this.txtboxRes.Size = new System.Drawing.Size(220, 22);
            this.txtboxRes.TabIndex = 4;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtboxRes);
            this.Controls.Add(this.btnCarac);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.rtxtboxTexto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtboxTexto;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button btnCarac;
        private System.Windows.Forms.TextBox txtboxRes;
    }
}