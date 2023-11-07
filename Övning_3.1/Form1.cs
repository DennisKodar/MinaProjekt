using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(tbxTal.Text);   //Omvandla textrutans
                                                //text till ett tal.

            int kvadrat = tal * tal;            //Beräknar kvadrated genom att gångra sig självt.
            string text = kvadrat.ToString();   //Omvandla tal till text.
            tbxTal.Text = text;                 //Visar resultat i textrutan.

            //När man trycker på knappen upprepade gånger så räknar den om med nya talet,
            //det blir dock fel tillslut när den får ett tal som blir större än integer.
        }
    }
}
