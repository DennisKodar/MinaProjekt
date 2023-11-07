using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double låtar = double.Parse(tbxLåtar.Text);     //definierar antalet låtar från svaret i textrutan, använder parse metoden för att få en double.
            double pris = 9.90;                             //definierar ett fast pris på 9.90 kr.
            double prisres = pris * låtar;                  //Räknar ut ett nytt pris genom att gångra priset med antalet låtar
            if (låtar < 10)                                 //Om antalet låtar är mindre än 10 så körs första
            {
                double utanrabatt = prisres;                //Variabel som är får normal priset utan rabatt
                lblSvar.Text = "Kostnaden för " + låtar + " låtar är " + utanrabatt + " kronor";    //Skriver ut i en label vad priset blir.
            }
            else if (låtar > 10 && låtar < 100)             //Om låtar är över 10 men under 100 så körs första else if
            {
                double rabatt1 = prisres * 0.9;             //Multiplicerar orginalpriset för antalet skivor med 0.9 för få rabatterat pris.
                lblSvar.Text = "Kostnaden för " + låtar + " låtar är " + rabatt1 + " kronor";       //Skriver ut i en label vad priset blir.
            }
            else if (låtar > 100)                           //Om låtarna är över 100 så körs sista else if satsen.
            {
                double rabatt1 = prisres * 0.85;            //Multiplicerar orginalpriset för antalet skivor med 0.85 för få rabatterat pris.
                lblSvar.Text = "Kostnaden för " + låtar + " låtar är " + rabatt1 + " kronor";       //Skriver ut i en label vad priset blir.
            }
        }

        
    }
}
