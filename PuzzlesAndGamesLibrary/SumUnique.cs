using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzlesAndGamesLibrary
{
    public class SumUnique
    {
        /*
         * Given 3 ints arguments: a, b, and c return their sum. However, if one 
         * the arguments is the same as any other ones, that number should not 
         * count towards the sum.
         */
        public int Sum(int a, int b, int c)
        {
            var sum = 0;

            if (a != b && a != c && b != c) return sum += a + b + c;
            if (a == b) return sum += c;
            if (a == c) return sum += b;
            if (b == c) return sum += a;

            return sum;
        }
    }
}
