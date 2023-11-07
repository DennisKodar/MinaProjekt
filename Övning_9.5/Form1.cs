using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int start = int.Parse(tbxStart.Text);
            int slut = int.Parse(tbxSlut.Text);     //variabler som bestäms av användarens inmatning.    
            int steg = int.Parse(tbxSteg.Text);
            tbxUtdata.Text = "";                    //för att rensa textrutan om man skriver in nytt.

            for (; start <= slut; start = start + steg)     //jamförelse som lägger ihop variablerna för att skapa korrekt utdata.
            {
                tbxUtdata.Text += (start.ToString()+" ");
            }
;
        }
    }
}
