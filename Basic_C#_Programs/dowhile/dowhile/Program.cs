using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool booleanComparisonValue = true;
            while (booleanComparisonValue)
            {
                Console.WriteLine("True");
                booleanComparisonValue = false;
            }

            // Boolean Comparison using a Do-While Statement 

            bool booleanComparisonValue2 = true;
            do
            {
                Console.WriteLine("True");
                booleanComparisonValue2 = false;
            }
            while (booleanComparisonValue2);

            Console.Read();
        }
    }
}
