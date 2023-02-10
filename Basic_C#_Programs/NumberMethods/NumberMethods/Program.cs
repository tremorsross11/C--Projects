using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("The result of your math operations are:");
            Console.WriteLine(MathOperations.Addition(num));
            Console.WriteLine(MathOperations.Subtraction(num));
            Console.WriteLine(MathOperations.Multiplication(num));
            Console.ReadLine();
        }
        
    }
}
