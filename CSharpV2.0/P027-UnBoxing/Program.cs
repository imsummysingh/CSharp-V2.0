using System;

namespace P027_UnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //non-primitive value
            object obj = 10;

            //primitive value
            //unboxing
            int x = (int)obj;

            Console.WriteLine("Before UnBoxing: {0}", obj);
            Console.WriteLine("After UnBoxing: {0}", x);

            Console.ReadLine();
        }
    }
}
