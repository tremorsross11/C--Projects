using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (yes or no)");
            string dui = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool qualified = (age > 15) && (dui.ToLower() != "yes") && (tickets <= 3);
            Console.WriteLine("Applicant qualified for car insurance: " + qualified);
            Console.ReadLine();
        }

    }
}
