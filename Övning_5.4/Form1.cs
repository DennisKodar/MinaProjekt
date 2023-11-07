using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int talA = int.Parse(tbxA.Text);                                        //Gör en int med värdet från textruta A
            int talB = int.Parse(tbxB.Text);                                        //Gör en int med värdet från textruta B
            int talC = int.Parse(tbxC.Text);                                        //Gör en int med värdet från textruta B

            bool svar = talA < talB && talB < talC || talA > talB && talB > talC;   //Jämför så värdet innan är mindre än det i rutan efter, eller tvärt om.
            lblSvar.Text = "Talen är i ordningsföljd: " + svar;                     //Skriver ut svaret i en label.
        }
    }
}
