using System;

namespace P003_IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks = 25;

            if (marks >= 35)
            {
                Console.WriteLine("Congratulation");
            }
            else
            {
                Console.WriteLine("Need to work hard");
            }

            Console.ReadKey();
        }
    }
}
