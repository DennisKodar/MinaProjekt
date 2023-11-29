namespace Övning_10._5
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
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBytPlats = new System.Windows.Forms.Button();
            this.lblTal1 = new System.Windows.Forms.TextBox();
            this.lblTal2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(87, 12);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(32, 20);
            this.tbxTal1.TabIndex = 0;
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(141, 12);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(32, 20);
            this.tbxTal2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Efter Byte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Innan byte:";
            // 
            // btnBytPlats
            // 
            this.btnBytPlats.Location = new System.Drawing.Point(55, 109);
            this.btnBytPlats.Name = "btnBytPlats";
            this.btnBytPlats.Size = new System.Drawing.Size(75, 23);
            this.btnBytPlats.TabIndex = 4;
            this.btnBytPlats.Text = "Byt plats";
            this.btnBytPlats.UseVisualStyleBackColor = true;
            this.btnBytPlats.Click += new System.EventHandler(this.btnBytPlats_Click);
            // 
            // lblTal1
            // 
            this.lblTal1.Enabled = false;
            this.lblTal1.Location = new System.Drawing.Point(87, 60);
            this.lblTal1.Name = "lblTal1";
            this.lblTal1.Size = new System.Drawing.Size(31, 20);
            this.lblTal1.TabIndex = 5;
            // 
            // lblTal2
            // 
            this.lblTal2.Enabled = false;
            this.lblTal2.Location = new System.Drawing.Point(141, 60);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(32, 20);
            this.lblTal2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 149);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.lblTal1);
            this.Controls.Add(this.btnBytPlats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.tbxTal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTal1;
        private System.Windows.Forms.TextBox tbxTal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBytPlats;
        private System.Windows.Forms.TextBox lblTal1;
        private System.Windows.Forms.TextBox lblTal2;
    }
}

