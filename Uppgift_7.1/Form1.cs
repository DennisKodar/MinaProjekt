using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(tbxTal.Text);     //Double som definieras av textrutans inmatning.

            if (tal <= -0.1)                            //if sats som kollar om talet är mindre än -0.1.
            {
                tbxSvar.Text = "Talet är negativt";     //Om talet är mindre så blir resultatet att talet är negativt.
            }
            else if (tal == 0)                          //else if om talet är 0.
            {
                tbxSvar.Text = "Talet är 0";            //Om talet är 0 så säger den att talet är 0.
            }
            else if (tal >= 0.1)                        //else if om talet är högre än 0.1.
            {
                tbxSvar.Text = "Talet är positivt";     //Om talet är större så blir resultatet att talet är positivt.
            }
        }
    }
}
