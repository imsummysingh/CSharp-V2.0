using System;

namespace P007_DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Running even though condition is false");
                i++;
            } while (i < 0);

            Console.ReadKey();
        }
    }
}
