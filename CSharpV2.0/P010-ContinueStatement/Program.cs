using System;

namespace P010_ContinueStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Continue Statement");

            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine("The value of i:{0}", i);
            }
            Console.ReadKey();
        }
    }
}
