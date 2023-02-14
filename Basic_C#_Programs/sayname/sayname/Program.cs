using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayname
{
    internal class Program
    {
        // Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”
        public static void Main()
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the superclass method SayName() on the Employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
