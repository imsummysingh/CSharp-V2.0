using System;

namespace P006_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("Value of i: {0}",i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
