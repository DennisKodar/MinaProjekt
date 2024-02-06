using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(tbxTal1.Text);
            int tal2 = int.Parse(tbxTal2.Text);
            int tal3 = int.Parse(tbxTal3.Text);
            tal1 *= 2;
            tal2 *= 3;
            tal3 *= 4;
            int sumtot = tal1 + tal2 + tal3;
            lblSvar.Text = "Svar: " + sumtot;

        }
    }
}
