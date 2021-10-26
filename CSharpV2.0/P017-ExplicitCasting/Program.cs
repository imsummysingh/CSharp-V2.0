using System;

namespace P017_ExplicitCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4000;
            byte b;
            b = (byte)a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();

        }
    }
}
