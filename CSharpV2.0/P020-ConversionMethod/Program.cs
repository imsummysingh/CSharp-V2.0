using System;

namespace P020_ConversionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10000;
            string b;

            b = Convert.ToString(a);

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
