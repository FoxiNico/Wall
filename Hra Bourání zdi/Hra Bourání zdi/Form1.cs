using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Hra_Bourání_zdi
{
    public partial class Form1 : Form
    {
        //grafika na kreslení
        Graphics mobjGrafika;

        // timer
        const int TimerInterval = 20;

        //kulička třída
        clsBall mobjBall;

        //cihly třída - pole
        int mintPocetCihel;
        clsBrick[] mobjBrick;
        const int mintSirkaCihly = 80, mintVyskaCihly = 20;
        const int mintVelikostMezery = 20;
        const int mintPocetRadCihel = 3;

        private void Form1_Load(object sender, EventArgs e)
        {
            //init timeru
            tmrAnimaceBall.Interval = TimerInterval;
            tmrAnimaceBall.Start();
        }

        public Form1()
        {
            int lintX, lintY;

            InitializeComponent();

            //inicializace proměnných
            mobjGrafika = pbPlatno.CreateGraphics();

            //vytvořit kuličku
            mobjBall = new clsBall(mobjGrafika);

            //vytvořit pole cihel
            mintPocetCihel = mintPocetRadCihel * ((pbPlatno.Width - mintVelikostMezery) / (mintSirkaCihly + mintVelikostMezery));
            mobjBrick = new clsBrick[mintPocetCihel];

            //vytvořit cihly
            lintX = lintY = mintVelikostMezery;
            for (int i = 0; i < mintPocetCihel; i++)
            {
                //init jedné cihly
                mobjBrick[i] = new clsBrick(mobjGrafika, lintX, lintY, mintSirkaCihly, mintVyskaCihly);

                //změna souřadnic
                lintX = lintX + mintSirkaCihly + mintVelikostMezery;
                if (lintX + mintSirkaCihly > pbPlatno.Width)
                {
                    lintX = mintVelikostMezery;
                    lintY = lintY + mintVyskaCihly + mintVelikostMezery;
                }
            }

        }

        private void tmrAnimaceBall_Tick(object sender, EventArgs e)
        {
            //smazat scénu
            mobjGrafika.Clear(Color.White);

            //pohyb kuličky
            mobjBall.Pohyb();

            //test kolizí cihel
            foreach (clsBrick objBrick in mobjBrick)
            {
                objBrick.TestKolize(mobjBall.intXBall, mobjBall.intYBall, mobjBall.intWBall, mobjBall.intHBall);
            }

            //vykreslení všech cihel
            foreach(clsBrick objBrick in mobjBrick)
            {
                objBrick.Nakrelit();
            }
        }
    }
}
