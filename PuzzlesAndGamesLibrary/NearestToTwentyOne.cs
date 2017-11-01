using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzlesAndGamesLibrary
{
    public class NearestToTwentyOne
    {
        /* Given two positive integers arguments, return whichever is nearest
         * to 21 without going over. Return 0 if they go over 21.
         */
        public int Near(int a, int b)
        {
            if ((a >= b && a <= 21) || (b > 21 && a <= 21)) return a;
            if ((b >= a && b <= 21) || (a > 21 && b <= 21)) return b;

            return 0;
        }
        
    }
}
