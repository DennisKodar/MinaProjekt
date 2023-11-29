namespace Övning_10._7
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
            this.btnKasta = new System.Windows.Forms.Button();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKasta
            // 
            this.btnKasta.Location = new System.Drawing.Point(38, 24);
            this.btnKasta.Name = "btnKasta";
            this.btnKasta.Size = new System.Drawing.Size(100, 23);
            this.btnKasta.TabIndex = 0;
            this.btnKasta.Text = "Kasta tärningarna";
            this.btnKasta.UseVisualStyleBackColor = true;
            this.btnKasta.Click += new System.EventHandler(this.btnKasta_Click);
            // 
            // tbxResultat
            // 
            this.tbxResultat.Location = new System.Drawing.Point(38, 53);
            this.tbxResultat.Multiline = true;
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.ReadOnly = true;
            this.tbxResultat.Size = new System.Drawing.Size(100, 109);
            this.tbxResultat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 213);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.btnKasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKasta;
        private System.Windows.Forms.TextBox tbxResultat;
    }
}

