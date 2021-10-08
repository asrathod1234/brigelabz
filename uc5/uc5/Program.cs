using System;

namespace uc5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".....salary CalCulation.....");
            Console.Write("Enter No of Employee");
            int n = Convert.ToInt32(Console.ReadLine());

            salary[] sal = new salary[n];

            for (int i = 0; i < n; i++)
            {
                sal[i] = new salary();
                Console.WriteLine("Employee ID : {0}",i+1);

                Console.Write("Employee Name :");
                sal[i].Name = Console.ReadLine();

                Console.Write("Month :");
                sal[i].month = Console.ReadLine();

                Console.Write("Year :");
                sal[i].year = Console.ReadLine();

                Console.Write("Basic :");
                sal[i].Basic = Convert.ToDouble(Console.ReadLine());

                sal[i].Hr = sal[i].Basic * .65;
                sal[i].Medi = sal[i].Basic * .45;
                sal[i].Conv = sal[i].Basic * .10;
                sal[i].gross = sal[i].Hr + sal[i].Medi + sal[i].Conv;
                sal[i].Net = sal[i].Basic + sal[i].Gross;

            }
            Console.WriteLine("Employee ID\tName\tMonth\tYear\tBasic\House Rent\tMedical\tConveyance\tgross\tnet salary");
            Console.WriteLine("........................................................................................");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}", i + 1, sal[i].Name, sal[i].month, sal[i].year
                    , sal[i].Basic, sal[i].Hr, sal[i].Medi, sal[i].Conv, sal[i].Conv, sal[i].Gross, sal[i].Net);

            }
            Console.ReadLine();

        }
        class salary
        {
            internal double gross;
            internal double Gross;

            public string Name { get; set; }
            public string month { get; set; }
            public string year { get; set; }
            public double Basic { get; set; }
            public double Hr { get; set; }
            public double Medi { get; set; }
            public double Conv { get; set; }
            public double Net { get; set; }

        }
    }
}
