namespace Övning_7._6
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
            this.lblNamn1 = new System.Windows.Forms.Label();
            this.lblNamn2 = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxNamn2 = new System.Windows.Forms.TextBox();
            this.tbxNamn1 = new System.Windows.Forms.TextBox();
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNamn1
            // 
            this.lblNamn1.AutoSize = true;
            this.lblNamn1.Location = new System.Drawing.Point(12, 9);
            this.lblNamn1.Name = "lblNamn1";
            this.lblNamn1.Size = new System.Drawing.Size(44, 13);
            this.lblNamn1.TabIndex = 0;
            this.lblNamn1.Text = "Namn1:";
            // 
            // lblNamn2
            // 
            this.lblNamn2.AutoSize = true;
            this.lblNamn2.Location = new System.Drawing.Point(12, 42);
            this.lblNamn2.Name = "lblNamn2";
            this.lblNamn2.Size = new System.Drawing.Size(44, 13);
            this.lblNamn2.TabIndex = 1;
            this.lblNamn2.Text = "Namn2:";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(24, 100);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(96, 23);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Jämför namnen";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxNamn2
            // 
            this.tbxNamn2.Location = new System.Drawing.Point(62, 39);
            this.tbxNamn2.Name = "tbxNamn2";
            this.tbxNamn2.Size = new System.Drawing.Size(79, 20);
            this.tbxNamn2.TabIndex = 3;
            // 
            // tbxNamn1
            // 
            this.tbxNamn1.Location = new System.Drawing.Point(62, 6);
            this.tbxNamn1.Name = "tbxNamn1";
            this.tbxNamn1.Size = new System.Drawing.Size(79, 20);
            this.tbxNamn1.TabIndex = 4;
            // 
            // tbxSvar
            // 
            this.tbxSvar.Enabled = false;
            this.tbxSvar.Location = new System.Drawing.Point(15, 74);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.Size = new System.Drawing.Size(126, 20);
            this.tbxSvar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 140);
            this.Controls.Add(this.tbxSvar);
            this.Controls.Add(this.tbxNamn1);
            this.Controls.Add(this.tbxNamn2);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblNamn2);
            this.Controls.Add(this.lblNamn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamn1;
        private System.Windows.Forms.Label lblNamn2;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxNamn2;
        private System.Windows.Forms.TextBox tbxNamn1;
        private System.Windows.Forms.TextBox tbxSvar;
    }
}

