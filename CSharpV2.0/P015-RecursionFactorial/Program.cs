using System;

namespace P015_RecursionFactorial
{
    class Sample
    {
        public double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());

            Sample s = new Sample();
            double fact = s.Factorial(n);
            Console.WriteLine("Factorial of {0} is {1}", n, fact);

            Console.ReadKey();
        }
    }
}
