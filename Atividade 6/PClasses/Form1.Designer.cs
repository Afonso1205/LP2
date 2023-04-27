namespace PClasses
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
            this.Mensalista = new System.Windows.Forms.Button();
            this.Horista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mensalista
            // 
            this.Mensalista.Location = new System.Drawing.Point(165, 218);
            this.Mensalista.Name = "Mensalista";
            this.Mensalista.Size = new System.Drawing.Size(75, 23);
            this.Mensalista.TabIndex = 0;
            this.Mensalista.Text = "Mensalista";
            this.Mensalista.UseVisualStyleBackColor = true;
            this.Mensalista.Click += new System.EventHandler(this.Mensalista_Click);
            // 
            // Horista
            // 
            this.Horista.Location = new System.Drawing.Point(451, 218);
            this.Horista.Name = "Horista";
            this.Horista.Size = new System.Drawing.Size(75, 23);
            this.Horista.TabIndex = 1;
            this.Horista.Text = "Horista";
            this.Horista.UseVisualStyleBackColor = true;
            this.Horista.Click += new System.EventHandler(this.Horista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Horista);
            this.Controls.Add(this.Mensalista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mensalista;
        private System.Windows.Forms.Button Horista;
    }
}

