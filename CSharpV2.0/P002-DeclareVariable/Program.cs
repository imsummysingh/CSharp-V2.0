using System;

namespace P002_DeclareVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            string studentName = "Summy";
            int age = 25;

            //print value
            Console.WriteLine("Hey {0}, Your age is: {1}", studentName, age);
            Console.ReadKey();
        }
    }
}
