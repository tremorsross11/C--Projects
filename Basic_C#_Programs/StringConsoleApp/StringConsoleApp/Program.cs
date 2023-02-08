using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = "This is ";
            string secondString = "the first ";
            string thirdString = "sentence.";

            string result = firstString + secondString + thirdString;
            Console.WriteLine("Concatenation result: {0}", result);
            Console.WriteLine("Uppercase result: {0}", result.ToUpper());

            StringBuilder sb = new StringBuilder("Hello! ");
            sb.Append("This is the second sentence. ");
            sb.Append("this is the third sentence. ");
            sb.Append("This is the fourth sentence. ");
            Console.WriteLine("StringBuilder result: {0}", sb);
            Console.ReadLine();
        }
    }
}
