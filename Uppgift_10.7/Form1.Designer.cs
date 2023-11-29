namespace Uppgift_10._7
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
            this.tbxExponent = new System.Windows.Forms.TextBox();
            this.tbxBas = new System.Windows.Forms.TextBox();
            this.tbxUtdata = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exponent:";
            // 
            // tbxExponent
            // 
            this.tbxExponent.Location = new System.Drawing.Point(142, 16);
            this.tbxExponent.Name = "tbxExponent";
            this.tbxExponent.Size = new System.Drawing.Size(29, 20);
            this.tbxExponent.TabIndex = 2;
            // 
            // tbxBas
            // 
            this.tbxBas.Location = new System.Drawing.Point(46, 16);
            this.tbxBas.Name = "tbxBas";
            this.tbxBas.Size = new System.Drawing.Size(29, 20);
            this.tbxBas.TabIndex = 3;
            // 
            // tbxUtdata
            // 
            this.tbxUtdata.Location = new System.Drawing.Point(15, 53);
            this.tbxUtdata.Name = "tbxUtdata";
            this.tbxUtdata.Size = new System.Drawing.Size(156, 20);
            this.tbxUtdata.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Beräkna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxUtdata);
            this.Controls.Add(this.tbxBas);
            this.Controls.Add(this.tbxExponent);
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
        private System.Windows.Forms.TextBox tbxExponent;
        private System.Windows.Forms.TextBox tbxBas;
        private System.Windows.Forms.TextBox tbxUtdata;
        private System.Windows.Forms.Button button1;
    }
}

