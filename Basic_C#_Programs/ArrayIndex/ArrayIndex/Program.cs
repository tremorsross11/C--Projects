using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] ArrayOfStrings = { "String1", "String2", "String3" };
            Console.WriteLine("Select an index of the Array (0, 1, or 2):");
            int index = int.Parse(Console.ReadLine());

            // Display the string at the index the user selected
            Console.WriteLine($"You chose the string at index {index}: {ArrayOfStrings[index]}");

            // Declare one-dimensional array of integers
            int[] ArrayOfIntegers = { 1, 2, 3 };
            Console.WriteLine("Select an index of the Array (0, 1, or 2):");
            int index2 = int.Parse(Console.ReadLine());

            // Display the integer at the index the user selected
            Console.WriteLine($"You chose the integer at index {index2}: {ArrayOfIntegers[index2]}");

            // create a list of strings 
            List<string> ListOfStrings = new List<string>() { "String1", "String2", "String3" };
            Console.WriteLine("Select an index of the List (0, 1, or 2):");
            int index3 = int.Parse(Console.ReadLine());

            // Display the content at the index the user selected
            if (index3 >= 0 && index3 <= ListOfStrings.Count - 1)
            {
                Console.WriteLine($"You chose the content at index {index3}: {ListOfStrings[index3]}");
            }
            else
            {
                
                Console.WriteLine("The index you chose does not exist.");
            }
            Console.ReadLine();
        }
    }
}
