using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float värde = float.Parse(textBox1.Text);   //Gör ett float värde som defineras av det som står i textrutan.
            värde = värde + 0.5f;                       //Adderar 0.5 på värdet
            int värde2 = (int)värde;                    //Omvandlar float värdet till en int.
            button1.Text = värde2.ToString();           //Visar värdet av "värde2" i knappens textegenskaper.
        }
    }
}
