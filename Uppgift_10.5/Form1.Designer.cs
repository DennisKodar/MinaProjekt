namespace Uppgift_10._5
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
            this.tbxGemen = new System.Windows.Forms.TextBox();
            this.tbxVersal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVisaVersal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxGemen
            // 
            this.tbxGemen.Location = new System.Drawing.Point(104, 17);
            this.tbxGemen.Name = "tbxGemen";
            this.tbxGemen.Size = new System.Drawing.Size(100, 20);
            this.tbxGemen.TabIndex = 0;
            // 
            // tbxVersal
            // 
            this.tbxVersal.Location = new System.Drawing.Point(104, 61);
            this.tbxVersal.Name = "tbxVersal";
            this.tbxVersal.Size = new System.Drawing.Size(100, 20);
            this.tbxVersal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gemen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Versal:";
            // 
            // btnVisaVersal
            // 
            this.btnVisaVersal.Location = new System.Drawing.Point(62, 108);
            this.btnVisaVersal.Name = "btnVisaVersal";
            this.btnVisaVersal.Size = new System.Drawing.Size(75, 23);
            this.btnVisaVersal.TabIndex = 4;
            this.btnVisaVersal.Text = "Visa versal";
            this.btnVisaVersal.UseVisualStyleBackColor = true;
            this.btnVisaVersal.Click += new System.EventHandler(this.btnVisaVersal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisaVersal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxVersal);
            this.Controls.Add(this.tbxGemen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxGemen;
        private System.Windows.Forms.TextBox tbxVersal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVisaVersal;
    }
}

