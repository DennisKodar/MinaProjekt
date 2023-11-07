using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._2
{
    public partial class Golf : Form
    {
        public Golf()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int längd = int.Parse(tbxLängd.Text);                       //Gör en int variabel som defineras av textruta 1.

            if (längd < 150)                                            //Om längden är mindre än 150.
            {
                tbxSvar.Text = "Grattis!";                              //Skriver Grattis! i textrutan.
            }
            else if (längd > 190)                                       //Om längden är över 190.
            {
                tbxSvar.Text = "Grattis!";                              //Skriver Grattis! i textrutan.
            }
            else
            {
                tbxSvar.Text = "Bollen finns i dammen, bara att dyka :D"; //Om inget av dem ovan passade så hamnade bollen antagligen i dammen, då skrivs det.
            }
        }
    }
}
