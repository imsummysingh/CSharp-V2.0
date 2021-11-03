using P028_ExtensionMethodLibrary;
using System;

namespace P028_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing object using object initializer
            Product p = new Product() { ProductCost = 1000, DiscountPercentage = 10 };
            //p.GetDiscount();
            Console.WriteLine("Product Cost: {0}", p.ProductCost);
            Console.WriteLine("Product Discount: {0}", p.DiscountPercentage);

            Console.WriteLine("Using Extenstion method for GetDiscount");

            Console.WriteLine("Product Discount:{0}", p.GetDiscount());

            Console.ReadLine();
        }
    }
}
