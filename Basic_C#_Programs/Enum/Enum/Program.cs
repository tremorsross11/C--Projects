using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week:");
            try
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
                Console.WriteLine("Today is {0}.", day);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
          

    }

}
}
