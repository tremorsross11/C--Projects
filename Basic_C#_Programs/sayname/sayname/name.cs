using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayname
{
    // Create a class called Person
    public class Person
    {
        // Give it two properties, each of data type string
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Give this class a void method called SayName()
        public void SayName()
        {
            // Writes the person's full name to the console in the format of: “Name: [full name]”
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    // Create another class called Employee and have it inherit from the Person class
    public class Employee : Person
    {
        // Give the Employee class a property called Id and have it be of data type int
        public int Id { get; set; }
    }
}
