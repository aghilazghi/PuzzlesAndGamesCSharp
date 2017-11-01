using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzlesAndGamesLibrary
{
    public class Cool
    {
        /*A number is cool if it's a multiple of 11 or if is one more than 
        * a multiple of 11. Return true if the given number is cool.
        */
        public bool IsCool(int givenNumber) => (givenNumber % 11 == 0 || givenNumber % 11 == 1);
    }
}
