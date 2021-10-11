using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q._1_Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter money amount:");
            int money = Convert.ToInt32(Console.ReadLine());
            int[] notes = new int[] { 1, 2, 5, 10, 50, 500, 1000 };
            int length = notes.Length;
            Utility utility = new Utility();
            Console.WriteLine("Minimum Notes= " + utility.MinNotes(notes, length, money));
        }
    }
}
