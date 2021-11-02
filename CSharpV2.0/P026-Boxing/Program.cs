using System;

namespace P026_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //primitive value
            int x = 10;

            //non-primitive value
            //boxing
            object obj = x;

            Console.WriteLine("Before Boxing: {0}", x);
            Console.WriteLine("After Boxing: {0}", obj);

            Console.ReadLine();
        }
    }
}
