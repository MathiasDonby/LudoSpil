using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoSpil
{
    class Dices
    {
            public struct Dice
        {
            public int result;
            Random random;
               public Dice(int max)
                {
                random = new Random();
                result = random.Next(1, max);
                }
        }





        
    }
}
