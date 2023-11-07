namespace Övning_9._5
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
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.tbxSlut = new System.Windows.Forms.TextBox();
            this.tbxSteg = new System.Windows.Forms.TextBox();
            this.tbxUtdata = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Steg";
            // 
            // tbxStart
            // 
            this.tbxStart.Location = new System.Drawing.Point(15, 25);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(67, 20);
            this.tbxStart.TabIndex = 3;
            // 
            // tbxSlut
            // 
            this.tbxSlut.Location = new System.Drawing.Point(107, 25);
            this.tbxSlut.Name = "tbxSlut";
            this.tbxSlut.Size = new System.Drawing.Size(69, 20);
            this.tbxSlut.TabIndex = 4;
            // 
            // tbxSteg
            // 
            this.tbxSteg.Location = new System.Drawing.Point(199, 25);
            this.tbxSteg.Name = "tbxSteg";
            this.tbxSteg.Size = new System.Drawing.Size(64, 20);
            this.tbxSteg.TabIndex = 5;
            // 
            // tbxUtdata
            // 
            this.tbxUtdata.Location = new System.Drawing.Point(15, 61);
            this.tbxUtdata.Multiline = true;
            this.tbxUtdata.Name = "tbxUtdata";
            this.tbxUtdata.Size = new System.Drawing.Size(248, 69);
            this.tbxUtdata.TabIndex = 6;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(101, 136);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 7;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 172);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxUtdata);
            this.Controls.Add(this.tbxSteg);
            this.Controls.Add(this.tbxSlut);
            this.Controls.Add(this.tbxStart);
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
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.TextBox tbxSlut;
        private System.Windows.Forms.TextBox tbxSteg;
        private System.Windows.Forms.TextBox tbxUtdata;
        private System.Windows.Forms.Button btnKör;
    }
}

