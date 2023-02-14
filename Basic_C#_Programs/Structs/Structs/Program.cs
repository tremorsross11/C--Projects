using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal Number = 12;
            Console.WriteLine(Number);
            Console.ReadLine();
        }
    }
    public struct Number
    {
        public decimal amount { get; set; }
    }
}
