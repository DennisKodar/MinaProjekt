namespace Övning_10._2
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
            this.tbxRadie = new System.Windows.Forms.TextBox();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.btnMinst = new System.Windows.Forms.Button();
            this.lblMinst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Höjd:";
            // 
            // tbxRadie
            // 
            this.tbxRadie.Location = new System.Drawing.Point(104, 19);
            this.tbxRadie.Name = "tbxRadie";
            this.tbxRadie.Size = new System.Drawing.Size(60, 20);
            this.tbxRadie.TabIndex = 2;
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(104, 58);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(60, 20);
            this.tbxHöjd.TabIndex = 3;
            // 
            // btnMinst
            // 
            this.btnMinst.Location = new System.Drawing.Point(28, 95);
            this.btnMinst.Name = "btnMinst";
            this.btnMinst.Size = new System.Drawing.Size(70, 23);
            this.btnMinst.TabIndex = 4;
            this.btnMinst.Text = "Beräkna";
            this.btnMinst.UseVisualStyleBackColor = true;
            this.btnMinst.Click += new System.EventHandler(this.btnMinst_Click);
            // 
            // lblMinst
            // 
            this.lblMinst.AutoSize = true;
            this.lblMinst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinst.Location = new System.Drawing.Point(104, 100);
            this.lblMinst.Name = "lblMinst";
            this.lblMinst.Size = new System.Drawing.Size(60, 15);
            this.lblMinst.TabIndex = 5;
            this.lblMinst.Text = "                 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMinst);
            this.Controls.Add(this.btnMinst);
            this.Controls.Add(this.tbxHöjd);
            this.Controls.Add(this.tbxRadie);
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
        private System.Windows.Forms.TextBox tbxRadie;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.Button btnMinst;
        private System.Windows.Forms.Label lblMinst;
    }
}

