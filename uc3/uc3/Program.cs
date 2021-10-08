using System;

namespace uc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs2 = 8;
            int empHrs1 = 4;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            if (empCheck == IS_PART_TIME)
            {
                    empHrs2 = 8;
            }
            else
            {
                    empHrs1 = 4;
            }
            empWage = empHrs1 * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp wage :" + empWage);
            empWage = empHrs2 * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :" + empWage);
        }
    }
}
