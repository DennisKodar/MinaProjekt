namespace Övning_3._7
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
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTecken
            // 
            this.lblTecken.AutoSize = true;
            this.lblTecken.Location = new System.Drawing.Point(239, 156);
            this.lblTecken.Name = "lblTecken";
            this.lblTecken.Size = new System.Drawing.Size(44, 13);
            this.lblTecken.TabIndex = 0;
            this.lblTecken.Text = "Tecken";
            // 
            // tbxTecken
            // 
            this.tbxTecken.Location = new System.Drawing.Point(311, 153);
            this.tbxTecken.Name = "tbxTecken";
            this.tbxTecken.Size = new System.Drawing.Size(100, 20);
            this.tbxTecken.TabIndex = 1;
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(270, 199);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 13);
            this.lblSvar.TabIndex = 2;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(286, 232);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 3;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblSvar);
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
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnKör;
    }
}

