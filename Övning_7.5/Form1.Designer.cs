namespace Övning_7._5
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
            this.tbxDag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNr = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxDag
            // 
            this.tbxDag.Enabled = false;
            this.tbxDag.Location = new System.Drawing.Point(15, 44);
            this.tbxDag.Name = "tbxDag";
            this.tbxDag.Size = new System.Drawing.Size(124, 20);
            this.tbxDag.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veckodagens nr:";
            // 
            // tbxNr
            // 
            this.tbxNr.Location = new System.Drawing.Point(106, 18);
            this.tbxNr.Name = "tbxNr";
            this.tbxNr.Size = new System.Drawing.Size(33, 20);
            this.tbxNr.TabIndex = 2;
            this.tbxNr.TextChanged += new System.EventHandler(this.tbxNr_TextChanged);
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(30, 70);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(88, 23);
            this.btnKör.TabIndex = 3;
            this.btnKör.Text = "Visa Veckodag";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 111);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.tbxNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNr;
        private System.Windows.Forms.Button btnKör;
    }
}

