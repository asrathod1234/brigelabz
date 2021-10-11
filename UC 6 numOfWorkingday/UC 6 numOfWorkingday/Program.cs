using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_6_numOfWorkingday
{
    class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empRatePerHour = 20;
        public const int numOfWorkingDay = 20;
        public const int maxHrsInMonth = 100;

        static void Main(string[] args)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDay = 0;
            int totalEmpWage = 0;

            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDay < numOfWorkingDay)
            {
                totalWorkingDay++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day: " + totalWorkingDay + " Emp Hrs : " + empHrs);

            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emo Wage :" + totalEmpWage);
            Console.ReadLine();
        }
    }
}
