namespace Uppgift_8._3
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
            this.gbxStenSaxPåse = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDatornsVal = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.gbxMinaResultat = new System.Windows.Forms.GroupBox();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.btnSpela = new System.Windows.Forms.Button();
            this.pbxPåse = new System.Windows.Forms.PictureBox();
            this.pbxSax = new System.Windows.Forms.PictureBox();
            this.pbxSten = new System.Windows.Forms.PictureBox();
            this.gbxStenSaxPåse.SuspendLayout();
            this.gbxMinaResultat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPåse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStenSaxPåse
            // 
            this.gbxStenSaxPåse.Controls.Add(this.pbxPåse);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSax);
            this.gbxStenSaxPåse.Controls.Add(this.pbxSten);
            this.gbxStenSaxPåse.Controls.Add(this.label4);
            this.gbxStenSaxPåse.Controls.Add(this.label3);
            this.gbxStenSaxPåse.Controls.Add(this.lblDatornsVal);
            this.gbxStenSaxPåse.Controls.Add(this.lblResultat);
            this.gbxStenSaxPåse.Enabled = false;
            this.gbxStenSaxPåse.Location = new System.Drawing.Point(12, 12);
            this.gbxStenSaxPåse.Name = "gbxStenSaxPåse";
            this.gbxStenSaxPåse.Size = new System.Drawing.Size(270, 192);
            this.gbxStenSaxPåse.TabIndex = 0;
            this.gbxStenSaxPåse.TabStop = false;
            this.gbxStenSaxPåse.Text = "Sten, sax eller påse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Välj sten, sax eller påse genom att klicka på en bild";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datorn valde:";
            // 
            // lblDatornsVal
            // 
            this.lblDatornsVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsVal.Enabled = false;
            this.lblDatornsVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatornsVal.Location = new System.Drawing.Point(83, 114);
            this.lblDatornsVal.Name = "lblDatornsVal";
            this.lblDatornsVal.Size = new System.Drawing.Size(68, 24);
            this.lblDatornsVal.TabIndex = 1;
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Enabled = false;
            this.lblResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultat.Location = new System.Drawing.Point(9, 151);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(244, 23);
            this.lblResultat.TabIndex = 0;
            // 
            // gbxMinaResultat
            // 
            this.gbxMinaResultat.Controls.Add(this.tbxMinaResultat);
            this.gbxMinaResultat.Location = new System.Drawing.Point(288, 76);
            this.gbxMinaResultat.Name = "gbxMinaResultat";
            this.gbxMinaResultat.Size = new System.Drawing.Size(146, 128);
            this.gbxMinaResultat.TabIndex = 1;
            this.gbxMinaResultat.TabStop = false;
            this.gbxMinaResultat.Text = "Mina Resultat";
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(6, 19);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.Size = new System.Drawing.Size(134, 103);
            this.tbxMinaResultat.TabIndex = 0;
            // 
            // btnSpela
            // 
            this.btnSpela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpela.Location = new System.Drawing.Point(327, 28);
            this.btnSpela.Name = "btnSpela";
            this.btnSpela.Size = new System.Drawing.Size(75, 23);
            this.btnSpela.TabIndex = 2;
            this.btnSpela.Text = "Spela";
            this.btnSpela.UseVisualStyleBackColor = true;
            this.btnSpela.Click += new System.EventHandler(this.btnSpela_Click);
            // 
            // pbxPåse
            // 
            this.pbxPåse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPåse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPåse.Image = global::Uppgift_8._3.Properties.Resources.påse;
            this.pbxPåse.Location = new System.Drawing.Point(183, 41);
            this.pbxPåse.Name = "pbxPåse";
            this.pbxPåse.Size = new System.Drawing.Size(70, 70);
            this.pbxPåse.TabIndex = 6;
            this.pbxPåse.TabStop = false;
            this.pbxPåse.Click += new System.EventHandler(this.pbxPåse_Click);
            // 
            // pbxSax
            // 
            this.pbxSax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxSax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSax.Image = global::Uppgift_8._3.Properties.Resources.sax;
            this.pbxSax.Location = new System.Drawing.Point(97, 41);
            this.pbxSax.Name = "pbxSax";
            this.pbxSax.Size = new System.Drawing.Size(70, 70);
            this.pbxSax.TabIndex = 5;
            this.pbxSax.TabStop = false;
            this.pbxSax.Click += new System.EventHandler(this.pbxSax_Click);
            // 
            // pbxSten
            // 
            this.pbxSten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxSten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSten.Image = global::Uppgift_8._3.Properties.Resources.sten;
            this.pbxSten.Location = new System.Drawing.Point(9, 41);
            this.pbxSten.Name = "pbxSten";
            this.pbxSten.Size = new System.Drawing.Size(70, 70);
            this.pbxSten.TabIndex = 4;
            this.pbxSten.TabStop = false;
            this.pbxSten.Click += new System.EventHandler(this.pbxSten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 223);
            this.Controls.Add(this.btnSpela);
            this.Controls.Add(this.gbxMinaResultat);
            this.Controls.Add(this.gbxStenSaxPåse);
            this.Name = "Form1";
            this.Text = "X";
            this.gbxStenSaxPåse.ResumeLayout(false);
            this.gbxStenSaxPåse.PerformLayout();
            this.gbxMinaResultat.ResumeLayout(false);
            this.gbxMinaResultat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPåse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStenSaxPåse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDatornsVal;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.GroupBox gbxMinaResultat;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.PictureBox pbxPåse;
        private System.Windows.Forms.PictureBox pbxSax;
        private System.Windows.Forms.PictureBox pbxSten;
        private System.Windows.Forms.Button btnSpela;
    }
}

