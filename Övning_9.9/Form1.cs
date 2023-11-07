using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkjut_Click(object sender, EventArgs e)
        {
            string[] namn = new string[2]; 
            namn[0] = tbx1.Text;
            namn[1] = tbx2.Text;
            namn[2] = tbx3.Text;

            tbx1.Text = "" + namn[2];
            tbx2.Text = "" + namn[0];
            tbx3.Text = "" + namn[1];
        }
    }
}
