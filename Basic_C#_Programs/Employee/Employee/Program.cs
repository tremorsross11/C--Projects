using Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
    }

    // Instantiate an Employee object with type “string” as its generic parameter
    Employee<string> stringEmployee = new Employee<string>();
    stringEmployee.Things = new List<string>() { "Hello", "World" };

// Instantiate an Employee object with type “int” as its generic parameter
        Employee<int> intEmployee = new Employee<int>();
        intEmployee.Things = new List<int>() { 1, 2, 3, 4, 5 };

// Create a loop that prints all of the Things to the Console
        foreach (var thing in stringEmployee.Things)
        {
            Console.WriteLine(thing);
        }

        foreach (var thing in intEmployee.Things)
        {
            Console.WriteLine(thing);
        }
}
