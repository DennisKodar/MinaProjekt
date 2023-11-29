using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bastal = int.Parse(tbxBas.Text);
            int exponentökning = int.Parse(tbxExponent.Text);
            tbxUtdata.Text = bastal + " upphöjt till " + exponentökning + " är " + potens(bastal, exponentökning);
        }
        int potens(int bas, int exponent)
        {
            int basExtra = bas;
            for (int i = 1; i < exponent; i++)
            {
               basExtra *= bas;             //ett extra basvärde används så att man inte ska ändra slutresultatet i uträkningen.
            }
            return basExtra;
        }
    }
}
