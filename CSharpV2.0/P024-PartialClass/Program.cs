using P024_PartialClassLibrary;
using System;

namespace P024_PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object of partial class
            Product p = new Product();

            //access properties
            p.ProductId = 101;
            p.Cost = 10000;
            Console.WriteLine("Tax on the product is: {0}", p.GetTax());

            Console.ReadLine();
        }
    }
}
