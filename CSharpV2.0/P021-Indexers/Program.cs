using P021_IndexersLibrary;
using System;

namespace P021_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            //call get accessor
            Console.WriteLine(c[0]);
            Console.WriteLine(c["first"]);

            //call set accessor
            c[0] = "TESLA";
            Console.WriteLine("After modifier 0 index: {0}", c[0]);

            Console.ReadKey();
        }
    }
}
