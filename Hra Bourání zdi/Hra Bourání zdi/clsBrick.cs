using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_Bourání_zdi
{
    class clsBrick
    {
        Graphics mobjGrafika;

        //cihla
        int mintXBrick, mintYBrick;
        int mintVyskaBrick, mintSirkaBrick;
        bool mblViditelnost;

        //-----------------------------------------------
        //konstruktor
        //-----------------------------------------------

        public clsBrick(Graphics objPlatno, int intXBrick, int intYBrick, int intSirkaBrick, int intVyskaBrick)
        {
            mobjGrafika = objPlatno;
            mintXBrick = intXBrick;
            mintYBrick = intYBrick;
            mintVyskaBrick = intVyskaBrick;
            mintSirkaBrick = intSirkaBrick;
            mblViditelnost = true;
        }
        
        //-----------------------------------------------
        //vykreslení cihly
        // - vrací true při kolizi
        //-----------------------------------------------

        public void Nakrelit()
        {
            //test viditelnosti
            if (mblViditelnost == false) return;

            //vykreslení
            mobjGrafika.FillRectangle(Brushes.Orange, mintXBrick, mintYBrick, mintSirkaBrick, mintVyskaBrick);
        }

        //-----------------------------------------------
        //test kolize cihly a kuličky
        //-----------------------------------------------

        public bool TestKolize(int intXBall, int intYBall, int intWBall, int intHBall)
        {
            //test viditelnosti cihly
            if (mblViditelnost == false) return false;

            // test kolize
            if (intYBall <= mintYBrick)
            {
                //cihla není vidět
                mblViditelnost = false;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
