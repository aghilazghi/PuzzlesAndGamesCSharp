using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzlesAndGamesLibrary
{
    public class Order
    {
        /*
        * Given three integers, if second is greater than first, and third is 
        * greater than second returns true. However, with the exception that if the 
        * parameter "isOk" is true, second does not need to be greater than 
        * first but still must be less than third.
        */
        public bool IsOrdered(int first, int second, int third, bool isOk) => 
            isOk ? (first < third && 
            second < third) : (first < second && 
            second < third);
    }
}
