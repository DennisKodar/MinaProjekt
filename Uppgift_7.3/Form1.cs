using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rekordlängd = 7.92;                  //Definerar längden som är rekord.
            double maxvind = 2.01;                      //Definierar vilken längd det kan vara högst.
            double längd = double.Parse(tbxLängd.Text); //Tar emot textrutans värde och sparar det i en double.    
            double vind = double.Parse(tbxVind.Text);    //Tar emot textrutans värde och sparar det i en double.   

            if (längd > rekordlängd && vind < maxvind)  //Om längden är längre än rekordet och vinden är under maxvinden.
            {
                tbxSvar.Text = "Grattis, nytt rekord";  //Skriv ut att man fått nytt rekord i textrutan.
            }
            else                                        
            {
                tbxSvar.Text = "Tyvärr, inget nytt rekord"; //Om inte resultatet matchar uträkningen ovan så skriver den att man ej fick rekord.
            }
        }
    }
}
