namespace Uppgift_7._5
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
            this.lblFråga1 = new System.Windows.Forms.Label();
            this.lblAlternativ1 = new System.Windows.Forms.Label();
            this.lblFråga2 = new System.Windows.Forms.Label();
            this.lblAlternativ2 = new System.Windows.Forms.Label();
            this.lblFråga3 = new System.Windows.Forms.Label();
            this.lblAlternativ3 = new System.Windows.Forms.Label();
            this.tbxSvar1 = new System.Windows.Forms.TextBox();
            this.tbxSvar2 = new System.Windows.Forms.TextBox();
            this.tbxSvar3 = new System.Windows.Forms.TextBox();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.btnRätta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFråga1
            // 
            this.lblFråga1.AutoSize = true;
            this.lblFråga1.Location = new System.Drawing.Point(12, 9);
            this.lblFråga1.Name = "lblFråga1";
            this.lblFråga1.Size = new System.Drawing.Size(179, 13);
            this.lblFråga1.TabIndex = 0;
            this.lblFråga1.Text = "1. Vilket variabelnamn är inte tillåtet?";
            // 
            // lblAlternativ1
            // 
            this.lblAlternativ1.AutoSize = true;
            this.lblAlternativ1.Location = new System.Drawing.Point(12, 31);
            this.lblAlternativ1.Name = "lblAlternativ1";
            this.lblAlternativ1.Size = new System.Drawing.Size(125, 13);
            this.lblAlternativ1.TabIndex = 1;
            this.lblAlternativ1.Text = "1. tal1    X. 1tal    2. tal_1";
            // 
            // lblFråga2
            // 
            this.lblFråga2.AutoSize = true;
            this.lblFråga2.Location = new System.Drawing.Point(12, 67);
            this.lblFråga2.Name = "lblFråga2";
            this.lblFråga2.Size = new System.Drawing.Size(89, 13);
            this.lblFråga2.TabIndex = 2;
            this.lblFråga2.Text = "2. Vad blir 14%4?";
            // 
            // lblAlternativ2
            // 
            this.lblAlternativ2.AutoSize = true;
            this.lblAlternativ2.Location = new System.Drawing.Point(12, 90);
            this.lblAlternativ2.Name = "lblAlternativ2";
            this.lblAlternativ2.Size = new System.Drawing.Size(86, 13);
            this.lblAlternativ2.TabIndex = 3;
            this.lblAlternativ2.Text = "1. 3    X. 2    2. 1";
            // 
            // lblFråga3
            // 
            this.lblFråga3.AutoSize = true;
            this.lblFråga3.Location = new System.Drawing.Point(12, 129);
            this.lblFråga3.Name = "lblFråga3";
            this.lblFråga3.Size = new System.Drawing.Size(86, 13);
            this.lblFråga3.TabIndex = 4;
            this.lblFråga3.Text = "3. Vad blir 14/5?";
            // 
            // lblAlternativ3
            // 
            this.lblAlternativ3.AutoSize = true;
            this.lblAlternativ3.Location = new System.Drawing.Point(12, 153);
            this.lblAlternativ3.Name = "lblAlternativ3";
            this.lblAlternativ3.Size = new System.Drawing.Size(86, 13);
            this.lblAlternativ3.TabIndex = 5;
            this.lblAlternativ3.Text = "1. 2    X. 3    2. 4";
            // 
            // tbxSvar1
            // 
            this.tbxSvar1.Location = new System.Drawing.Point(191, 28);
            this.tbxSvar1.Name = "tbxSvar1";
            this.tbxSvar1.Size = new System.Drawing.Size(53, 20);
            this.tbxSvar1.TabIndex = 6;
            // 
            // tbxSvar2
            // 
            this.tbxSvar2.Location = new System.Drawing.Point(191, 87);
            this.tbxSvar2.Name = "tbxSvar2";
            this.tbxSvar2.Size = new System.Drawing.Size(53, 20);
            this.tbxSvar2.TabIndex = 7;
            // 
            // tbxSvar3
            // 
            this.tbxSvar3.Location = new System.Drawing.Point(191, 150);
            this.tbxSvar3.Name = "tbxSvar3";
            this.tbxSvar3.Size = new System.Drawing.Size(53, 20);
            this.tbxSvar3.TabIndex = 8;
            // 
            // tbxResultat
            // 
            this.tbxResultat.Enabled = false;
            this.tbxResultat.Location = new System.Drawing.Point(12, 197);
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.Size = new System.Drawing.Size(232, 20);
            this.tbxResultat.TabIndex = 9;
            // 
            // btnRätta
            // 
            this.btnRätta.Location = new System.Drawing.Point(90, 236);
            this.btnRätta.Name = "btnRätta";
            this.btnRätta.Size = new System.Drawing.Size(75, 23);
            this.btnRätta.TabIndex = 10;
            this.btnRätta.Text = "Rätta";
            this.btnRätta.UseVisualStyleBackColor = true;
            this.btnRätta.Click += new System.EventHandler(this.btnRätta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 279);
            this.Controls.Add(this.btnRätta);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.tbxSvar3);
            this.Controls.Add(this.tbxSvar2);
            this.Controls.Add(this.tbxSvar1);
            this.Controls.Add(this.lblAlternativ3);
            this.Controls.Add(this.lblFråga3);
            this.Controls.Add(this.lblAlternativ2);
            this.Controls.Add(this.lblFråga2);
            this.Controls.Add(this.lblAlternativ1);
            this.Controls.Add(this.lblFråga1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFråga1;
        private System.Windows.Forms.Label lblAlternativ1;
        private System.Windows.Forms.Label lblFråga2;
        private System.Windows.Forms.Label lblAlternativ2;
        private System.Windows.Forms.Label lblFråga3;
        private System.Windows.Forms.Label lblAlternativ3;
        private System.Windows.Forms.TextBox tbxSvar1;
        private System.Windows.Forms.TextBox tbxSvar2;
        private System.Windows.Forms.TextBox tbxSvar3;
        private System.Windows.Forms.TextBox tbxResultat;
        private System.Windows.Forms.Button btnRätta;
    }
}

