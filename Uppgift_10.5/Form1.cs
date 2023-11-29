using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisaVersal_Click(object sender, EventArgs e)
        {
            char gemen = tbxGemen.Text[0];
            tbxVersal.Text = GemenTillVersal(gemen).ToString();     //textrutans resultat blir då char värdet som jag får tillbaka

        }
        char GemenTillVersal(char gemenkonvertera)
        {
            int kod = (int)gemenkonvertera - 32;        //jag tar bort 32 från unicode värdet som jag fick från att konvertera min char då det blir den stora bokstaven i unicode tabellen
            char versalsvar = (char)kod;
            return versalsvar;
        }
    }
}
