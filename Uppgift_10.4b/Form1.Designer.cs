namespace Uppgift_10._4b
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
            this.tbxAntal = new System.Windows.Forms.TextBox();
            this.btnRita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxAntal
            // 
            this.tbxAntal.Location = new System.Drawing.Point(12, 12);
            this.tbxAntal.Name = "tbxAntal";
            this.tbxAntal.Size = new System.Drawing.Size(100, 20);
            this.tbxAntal.TabIndex = 0;
            // 
            // btnRita
            // 
            this.btnRita.Location = new System.Drawing.Point(147, 10);
            this.btnRita.Name = "btnRita";
            this.btnRita.Size = new System.Drawing.Size(75, 23);
            this.btnRita.TabIndex = 1;
            this.btnRita.Text = "Rita";
            this.btnRita.UseVisualStyleBackColor = true;
            this.btnRita.Click += new System.EventHandler(this.btnRita_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRita);
            this.Controls.Add(this.tbxAntal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAntal;
        private System.Windows.Forms.Button btnRita;
    }
}

