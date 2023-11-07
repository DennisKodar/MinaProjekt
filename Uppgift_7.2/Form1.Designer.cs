namespace Uppgift_7._2
{
    partial class Golf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Golf));
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.tbxLängd = new System.Windows.Forms.TextBox();
            this.lblLängd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(59, 75);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 7;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxSvar
            // 
            this.tbxSvar.Enabled = false;
            this.tbxSvar.Location = new System.Drawing.Point(14, 35);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.Size = new System.Drawing.Size(177, 20);
            this.tbxSvar.TabIndex = 6;
            // 
            // tbxLängd
            // 
            this.tbxLängd.Location = new System.Drawing.Point(91, 9);
            this.tbxLängd.Name = "tbxLängd";
            this.tbxLängd.Size = new System.Drawing.Size(100, 20);
            this.tbxLängd.TabIndex = 5;
            // 
            // lblLängd
            // 
            this.lblLängd.AutoSize = true;
            this.lblLängd.Location = new System.Drawing.Point(11, 12);
            this.lblLängd.Name = "lblLängd";
            this.lblLängd.Size = new System.Drawing.Size(74, 13);
            this.lblLängd.TabIndex = 4;
            this.lblLängd.Text = "Slagets längd:";
            // 
            // Golf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 114);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxSvar);
            this.Controls.Add(this.tbxLängd);
            this.Controls.Add(this.lblLängd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Golf";
            this.Text = "Golf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxSvar;
        private System.Windows.Forms.TextBox tbxLängd;
        private System.Windows.Forms.Label lblLängd;
    }
}

