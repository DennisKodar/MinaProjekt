using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double egnacash = double.Parse(tbxPengar.Text); //Gör en double variabel som defineras av textruta 1 inmatning.
            double pris = double.Parse(tbxPris.Text);       //Gör en double variabel som defineras av textruta 2 inmatning.
            bool enough = egnacash > pris;                  //Gör en true eller false variabel som jämför "pris" och "egnacash"

            lblSvar.Text = "Jag har råd: " + enough;        //Skriver ut svaret från "enough" i en label.
        }
    }
}
