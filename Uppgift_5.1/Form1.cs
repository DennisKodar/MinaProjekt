using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(tbxTal.Text);                       //Omvandlar talet i textrutan till en int.
            int tal2 = ((((((tal + 1) * 2) - 6) / 2) + 3) - tal);   //Tar orignala int variabeln och gör en uträkning, massa med paranteser för att se till att det är egenvald ordning
            string svar = tal2.ToString();                          //Gör en string som är det som är i variabeln tal2, använder sig av ToString metoden för att omvandla.
            
            lblSvar.Text = svar;                                    //Visar svaret på uträkningen i en label.

        }
    }
}
