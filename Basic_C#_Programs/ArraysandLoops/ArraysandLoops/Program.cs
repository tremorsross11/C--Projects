using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Create a one-dimensional array of strings
            //string[] myArray = new string[4] { "Hello", "Hi", "Good morning", "Good evening" };

            //// Ask the user to input some text
            //Console.WriteLine("Please enter some text: ");
            //string userText = Console.ReadLine();

            //// A loop that iterates through each string in the array and adds the user's text input to the end of each string
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = myArray[i] + " " + userText;
            //}

            //// A second loop that prints off each string in the array one at a time
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //    Console.ReadLine();
            //}

            ////////Infinite Loop
            //////for (int i = 0; i < myArray.Length; i++)
            //////{
            //////    Console.WriteLine(myArray[i--]);
            //////    Console.ReadLine();
            //////}

            //// Loop where the comparison that’s used to determine whether to continue iterating the loop is a "<" operator 
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (i < myArray.Length)
            //    {
            //        Console.WriteLine(myArray[i]);
            //        Console.ReadLine();
            //    }
            //}

            //// Loop where the comparison that’s used to determine whether to continue iterating the loop is a "<=" operator 
            //for (int i = 0; i <= myArray.Length; i++)
            //{
            //    if (i < myArray.Length)
            //    {
            //        Console.WriteLine(myArray[i]);
            //        Console.ReadLine();
            //    }
            //}

            // define list of strings
            List<string> myList = new List<string> { "apple", "banana", "cherry", "fig" };

            // ask user to input text to search for
            Console.WriteLine("Please enter some text to search for in the list: ");
            string searchValue = Console.ReadLine();

            // loop that iterates through the list and then displays the index of the list item that contains matching text on the screen
            int i = 0;
            foreach (string item in myList)
            {
                if (item.Contains(searchValue))
                {
                    Console.WriteLine("Index of the list item that contains the matching text: " + i);
                    Console.ReadLine();
                    break;
                }
                i++;
            }

            // check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list
            if (!myList.Contains(searchValue))
            {
                Console.WriteLine("Input is not on the list.");
                Console.ReadLine();
            }

            // ask user to select text to search for
            Console.WriteLine("Please select some text to search for in the list: ");
            string searchValue1 = Console.ReadLine();

            // loop that iterates through the list and then displays the indices of the items matching the user-selected text
            int j = 0;
            foreach (string item in myList)
            {
                if (item.Contains(searchValue1))
                {
                    Console.WriteLine("Index of the list item that contains the matching text: " + j);
                    Console.ReadLine();
                }
                j++;
            }

            // check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list
            if (!myList.Contains(searchValue1))
            {
                Console.WriteLine("Input is not on the list.");
                Console.ReadLine();
            }

            List<string> names = new List<string> {
                "John",
                "James",
                "John"
            };

            Dictionary<string, bool> contains = new Dictionary<string, bool>();

            foreach (string name in names)
            {
                if (contains.ContainsKey(name))
                    Console.WriteLine($"{name} has already appeared in the list");
               
                else
                {
                    contains.Add(name, true);
                    Console.WriteLine($"{name}");
                    
                }
                Console.ReadLine();
            }




        }
    }
}
