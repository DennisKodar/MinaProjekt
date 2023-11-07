using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            for (int i = 5; i <= 100; i = i + 5)    //skapar en int som man kollar så den inte är över eller lika med undra, då plussar den med 5 och skriver ut i rutan.
            {
                tbxUtdata.Text+=(i.ToString()+" ");
            }
;
        }
    }
}
