namespace Uppgift_10._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTal = new System.Windows.Forms.TextBox();
            this.tbxTecken = new System.Windows.Forms.TextBox();
            this.btnVisaTecken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tecken:";
            // 
            // tbxTal
            // 
            this.tbxTal.Location = new System.Drawing.Point(108, 18);
            this.tbxTal.Name = "tbxTal";
            this.tbxTal.Size = new System.Drawing.Size(100, 20);
            this.tbxTal.TabIndex = 2;
            // 
            // tbxTecken
            // 
            this.tbxTecken.Location = new System.Drawing.Point(108, 66);
            this.tbxTecken.Name = "tbxTecken";
            this.tbxTecken.Size = new System.Drawing.Size(100, 20);
            this.tbxTecken.TabIndex = 3;
            // 
            // btnVisaTecken
            // 
            this.btnVisaTecken.Location = new System.Drawing.Point(59, 115);
            this.btnVisaTecken.Name = "btnVisaTecken";
            this.btnVisaTecken.Size = new System.Drawing.Size(75, 23);
            this.btnVisaTecken.TabIndex = 4;
            this.btnVisaTecken.Text = "Visa tecken";
            this.btnVisaTecken.UseVisualStyleBackColor = true;
            this.btnVisaTecken.Click += new System.EventHandler(this.btnVisaTecken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisaTecken);
            this.Controls.Add(this.tbxTecken);
            this.Controls.Add(this.tbxTal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTal;
        private System.Windows.Forms.TextBox tbxTecken;
        private System.Windows.Forms.Button btnVisaTecken;
    }
}

