namespace Uppgift_10._3
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
            this.lblTecken = new System.Windows.Forms.Label();
            this.tbxTecken = new System.Windows.Forms.TextBox();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.btnResultat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTecken
            // 
            this.lblTecken.AutoSize = true;
            this.lblTecken.Location = new System.Drawing.Point(12, 19);
            this.lblTecken.Name = "lblTecken";
            this.lblTecken.Size = new System.Drawing.Size(47, 13);
            this.lblTecken.TabIndex = 0;
            this.lblTecken.Text = "Tecken:";
            // 
            // tbxTecken
            // 
            this.tbxTecken.Location = new System.Drawing.Point(83, 16);
            this.tbxTecken.Name = "tbxTecken";
            this.tbxTecken.Size = new System.Drawing.Size(100, 20);
            this.tbxTecken.TabIndex = 1;
            // 
            // tbxResultat
            // 
            this.tbxResultat.Location = new System.Drawing.Point(15, 54);
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.Size = new System.Drawing.Size(168, 20);
            this.tbxResultat.TabIndex = 2;
            // 
            // btnResultat
            // 
            this.btnResultat.Location = new System.Drawing.Point(56, 95);
            this.btnResultat.Name = "btnResultat";
            this.btnResultat.Size = new System.Drawing.Size(80, 23);
            this.btnResultat.TabIndex = 3;
            this.btnResultat.Text = "Visa Resultat";
            this.btnResultat.UseVisualStyleBackColor = true;
            this.btnResultat.Click += new System.EventHandler(this.btnResultat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResultat);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.tbxTecken);
            this.Controls.Add(this.lblTecken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTecken;
        private System.Windows.Forms.TextBox tbxTecken;
        private System.Windows.Forms.TextBox tbxResultat;
        private System.Windows.Forms.Button btnResultat;
    }
}

