using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbxTal.Text);    //Definierar variabeln "a" med textbox input.
            int b = ++a;                       //Variabel "b" är "a" plus 1, a värdet plussar också med 1.
            int c = --b + --a;                 //Variabel "c" = "b" minus 1 + a minus 1.

            lblSvar.Text = c.ToString();
        }
    }
}
