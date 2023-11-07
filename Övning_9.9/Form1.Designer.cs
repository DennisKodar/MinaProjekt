namespace Övning_9._9
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
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSkjut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(87, 39);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 20);
            this.tbx1.TabIndex = 0;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(87, 65);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 20);
            this.tbx2.TabIndex = 1;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(87, 91);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(100, 20);
            this.tbx3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sträng";
            // 
            // btnSkjut
            // 
            this.btnSkjut.Location = new System.Drawing.Point(100, 128);
            this.btnSkjut.Name = "btnSkjut";
            this.btnSkjut.Size = new System.Drawing.Size(75, 23);
            this.btnSkjut.TabIndex = 4;
            this.btnSkjut.Text = "Förskjut";
            this.btnSkjut.UseVisualStyleBackColor = true;
            this.btnSkjut.Click += new System.EventHandler(this.btnSkjut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 162);
            this.Controls.Add(this.btnSkjut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSkjut;
    }
}

