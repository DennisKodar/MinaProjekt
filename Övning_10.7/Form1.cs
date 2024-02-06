using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_10._7
{
    public partial class Form1 : Form
    {
        Random slump = new Random();
        int antal = 5;                      //flyttat 2 variabler här så dem blir medlemsvariabler och finns överallt
        int[] tärningar = new int[5];
        public Form1() 
        {
            InitializeComponent();
        }

        private void btnKasta_Click(object sender, EventArgs e)
        {
            kastaTärningar();                //Här behövs ej variabler definieras då dem är medlemsvariabler
            visaTärningar();
        }
        void kastaTärningar()                               //här och i visa tärningar så har jag tagit bort så att man behöver skapa nya variabler med metoden
        {
            for (int i = 0; i < antal; i++)
            {
                int antalPrickar = slump.Next(1, 7);
                tärningar[i] = antalPrickar;
            }

            DiceBag db = new DiceBag();
            db.NoOfD6 = 4;
            db.NoOfD10 = 7;
            int result = db.RollDice();


        }
        void visaTärningar()
        {
            tbxResultat.Text = "";
            for (int i= 0; i < antal; i++)
            {
                tbxResultat.AppendText("Tärning " + (i + 1) + ":   " + tärningar[i] + "\n");
            }
        }
    }
}
