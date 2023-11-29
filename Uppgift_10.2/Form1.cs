using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisaTecken_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(tbxTal.Text);
            char tecken2 = ' ';
            tbxTecken.Text = bestämTecken(tal, tecken2).ToString(); //här anropar man att texten i tecken är vad metodens resultat blir.
        }
        char bestämTecken(double tal, char tecken)
        {
            if (tal < 0)
            {
                tecken = '-';
                return tecken;
            }
            else if (tal >= 0)                          //olika bestämmelser som kollar värdet på talet och bestämmer vad man får i return
            {   
                tecken = '+';
                return tecken;
            }
            return ' ';
        }
    }
}
