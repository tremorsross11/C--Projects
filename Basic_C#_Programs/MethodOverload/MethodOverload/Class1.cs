using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class MathOperation
    {
        public int MathOperationCalculator(int value)
        {
            int result = value * value;
            return result;
        }

        public int MathOperationCalculator(double value)
        {
            int result = (int)(value / 2);
            return result;
        }

        public int MathOperationCalculator(string value)
        {
            int number;
            int.TryParse(value, out number);
            int result = number * number * number;
            return result;
        }
    }
}
