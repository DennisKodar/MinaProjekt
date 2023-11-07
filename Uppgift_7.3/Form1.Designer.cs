namespace Uppgift_7._3
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
            this.lblLängd = new System.Windows.Forms.Label();
            this.lblVind = new System.Windows.Forms.Label();
            this.tbxLängd = new System.Windows.Forms.TextBox();
            this.tbxVind = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLängd
            // 
            this.lblLängd.AutoSize = true;
            this.lblLängd.Location = new System.Drawing.Point(21, 13);
            this.lblLängd.Name = "lblLängd";
            this.lblLängd.Size = new System.Drawing.Size(57, 13);
            this.lblLängd.TabIndex = 0;
            this.lblLängd.Text = "Längd (m):";
            // 
            // lblVind
            // 
            this.lblVind.AutoSize = true;
            this.lblVind.Location = new System.Drawing.Point(21, 43);
            this.lblVind.Name = "lblVind";
            this.lblVind.Size = new System.Drawing.Size(86, 13);
            this.lblVind.TabIndex = 1;
            this.lblVind.Text = "Vindstyrka (m/s):";
            // 
            // tbxLängd
            // 
            this.tbxLängd.Location = new System.Drawing.Point(122, 10);
            this.tbxLängd.Name = "tbxLängd";
            this.tbxLängd.Size = new System.Drawing.Size(100, 20);
            this.tbxLängd.TabIndex = 2;
            // 
            // tbxVind
            // 
            this.tbxVind.Location = new System.Drawing.Point(122, 40);
            this.tbxVind.Name = "tbxVind";
            this.tbxVind.Size = new System.Drawing.Size(100, 20);
            this.tbxVind.TabIndex = 3;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(83, 97);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 4;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxSvar
            // 
            this.tbxSvar.Enabled = false;
            this.tbxSvar.Location = new System.Drawing.Point(24, 71);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.Size = new System.Drawing.Size(198, 20);
            this.tbxSvar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 132);
            this.Controls.Add(this.tbxSvar);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxVind);
            this.Controls.Add(this.tbxLängd);
            this.Controls.Add(this.lblVind);
            this.Controls.Add(this.lblLängd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLängd;
        private System.Windows.Forms.Label lblVind;
        private System.Windows.Forms.TextBox tbxLängd;
        private System.Windows.Forms.TextBox tbxVind;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxSvar;
    }
}

