using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instantiate
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee first, Employee second)
        {
            return (first.Id == second.Id);
        }

        public static bool operator !=(Employee first, Employee second)
        {
            return (first.Id != second.Id);
        }
    }
}
