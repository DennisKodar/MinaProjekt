namespace Övning_6._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.tbxTal3 = new System.Windows.Forms.TextBox();
            this.btnBeräkna = new System.Windows.Forms.Button();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tal 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tal 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tal 3:";
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(82, 6);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 20);
            this.tbxTal1.TabIndex = 3;
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(82, 44);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 20);
            this.tbxTal2.TabIndex = 4;
            // 
            // tbxTal3
            // 
            this.tbxTal3.Location = new System.Drawing.Point(82, 82);
            this.tbxTal3.Name = "tbxTal3";
            this.tbxTal3.Size = new System.Drawing.Size(100, 20);
            this.tbxTal3.TabIndex = 5;
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.Location = new System.Drawing.Point(15, 122);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(75, 23);
            this.btnBeräkna.TabIndex = 6;
            this.btnBeräkna.Text = "Beräkna";
            this.btnBeräkna.UseVisualStyleBackColor = true;
            this.btnBeräkna.Click += new System.EventHandler(this.btnBeräkna_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(112, 127);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(32, 13);
            this.lblSvar.TabIndex = 7;
            this.lblSvar.Text = "Svar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnBeräkna);
            this.Controls.Add(this.tbxTal3);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTal1;
        private System.Windows.Forms.TextBox tbxTal2;
        private System.Windows.Forms.TextBox tbxTal3;
        private System.Windows.Forms.Button btnBeräkna;
        private System.Windows.Forms.Label lblSvar;
    }
}

