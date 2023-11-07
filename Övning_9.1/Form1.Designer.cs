namespace Övning_9._1
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
            this.lblSlutvärde = new System.Windows.Forms.Label();
            this.tbxSlutvärde = new System.Windows.Forms.TextBox();
            this.tbxUtdata = new System.Windows.Forms.TextBox();
            this.btnStarta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSlutvärde
            // 
            this.lblSlutvärde.AutoSize = true;
            this.lblSlutvärde.Location = new System.Drawing.Point(92, 15);
            this.lblSlutvärde.Name = "lblSlutvärde";
            this.lblSlutvärde.Size = new System.Drawing.Size(52, 13);
            this.lblSlutvärde.TabIndex = 0;
            this.lblSlutvärde.Text = "Slutvärde";
            // 
            // tbxSlutvärde
            // 
            this.tbxSlutvärde.Location = new System.Drawing.Point(150, 12);
            this.tbxSlutvärde.Name = "tbxSlutvärde";
            this.tbxSlutvärde.Size = new System.Drawing.Size(100, 20);
            this.tbxSlutvärde.TabIndex = 1;
            // 
            // tbxUtdata
            // 
            this.tbxUtdata.Location = new System.Drawing.Point(12, 49);
            this.tbxUtdata.Multiline = true;
            this.tbxUtdata.Name = "tbxUtdata";
            this.tbxUtdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxUtdata.Size = new System.Drawing.Size(238, 79);
            this.tbxUtdata.TabIndex = 2;
            // 
            // btnStarta
            // 
            this.btnStarta.Location = new System.Drawing.Point(84, 134);
            this.btnStarta.Name = "btnStarta";
            this.btnStarta.Size = new System.Drawing.Size(75, 23);
            this.btnStarta.TabIndex = 3;
            this.btnStarta.Text = "Starta";
            this.btnStarta.UseVisualStyleBackColor = true;
            this.btnStarta.Click += new System.EventHandler(this.btnStarta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 159);
            this.Controls.Add(this.btnStarta);
            this.Controls.Add(this.tbxUtdata);
            this.Controls.Add(this.tbxSlutvärde);
            this.Controls.Add(this.lblSlutvärde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlutvärde;
        private System.Windows.Forms.TextBox tbxSlutvärde;
        private System.Windows.Forms.TextBox tbxUtdata;
        private System.Windows.Forms.Button btnStarta;
    }
}

