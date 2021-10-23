using System;

namespace P009_BreakStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break Statement");

            for(int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    break;
                }
                Console.WriteLine("The value of i:{0}", i);
            }
            Console.ReadKey();
        }
    }
}
