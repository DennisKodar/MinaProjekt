using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int månader = int.Parse(tbxTid.Text);                       //Skapar ett int värde från textrutans siffra.
            int år = månader / 12;                                      //Tar värdet i månader och sparar ett nytt värde efter man delat på 12.
            int månaderkvar = månader % 12;                             //Låter modulus ta det som blir kvar efter uträkningen visas som månaderkvar.

            lblSvar.Text = år + " år och " + månaderkvar + " månader."; //Skriver ut i en label hur många år och månader det blev i textrutan.
        }
    }
}
