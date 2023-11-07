namespace Uppgift_3._2
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
            this.lblKod = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxKod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTecken
            // 
            this.lblTecken.AutoSize = true;
            this.lblTecken.Location = new System.Drawing.Point(398, 240);
            this.lblTecken.Name = "lblTecken";
            this.lblTecken.Size = new System.Drawing.Size(44, 13);
            this.lblTecken.TabIndex = 0;
            this.lblTecken.Text = "Tecken";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(288, 204);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(62, 13);
            this.lblKod.TabIndex = 1;
            this.lblKod.Text = "Teckenkod";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(291, 235);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxKod
            // 
            this.tbxKod.Location = new System.Drawing.Point(366, 201);
            this.tbxKod.Name = "tbxKod";
            this.tbxKod.Size = new System.Drawing.Size(100, 20);
            this.tbxKod.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxKod);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.lblTecken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTecken;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxKod;
    }
}

