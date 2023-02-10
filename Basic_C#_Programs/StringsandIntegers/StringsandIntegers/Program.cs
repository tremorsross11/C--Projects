using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsandIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {


                List<int> list = new List<int>();
                list.Add(0);
                list.Add(1);
                list.Add(2);
                list.Add(3);
                Console.WriteLine(list.Count);
                Console.ReadLine();

                Console.WriteLine("Input a number");
                int num = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(i + " divided by " + num + " equals " + i / num);
                    Console.ReadLine();

                }
            }
            catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();






        }
    }
}
