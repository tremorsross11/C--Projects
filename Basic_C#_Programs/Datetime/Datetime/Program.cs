using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints the current date and time to the console
            Console.WriteLine("The current date and time is " + DateTime.Now);

            // Asks the user for a number
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Prints to the console the exact time it will be in X hours
            DateTime futureTime = DateTime.Now.AddHours(number);
            Console.WriteLine("The time in " + number + " hours will be " + futureTime);
            Console.Read();
        }
    }
}