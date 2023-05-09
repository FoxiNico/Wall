using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_Bourání_zdi
{
    internal class clsPlank
    {
        //grafika na kreslení
        Graphics mobjGrafika;

        //vozíček
        int mintXPlank, mintYPlank;
        int mintVyskaPlank, mintSirkaPlank;

        //-----------------------------------------------
        //konstruktor
        //-----------------------------------------------

        public clsPlank(Graphics objPlatno, int intXPlank, int intYPlank, int intSirkaPlank, int intVyskaPlank)
        {
            mobjGrafika = objPlatno;
            mintXPlank = intXPlank;
            mintYPlank = intYPlank;
            mintVyskaPlank = intVyskaPlank;
            mintSirkaPlank = intSirkaPlank;
            
        }

        //-----------------------------------------------
        //vykreslení vozíčku
        //-----------------------------------------------

        public void Nakrelit()
        {
            //vykreslení
            mobjGrafika.FillRectangle(Brushes.BlueViolet, mintXPlank, mintYPlank, mintSirkaPlank, mintVyskaPlank);
        }
    }
}
