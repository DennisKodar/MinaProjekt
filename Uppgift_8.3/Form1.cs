using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_8._3
{
    public partial class Form1 : Form
    {
        int nrDatorVinster;
        int nrSpelarVinster;
        int omgång;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnSpela_Click(object sender, EventArgs e)
        {
            gbxStenSaxPåse.Enabled = true;
            btnSpela.Enabled = false;
            
        }
        //de olika alternativen för spelaren
        private void pbxSten_Click(object sender, EventArgs e)
        {
            gbxStenSaxPåse.Enabled = false;
            kollaSvar("sten");
        }

        private void pbxSax_Click(object sender, EventArgs e)
        {
            gbxStenSaxPåse.Enabled = false;
            kollaSvar("sax");
        }

        private void pbxPåse_Click(object sender, EventArgs e)
        {
            gbxStenSaxPåse.Enabled = false;
            kollaSvar("påse");
        }
        //en metod som kollar vem som vinner
        private void kollaSvar(string användarensVal)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, 3);

            string[] datornsVal = { "sten", "sax", "påse" };
            string datornsSvar = datornsVal[randomIndex];

            if (användarensVal == "sten" && datornsSvar == "påse")
            {
                lblDatornsVal.Text = datornsSvar;
                förlust();
            }
            else if (användarensVal == "sten" && datornsSvar == "sax")
            {
                vinst();
            }
            else if (användarensVal == "påse" && datornsSvar == "sten")
            {
                vinst();
            }
            else if (användarensVal == "påse" && datornsSvar == "sax")
            {
                lblDatornsVal.Text = datornsSvar;
                förlust();
            }
            else if (användarensVal == "sax" && datornsSvar == "sten")
            {
                lblDatornsVal.Text = datornsSvar;
                förlust();
            }
            else if (användarensVal == "sax" && datornsSvar == "påse")
            {
                vinst();
            }
            else
            {
                btnSpela.Enabled = true;
            }
            //uppdaterar resultatet efter varje runda
            lblResultat.Text = "Dator: " + nrDatorVinster +
                                 "  Spelare: " + nrSpelarVinster;
            //avgör vinst
            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                ++omgång;
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("Omgång "+ omgång +"\r\n" + "Dator: " + nrDatorVinster +
                                 "  Spelare: " + nrSpelarVinster + "\r\n");
                nrDatorVinster = 0;
                nrSpelarVinster = 0;
            }

        }
        //metoder för att komprimera händelserna i if satserna
        private void vinst()
        {
            nrSpelarVinster++;
            btnSpela.Enabled = true;
            gbxStenSaxPåse.Enabled = true;
        }
        private void förlust()
        {
            nrDatorVinster++;
            btnSpela.Enabled = true;
            gbxStenSaxPåse.Enabled = true;
        }
    }
}
