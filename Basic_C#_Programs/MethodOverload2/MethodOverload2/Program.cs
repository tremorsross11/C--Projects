using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation();

            Console.WriteLine("Please enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number (optional):");
            string number2String = Console.ReadLine();
            int? number2 = null;
            if (!string.IsNullOrEmpty(number2String))
            {
                number2 = Convert.ToInt32(number2String);
            }

            int result = mathOperation.MathOperationCalculator(number1, number2);
            Console.WriteLine("Result: " + result);

            Console.ReadLine();
        }
    }

    public class MathOperation
    {
        public int MathOperationCalculator(int value1, int? value2 = null)
        {
            int result;
            if (value2 == null)
            {
                result = value1 * value1;
            }
            else
            {
                result = value1 * value2.Value;
            }
            return result;
        }
    }
}
    

