namespace Övning_7._1
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
            this.lblBensin = new System.Windows.Forms.Label();
            this.lblTanka = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxBensin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBensin
            // 
            this.lblBensin.AutoSize = true;
            this.lblBensin.Location = new System.Drawing.Point(14, 29);
            this.lblBensin.Name = "lblBensin";
            this.lblBensin.Size = new System.Drawing.Size(65, 13);
            this.lblBensin.TabIndex = 0;
            this.lblBensin.Text = "Liter Bensin:";
            // 
            // lblTanka
            // 
            this.lblTanka.AutoSize = true;
            this.lblTanka.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTanka.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTanka.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTanka.Location = new System.Drawing.Point(14, 54);
            this.lblTanka.Name = "lblTanka";
            this.lblTanka.Size = new System.Drawing.Size(161, 15);
            this.lblTanka.TabIndex = 1;
            this.lblTanka.Text = "Tanka             Det kostar           ";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(85, 72);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxBensin
            // 
            this.tbxBensin.Location = new System.Drawing.Point(85, 26);
            this.tbxBensin.Name = "tbxBensin";
            this.tbxBensin.Size = new System.Drawing.Size(100, 20);
            this.tbxBensin.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 105);
            this.Controls.Add(this.tbxBensin);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblTanka);
            this.Controls.Add(this.lblBensin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBensin;
        private System.Windows.Forms.Label lblTanka;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxBensin;
    }
}

