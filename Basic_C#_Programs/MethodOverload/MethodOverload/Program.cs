using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();

            int intResult = mathOperation.MathOperationCalculator(2);
            Console.WriteLine("Result of the Integer: " + intResult);

            int decimalResult = mathOperation.MathOperationCalculator(2.5);
            Console.WriteLine("Result of the Decimal: " + decimalResult);

            int stringResult = mathOperation.MathOperationCalculator("3");
            Console.WriteLine("Result of the String: " + stringResult);

            Console.ReadLine();
        }
    }
}
