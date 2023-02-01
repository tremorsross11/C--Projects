using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandDatatypes.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string yourNum = Console.ReadLine();
            Convert.ToInt32(yourNum);
            Console.WriteLine(yourName + " " + yourCourse + " " + yourNum);
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer true or false");
            string answer = Console.ReadLine();
            bool answer1 = Convert.ToBoolean(answer);
            Console.WriteLine(answer1);
            Console.WriteLine("Were there any positive experiences you would like to share or feedback you would like to provide?");
            string exp = Console.ReadLine();
            Console.WriteLine("How many hours did you study?");
            string h = Console.ReadLine();
            int hours = Convert.ToInt32(h);
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers! An instructor will respond to this shortly.");
            Console.ReadLine();



        }
    }
}
