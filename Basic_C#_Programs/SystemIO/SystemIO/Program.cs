using System;
using System.IO;


public class Program
{
    
    public static void Main(string[] args)
    {
        // Get user input
        Console.WriteLine("Please enter a number:");
        int input = Convert.ToInt32(Console.ReadLine());

        // Write the number to the text file
        using (StreamWriter writer = new StreamWriter("number.txt"))
        {
            writer.WriteLine(input);
        }

        // Print the number from the text file
        Console.WriteLine("Reading from the text file...");
        string text = File.ReadAllText("number.txt");
        Console.WriteLine(text);
    }
}