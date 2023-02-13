using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload4
{
    public class Program
    {
         
        public class Class1
        {
            // Create a void method that outputs an integer
            public void DivideIntByTwo(int input)
            {
                int result = input / 2;
                Convert.ToString(result);
                Console.WriteLine(result);
                
            }
            
        }

        
        public static void Main()
        {
            Class1 instance = new Class1();

            // Have the user enter a number.
            Console.WriteLine("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());

            // Call the method on that number.
            instance.DivideIntByTwo(input);

            // Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine(instance.DivideIntByTwo(input));
        }

        // Create a method with output parameters
        public static void ExampleMethod(int a, int b, out int sum, out int difference)
        {
            sum = a + b;
            difference = a - b;
        }

        // Overload a method
        public static int ExampleMethod(int a, int b)
        {
            return a + b;
        }

        // Declare a class to be static
        public static class StaticClass
        {
            public static void OutputString(string str)
            {
                Console.WriteLine(str);
            }
        }
    }

}

