namespace Övning_8._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxBild = new System.Windows.Forms.PictureBox();
            this.gbxSpeldata = new System.Windows.Forms.GroupBox();
            this.lblStörstTalet = new System.Windows.Forms.Label();
            this.lbxStörstaTalet = new System.Windows.Forms.ListBox();
            this.gbxSpelet = new System.Windows.Forms.GroupBox();
            this.btnGissa = new System.Windows.Forms.Button();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.lblMinaResultat = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblDatornsTal = new System.Windows.Forms.Label();
            this.lblGissa = new System.Windows.Forms.Label();
            this.lblDator = new System.Windows.Forms.Label();
            this.btnStartaSpelet = new System.Windows.Forms.Button();
            this.btnSpelaIgen = new System.Windows.Forms.Button();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBild)).BeginInit();
            this.gbxSpeldata.SuspendLayout();
            this.gbxSpelet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxBild
            // 
            this.pbxBild.Image = ((System.Drawing.Image)(resources.GetObject("pbxBild.Image")));
            this.pbxBild.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxBild.InitialImage")));
            this.pbxBild.Location = new System.Drawing.Point(12, 12);
            this.pbxBild.Name = "pbxBild";
            this.pbxBild.Size = new System.Drawing.Size(340, 40);
            this.pbxBild.TabIndex = 0;
            this.pbxBild.TabStop = false;
            // 
            // gbxSpeldata
            // 
            this.gbxSpeldata.Controls.Add(this.lblStörstTalet);
            this.gbxSpeldata.Controls.Add(this.lbxStörstaTalet);
            this.gbxSpeldata.Location = new System.Drawing.Point(12, 58);
            this.gbxSpeldata.Name = "gbxSpeldata";
            this.gbxSpeldata.Size = new System.Drawing.Size(230, 78);
            this.gbxSpeldata.TabIndex = 1;
            this.gbxSpeldata.TabStop = false;
            this.gbxSpeldata.Text = "Speldata";
            // 
            // lblStörstTalet
            // 
            this.lblStörstTalet.AutoSize = true;
            this.lblStörstTalet.Location = new System.Drawing.Point(9, 35);
            this.lblStörstTalet.Name = "lblStörstTalet";
            this.lblStörstTalet.Size = new System.Drawing.Size(66, 13);
            this.lblStörstTalet.TabIndex = 3;
            this.lblStörstTalet.Text = "Största talet:";
            // 
            // lbxStörstaTalet
            // 
            this.lbxStörstaTalet.FormattingEnabled = true;
            this.lbxStörstaTalet.Location = new System.Drawing.Point(81, 19);
            this.lbxStörstaTalet.Name = "lbxStörstaTalet";
            this.lbxStörstaTalet.Size = new System.Drawing.Size(102, 43);
            this.lbxStörstaTalet.TabIndex = 2;
            // 
            // gbxSpelet
            // 
            this.gbxSpelet.Controls.Add(this.tbxGissa);
            this.gbxSpelet.Controls.Add(this.btnGissa);
            this.gbxSpelet.Controls.Add(this.tbxMinaResultat);
            this.gbxSpelet.Controls.Add(this.lblMinaResultat);
            this.gbxSpelet.Controls.Add(this.lblResultat);
            this.gbxSpelet.Controls.Add(this.lblDatornsTal);
            this.gbxSpelet.Controls.Add(this.lblGissa);
            this.gbxSpelet.Controls.Add(this.lblDator);
            this.gbxSpelet.Location = new System.Drawing.Point(12, 149);
            this.gbxSpelet.Name = "gbxSpelet";
            this.gbxSpelet.Size = new System.Drawing.Size(340, 100);
            this.gbxSpelet.TabIndex = 2;
            this.gbxSpelet.TabStop = false;
            this.gbxSpelet.Text = "Spelet";
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(141, 38);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(75, 23);
            this.btnGissa.TabIndex = 6;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Location = new System.Drawing.Point(236, 32);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.Size = new System.Drawing.Size(80, 62);
            this.tbxMinaResultat.TabIndex = 5;
            // 
            // lblMinaResultat
            // 
            this.lblMinaResultat.AutoSize = true;
            this.lblMinaResultat.Location = new System.Drawing.Point(244, 12);
            this.lblMinaResultat.Name = "lblMinaResultat";
            this.lblMinaResultat.Size = new System.Drawing.Size(67, 13);
            this.lblMinaResultat.TabIndex = 4;
            this.lblMinaResultat.Text = "Mina resultat";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultat.Location = new System.Drawing.Point(9, 79);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(37, 15);
            this.lblResultat.TabIndex = 3;
            this.lblResultat.Text = "label4";
            // 
            // lblDatornsTal
            // 
            this.lblDatornsTal.AutoSize = true;
            this.lblDatornsTal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDatornsTal.Location = new System.Drawing.Point(73, 20);
            this.lblDatornsTal.Name = "lblDatornsTal";
            this.lblDatornsTal.Size = new System.Drawing.Size(37, 15);
            this.lblDatornsTal.TabIndex = 2;
            this.lblDatornsTal.Text = "label3";
            // 
            // lblGissa
            // 
            this.lblGissa.AutoSize = true;
            this.lblGissa.Location = new System.Drawing.Point(6, 43);
            this.lblGissa.Name = "lblGissa";
            this.lblGissa.Size = new System.Drawing.Size(65, 13);
            this.lblGissa.TabIndex = 1;
            this.lblGissa.Text = "Gissa ett tal:";
            // 
            // lblDator
            // 
            this.lblDator.AutoSize = true;
            this.lblDator.Location = new System.Drawing.Point(6, 19);
            this.lblDator.Name = "lblDator";
            this.lblDator.Size = new System.Drawing.Size(61, 13);
            this.lblDator.TabIndex = 0;
            this.lblDator.Text = "Datorns tal:";
            // 
            // btnStartaSpelet
            // 
            this.btnStartaSpelet.Location = new System.Drawing.Point(267, 76);
            this.btnStartaSpelet.Name = "btnStartaSpelet";
            this.btnStartaSpelet.Size = new System.Drawing.Size(75, 23);
            this.btnStartaSpelet.TabIndex = 3;
            this.btnStartaSpelet.Text = "Starta spelet";
            this.btnStartaSpelet.UseVisualStyleBackColor = true;
            this.btnStartaSpelet.Click += new System.EventHandler(this.btnStartaSpelet_Click);
            // 
            // btnSpelaIgen
            // 
            this.btnSpelaIgen.Location = new System.Drawing.Point(267, 105);
            this.btnSpelaIgen.Name = "btnSpelaIgen";
            this.btnSpelaIgen.Size = new System.Drawing.Size(75, 23);
            this.btnSpelaIgen.TabIndex = 4;
            this.btnSpelaIgen.Text = "Spela igen";
            this.btnSpelaIgen.UseVisualStyleBackColor = true;
            this.btnSpelaIgen.Click += new System.EventHandler(this.btnSpelaIgen_Click);
            // 
            // tbxGissa
            // 
            this.tbxGissa.Location = new System.Drawing.Point(73, 41);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(37, 20);
            this.tbxGissa.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.btnSpelaIgen);
            this.Controls.Add(this.btnStartaSpelet);
            this.Controls.Add(this.gbxSpelet);
            this.Controls.Add(this.gbxSpeldata);
            this.Controls.Add(this.pbxBild);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBild)).EndInit();
            this.gbxSpeldata.ResumeLayout(false);
            this.gbxSpeldata.PerformLayout();
            this.gbxSpelet.ResumeLayout(false);
            this.gbxSpelet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBild;
        private System.Windows.Forms.GroupBox gbxSpeldata;
        private System.Windows.Forms.ListBox lbxStörstaTalet;
        private System.Windows.Forms.GroupBox gbxSpelet;
        private System.Windows.Forms.Label lblStörstTalet;
        private System.Windows.Forms.Button btnStartaSpelet;
        private System.Windows.Forms.Button btnSpelaIgen;
        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.Label lblMinaResultat;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblDatornsTal;
        private System.Windows.Forms.Label lblGissa;
        private System.Windows.Forms.Label lblDator;
        private System.Windows.Forms.TextBox tbxGissa;
    }
}

