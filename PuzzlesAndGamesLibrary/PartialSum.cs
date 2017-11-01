using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PuzzlesAndGamesLibrary
{
    public class PartialSum
    {
        /*
         * Given 3 integer arguments a, b, and c return their sum. However, if one
         * of the arguments is 13 then it does not count towards the sum and 
         * arguments to its right do not count either.
         */

        public int Sum(int a, int b, int c)
        {
            if (a == 13) return 0;
            if (b == 13) return a;
            if (c == 13) return a + b;

            return a + b + c;
        }
    }
}
