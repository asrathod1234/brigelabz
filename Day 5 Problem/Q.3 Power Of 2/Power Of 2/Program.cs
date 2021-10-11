using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfTwo(9223372036854775809));
            Console.WriteLine(IsPowerOfTwo(4));
            Console.ReadLine();
        }
        static bool IsPowerOfTwo(ulong n)
        {
            if (n == 0)
                return false;
            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;
                n = n / 2;
            }
            return true;
        }
    }
}
