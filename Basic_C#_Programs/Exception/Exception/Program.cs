using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age
                Console.WriteLine("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                // Display the year the user was born
                if (age > 0)
                {
                    int birthYear = DateTime.Now.Year - age;
                    Console.WriteLine($"You were born in {birthYear}");
                }

                // Display appropriate error messages if the user enters zero or negative numbers
                else if (age == 0)
                {
                    Console.WriteLine("You are not born yet!");
                }
                else
                {
                    Console.WriteLine("Age can not be negative.");
                }
            }

            // Display a general message if an exception was caused by anything else
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
        }
    }
}
