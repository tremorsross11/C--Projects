using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload3
{
    public class MyClass
    {
        public void DoMath(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("Result: {0}", result);
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            // Calling the method with two numerical parameters
            myClass.DoMath(2, 5);

            // Calling the method with two parameters specified by name
            myClass.DoMath(number1: 2, number2: 5);
        }
    }
}
