using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomecomparison.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Functions that convert string input into an integer and multiplys them and compares them
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person one info: ");
            Console.WriteLine("Hourly Rate: ");
            string hour = Console.ReadLine();
            Console.WriteLine("Hours worked: ");
            string work = Console.ReadLine();
            Console.WriteLine("Person two info: ");
            Console.WriteLine("Hourly Rate: ");
            string hour2 = Console.ReadLine();
            Console.WriteLine("Hours worked: ");
            string work2 = Console.ReadLine();
            Console.WriteLine("Annual salary of person one: ");
            int person1 = (Convert.ToInt32(hour) * Convert.ToInt32(work));
            Console.WriteLine(person1);
            Console.WriteLine("Annual salary of person two: ");
            int person2 = (Convert.ToInt32(hour2) * Convert.ToInt32(work2));
            Console.WriteLine(person2);
            Console.WriteLine("Does person one make more than person two?");
            Console.WriteLine(person1 > person2);
            Console.ReadLine();



        }
    }
}
