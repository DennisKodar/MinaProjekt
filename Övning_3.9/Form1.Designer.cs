namespace Övning_3._9
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
            this.tbxX = new System.Windows.Forms.TextBox();
            this.tbxY = new System.Windows.Forms.TextBox();
            this.btnFlytta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(593, 342);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(49, 20);
            this.tbxX.TabIndex = 2;
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(648, 342);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(49, 20);
            this.tbxY.TabIndex = 3;
            // 
            // btnFlytta
            // 
            this.btnFlytta.Location = new System.Drawing.Point(605, 393);
            this.btnFlytta.Name = "btnFlytta";
            this.btnFlytta.Size = new System.Drawing.Size(75, 23);
            this.btnFlytta.TabIndex = 4;
            this.btnFlytta.Text = "Flytta";
            this.btnFlytta.UseVisualStyleBackColor = true;
            this.btnFlytta.Click += new System.EventHandler(this.btnFlytta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 876);
            this.Controls.Add(this.btnFlytta);
            this.Controls.Add(this.tbxY);
            this.Controls.Add(this.tbxX);
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
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.TextBox tbxY;
        private System.Windows.Forms.Button btnFlytta;
    }
}

