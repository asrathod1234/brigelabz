using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_5_wageOfMonth
{
    class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkingDay = 20;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < numOfWorkingDay; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                empWage = empHrs * empRatePerHour;
                totalEmpWage += empWage;
                Console.WriteLine(" Emp Wage ; " + empWage);

            }
            Console.WriteLine("Total emp wage :" + totalEmpWage);
            Console.WriteLine();

        }

    }
}
