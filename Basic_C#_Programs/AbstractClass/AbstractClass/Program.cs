using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.firstName = "Sample";
            emp.lastName = "Student";
            emp.SayName();
            Console.ReadLine();

            IQuittable empQuit = emp;
            empQuit.Quit();
        }
    }
}
