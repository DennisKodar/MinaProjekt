namespace Övning_9._2
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
            this.btnStarta = new System.Windows.Forms.Button();
            this.tbxUtdata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStarta
            // 
            this.btnStarta.Location = new System.Drawing.Point(86, 15);
            this.btnStarta.Name = "btnStarta";
            this.btnStarta.Size = new System.Drawing.Size(75, 23);
            this.btnStarta.TabIndex = 5;
            this.btnStarta.Text = "Starta";
            this.btnStarta.UseVisualStyleBackColor = true;
            this.btnStarta.Click += new System.EventHandler(this.btnStarta_Click);
            // 
            // tbxUtdata
            // 
            this.tbxUtdata.Location = new System.Drawing.Point(12, 44);
            this.tbxUtdata.Multiline = true;
            this.tbxUtdata.Name = "tbxUtdata";
            this.tbxUtdata.Size = new System.Drawing.Size(238, 79);
            this.tbxUtdata.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 151);
            this.Controls.Add(this.btnStarta);
            this.Controls.Add(this.tbxUtdata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStarta;
        private System.Windows.Forms.TextBox tbxUtdata;
    }
}

