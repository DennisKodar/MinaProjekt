namespace Övning_10._4
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
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.btnRitaTriangel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(12, 12);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(100, 20);
            this.tbxHöjd.TabIndex = 0;
            // 
            // btnRitaTriangel
            // 
            this.btnRitaTriangel.Location = new System.Drawing.Point(167, 12);
            this.btnRitaTriangel.Name = "btnRitaTriangel";
            this.btnRitaTriangel.Size = new System.Drawing.Size(75, 23);
            this.btnRitaTriangel.TabIndex = 1;
            this.btnRitaTriangel.Text = "button1";
            this.btnRitaTriangel.UseVisualStyleBackColor = true;
            this.btnRitaTriangel.Click += new System.EventHandler(this.btnRitaTriangel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRitaTriangel);
            this.Controls.Add(this.tbxHöjd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.Button btnRitaTriangel;
    }
}

