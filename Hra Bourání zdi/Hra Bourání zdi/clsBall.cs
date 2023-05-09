using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_Bourání_zdi
{
    class clsBall
    {
        //grafika na kreslení
        Graphics mobjGrafika;

        //kulička 
        int mintXBall, mintYBall;
        int mintPohybX, mintPohybY;
        const int mintRBall = 15;
        const int mintRychlostPosunu = 9;

        //-----------------------------------------------
        //konstruktor
        //-----------------------------------------------

        public clsBall(Graphics pobjPlatno)
        {
            mobjGrafika = pobjPlatno;

            mintXBall = (int)pobjPlatno.VisibleClipBounds.Width / 2;
            mintYBall = (int)pobjPlatno.VisibleClipBounds.Height / 2;
            mintPohybX = mintRychlostPosunu;
            mintPohybY = mintRychlostPosunu;
        }

        // načtení hodnot souřadnic kuličky
        public int intXBall
        {
            get
            { return mintXBall; }
        }

        public int intYBall
        {
            get
            { return mintXBall; }
        }

        public int intWBall
        {
            get
            { return mintXBall; }
        }

        public int intHBall
        {
            get
            { return mintXBall; }
        }

        public void Pohyb()
        {
            //vykreslení kuličky
            mobjGrafika.FillEllipse(Brushes.RosyBrown, mintXBall, mintYBall, mintRBall, mintRBall);

            //posun
            mintXBall += mintPohybX;
            mintYBall += mintPohybY;

            //test kolize na hranách
            if (mintYBall + mintRBall > (int)mobjGrafika.VisibleClipBounds.Height)
                mintPohybY = mintPohybY * (-1);

            if (mintYBall < 0)
                mintPohybY = mintPohybY * (-1);

            if (mintXBall + mintRBall > (int)mobjGrafika.VisibleClipBounds.Width)
                mintPohybX = mintPohybX * (-1);

            if (mintXBall < 0)
                mintPohybX = mintPohybX * (-1);
        }
    }
}
