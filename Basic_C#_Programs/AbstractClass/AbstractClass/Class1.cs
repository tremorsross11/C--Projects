using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();
    }
    

    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("Employee " + firstName + " " + lastName + " is quitting!");
            Console.ReadLine();
        }
    }
}
