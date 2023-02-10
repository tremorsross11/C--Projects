using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number");
                int NumberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a number");
                int NumberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dividing the two...");
                int NumberThree = NumberOne / NumberTwo;
                Console.WriteLine(NumberOne + " divided by " + NumberTwo + " equals " + NumberThree);
                Console.ReadLine();

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            

        }
    }
}
