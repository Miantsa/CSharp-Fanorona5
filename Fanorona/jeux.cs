using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fanorona
{
    public static class jeux
    {
        public static int[,] elimination( int[,] avant, int[] from, int[] to) {
           
            
            int[,] apres = new int[5, 5];
            apres = avant;
            int[] eliminer = new int[2]; 
            int ligneTemp = 0; int colonneTemp = 0;
            ligneTemp = to[0] - from[0];
            colonneTemp = to[1] - from[1];
            ligneTemp = to[0] + ligneTemp;
            colonneTemp = to[1] + colonneTemp;
            if ((ligneTemp>=0 && ligneTemp<=4)&&(colonneTemp>=0 && colonneTemp <= 4))
            {
                apres[ligneTemp,  colonneTemp] = 0;
            }
            return apres;

        }
    }
}
