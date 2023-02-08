using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guess = number == 12;

            while (guess)
            {



                switch (number)
                {
                    case 62:
                        Console.WriteLine("you guessed 62. try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("you guessed 29. try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You win!");
                        guess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess a number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        break;


                }
            }
            Console.Read();
        }
    }
}
