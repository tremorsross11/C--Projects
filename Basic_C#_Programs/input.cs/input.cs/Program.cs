using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace input.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Functions that take user input and performs different operations on it
            Console.WriteLine("Input a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((Int32)num * 50);
            Console.ReadLine();
            Console.WriteLine("Input a number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine((Int32)num2 + 25);
            Console.ReadLine();
            Console.WriteLine("Input a number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine((Int32)num3 / 12.5);
            Console.ReadLine();
            Console.WriteLine("Input a number");
            int num4 = int.Parse(Console.ReadLine());
            bool answer = true;
            Console.WriteLine((Int32)num4 > 50);
            Console.ReadLine();
            Console.WriteLine("Input a number");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine((Int32)num5 % 7);
            Console.ReadLine();


        }
    }
}
