using System;

namespace P008_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i:{0}", i);
            }
            Console.ReadLine();
        }
    }
}
