using System;

namespace helloworld1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ispresent = 1;

            Random random = new Random();

            int check = random.Next(0, 2);//0,1

            if(check == ispresent)
            {
                Console.WriteLine("is present");
            }
            else
            {
                Console.WriteLine("is absent");
            }
            
           
        }
    }
}
