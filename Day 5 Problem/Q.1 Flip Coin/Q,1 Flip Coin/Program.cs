using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1_Flip_Coin
{
    class Program
    {
        static void Main(string[] args)
        {
            int loopCount = 1;

            double result;

            while (loopCount < 10)
            {

                result = Math.random (0,1);

                if (result <= .5)
                {
                        Console.WriteLine("Thelt is heads.");

                  else

                        Console.WriteLine("Thelt is tails.");
                }
                loopCount = loopCount + 1;

            }



        }

    }
}
