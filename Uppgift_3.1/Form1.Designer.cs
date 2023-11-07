namespace Uppgift_3._1
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
            this.lblBas = new System.Windows.Forms.Label();
            this.lblHöjd = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.tbxBas = new System.Windows.Forms.TextBox();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBas
            // 
            this.lblBas.AutoSize = true;
            this.lblBas.Location = new System.Drawing.Point(275, 158);
            this.lblBas.Name = "lblBas";
            this.lblBas.Size = new System.Drawing.Size(25, 13);
            this.lblBas.TabIndex = 0;
            this.lblBas.Text = "Bas";
            // 
            // lblHöjd
            // 
            this.lblHöjd.AutoSize = true;
            this.lblHöjd.Location = new System.Drawing.Point(275, 205);
            this.lblHöjd.Name = "lblHöjd";
            this.lblHöjd.Size = new System.Drawing.Size(29, 13);
            this.lblHöjd.TabIndex = 1;
            this.lblHöjd.Text = "Höjd";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(321, 247);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(29, 13);
            this.lblSvar.TabIndex = 2;
            this.lblSvar.Text = "Area";
            // 
            // tbxBas
            // 
            this.tbxBas.Location = new System.Drawing.Point(339, 155);
            this.tbxBas.Name = "tbxBas";
            this.tbxBas.Size = new System.Drawing.Size(100, 20);
            this.tbxBas.TabIndex = 3;
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(339, 202);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(100, 20);
            this.tbxHöjd.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(301, 280);
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
            this.Controls.Add(this.tbxHöjd);
            this.Controls.Add(this.tbxBas);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblHöjd);
            this.Controls.Add(this.lblBas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBas;
        private System.Windows.Forms.Label lblHöjd;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.TextBox tbxBas;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.Button btnKör;
    }
}

