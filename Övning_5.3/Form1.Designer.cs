namespace Övning_5._3
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
            this.lblPengar = new System.Windows.Forms.Label();
            this.lblPris = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxPengar = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPengar
            // 
            this.lblPengar.AutoSize = true;
            this.lblPengar.Location = new System.Drawing.Point(221, 142);
            this.lblPengar.Name = "lblPengar";
            this.lblPengar.Size = new System.Drawing.Size(66, 13);
            this.lblPengar.TabIndex = 0;
            this.lblPengar.Text = "Mine pengar";
            // 
            // lblPris
            // 
            this.lblPris.AutoSize = true;
            this.lblPris.Location = new System.Drawing.Point(221, 171);
            this.lblPris.Name = "lblPris";
            this.lblPris.Size = new System.Drawing.Size(59, 13);
            this.lblPris.TabIndex = 1;
            this.lblPris.Text = "Varans pris";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(290, 209);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(66, 13);
            this.lblSvar.TabIndex = 2;
            this.lblSvar.Text = "Jag har råd: ";
            // 
            // tbxPengar
            // 
            this.tbxPengar.Location = new System.Drawing.Point(293, 139);
            this.tbxPengar.Name = "tbxPengar";
            this.tbxPengar.Size = new System.Drawing.Size(100, 20);
            this.tbxPengar.TabIndex = 3;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(293, 168);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 20);
            this.tbxPris.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(293, 240);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 5;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.tbxPengar);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblPris);
            this.Controls.Add(this.lblPengar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPengar;
        private System.Windows.Forms.Label lblPris;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxPengar;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.Button btnKör;
    }
}

