using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(tbxTal.Text);
            if (ärPrimtal(tal) == true)                        //här anropas metoden för primtal
            {
                tbxSvar.Text = "Talet är ett primtal";
            }
            else
            {
                tbxSvar.Text = "Talet är inte ett primtal";
            }
        }
        bool ärPrimtal(int kontrolltal)
        {
            //kollar om det är primtal, delar självt och 1
            for (int i = 2; i <= kontrolltal / 2; i++)
            {
                if (kontrolltal % i == 0)                       //använder modula för att kolla om det finns någonting kvar efter loopen har körts, om det inte finns något kvar är det falskt.
                {
                    return false;
                }
            }
            return true;
        }
    }
}
