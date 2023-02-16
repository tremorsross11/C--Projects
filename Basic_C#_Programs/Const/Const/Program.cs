using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable
            const int myNum = 10;

            // Create a variable using the keyword “var”
            var myString = "Hello World!";

            // Chain two constructors together
            var firstConstructor = new MyClass("SomeValue");
            var secondConstructor = new MyClass(1, firstConstructor);
        }
    }

    class MyClass
    {
        string value;

        // First constructor
        public MyClass(string str)
        {
            this.value = str;
        }

        // Second constructor
        public MyClass(int num, MyClass myClass)
        {
            this.value = myClass.value + num;
        }
    }
}