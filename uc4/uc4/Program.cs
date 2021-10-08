using System;

namespace uc4
{
    class switchcase
    {
        static void Main(string[] args)
        {
            int week_number = 2;
            switch (week_number)
            {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("wednesday");
            break;
        case 4:
            Console.WriteLine("thursday");
            break;
        case 5:
            Console.WriteLine("friday");
            break;
        case 6:
            Console.WriteLine("saturday");
            break;
        case 7:
            Console.WriteLine("sunday");
            break;
        default:
            Console.WriteLine("invalid week number..");
            break;
            }
            
     
            
            }
        }
    }

