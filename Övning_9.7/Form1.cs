using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int nivå = int.Parse(tbxNivå.Text);
            for (int i = 1; i <= nivå; i++)                 //den här handlar om själva räkningen så nivåerna är rätt
            {
                for (int j = 1; j <= 10; j++)               //och den här sköter så det blir 10 gånger det görs
                {
                    tbxUtdata.AppendText(i * j + "\t");
                }
                tbxUtdata.AppendText("\r\n");
            }
        }
    }
}
