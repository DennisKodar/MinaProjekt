using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            decimal radie = decimal.Parse(tbxRadie.Text);
            tbxOmkrets.Text = omkretsCirkel(radie).ToString();          //anropar att textrutan ska vara svaret på metodens uträkning
            
        }
        decimal omkretsCirkel(decimal radie)
        {
            radie = (radie + radie) * (decimal)Math.PI;                 //radie variabeln är ursprungligen från textrutan radie
            return radie;                                               
        }
    }

}
