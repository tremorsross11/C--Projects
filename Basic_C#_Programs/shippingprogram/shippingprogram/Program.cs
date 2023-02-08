using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shippingprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int weight = int.Parse(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            Console.WriteLine("Please enter the package width:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = int.Parse(Console.ReadLine());

            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            int quote = (width * height * length * weight) / 100;

            Console.WriteLine("Your total quote is: ${0}", quote);
            Console.ReadLine();
        }
    }
}
