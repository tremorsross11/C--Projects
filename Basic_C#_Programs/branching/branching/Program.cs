using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentTemp = 70;
            int roomTemp = 70;

            if (currentTemp == roomTemp)
            {
                Console.WriteLine("It is room temp");

            }
            else if (currentTemp > roomTemp)
            {
                Console.WriteLine("It is warmer than room temp");
            }
            else
            {
                Console.WriteLine("It is not room temp");
            }
            Console.ReadLine();
        }
    }
}
