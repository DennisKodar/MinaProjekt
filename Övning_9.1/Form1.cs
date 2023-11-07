using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStarta_Click(object sender, EventArgs e)
        {   
            int räknare = 0;
            int slut = int.Parse(tbxSlutvärde.Text);    

            while (räknare < slut)
            {
                räknare++;
                tbxUtdata.AppendText(räknare + "\r\n"); //att skriva \t eller typ \r\n ändrar sättet det struktureras i textrutan. Append betyder att den lägger till för att komma till slutvärdet.

            }
        }
    }
}
