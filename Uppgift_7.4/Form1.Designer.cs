namespace Uppgift_7._4
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
            this.lblTal1 = new System.Windows.Forms.Label();
            this.lblRäknesätt = new System.Windows.Forms.Label();
            this.lblTal2 = new System.Windows.Forms.Label();
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.tbxRäknesätt = new System.Windows.Forms.TextBox();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.btnKörSwitch = new System.Windows.Forms.Button();
            this.btnKörIf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTal1
            // 
            this.lblTal1.AutoSize = true;
            this.lblTal1.Location = new System.Drawing.Point(12, 9);
            this.lblTal1.Name = "lblTal1";
            this.lblTal1.Size = new System.Drawing.Size(34, 13);
            this.lblTal1.TabIndex = 0;
            this.lblTal1.Text = "Tal 1:";
            // 
            // lblRäknesätt
            // 
            this.lblRäknesätt.AutoSize = true;
            this.lblRäknesätt.Location = new System.Drawing.Point(12, 38);
            this.lblRäknesätt.Name = "lblRäknesätt";
            this.lblRäknesätt.Size = new System.Drawing.Size(59, 13);
            this.lblRäknesätt.TabIndex = 1;
            this.lblRäknesätt.Text = "Räknesätt:";
            // 
            // lblTal2
            // 
            this.lblTal2.AutoSize = true;
            this.lblTal2.Location = new System.Drawing.Point(12, 74);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(34, 13);
            this.lblTal2.TabIndex = 2;
            this.lblTal2.Text = "Tal 2:";
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(84, 6);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 20);
            this.tbxTal1.TabIndex = 3;
            // 
            // tbxRäknesätt
            // 
            this.tbxRäknesätt.Location = new System.Drawing.Point(84, 38);
            this.tbxRäknesätt.Name = "tbxRäknesätt";
            this.tbxRäknesätt.Size = new System.Drawing.Size(100, 20);
            this.tbxRäknesätt.TabIndex = 4;
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(84, 71);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 20);
            this.tbxTal2.TabIndex = 5;
            // 
            // tbxSvar
            // 
            this.tbxSvar.Enabled = false;
            this.tbxSvar.Location = new System.Drawing.Point(15, 97);
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.Size = new System.Drawing.Size(169, 20);
            this.tbxSvar.TabIndex = 6;
            // 
            // btnKörSwitch
            // 
            this.btnKörSwitch.Location = new System.Drawing.Point(12, 129);
            this.btnKörSwitch.Name = "btnKörSwitch";
            this.btnKörSwitch.Size = new System.Drawing.Size(95, 23);
            this.btnKörSwitch.TabIndex = 7;
            this.btnKörSwitch.Text = "Beräkna (switch)";
            this.btnKörSwitch.UseVisualStyleBackColor = true;
            this.btnKörSwitch.Click += new System.EventHandler(this.btnKörSwitch_Click);
            // 
            // btnKörIf
            // 
            this.btnKörIf.Location = new System.Drawing.Point(116, 129);
            this.btnKörIf.Name = "btnKörIf";
            this.btnKörIf.Size = new System.Drawing.Size(75, 23);
            this.btnKörIf.TabIndex = 8;
            this.btnKörIf.Text = "Beräkna (if)";
            this.btnKörIf.UseVisualStyleBackColor = true;
            this.btnKörIf.Click += new System.EventHandler(this.btnKörIf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 164);
            this.Controls.Add(this.btnKörIf);
            this.Controls.Add(this.btnKörSwitch);
            this.Controls.Add(this.tbxSvar);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.tbxRäknesätt);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.lblRäknesätt);
            this.Controls.Add(this.lblTal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal1;
        private System.Windows.Forms.Label lblRäknesätt;
        private System.Windows.Forms.Label lblTal2;
        private System.Windows.Forms.TextBox tbxTal1;
        private System.Windows.Forms.TextBox tbxRäknesätt;
        private System.Windows.Forms.TextBox tbxTal2;
        private System.Windows.Forms.TextBox tbxSvar;
        private System.Windows.Forms.Button btnKörSwitch;
        private System.Windows.Forms.Button btnKörIf;
    }
}

