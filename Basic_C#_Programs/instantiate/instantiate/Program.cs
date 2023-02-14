using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instantiate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" };

            if (emp1 == emp2)
            {
                Console.WriteLine("The Employees are equal.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The Employees are not equal.");
                Console.ReadLine();
            }
        }
    }
}
