using P011_FieldsClassLibrary;
using System;

namespace P011_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pd1 = new Product();
            Product.TotalNoofProducts++;
            Product pd2 = new Product();
            Product.TotalNoofProducts++;

            pd1.pdtId = 101;
            pd1.pdtName = "Hp Laptop";
            pd1.pdtCost = 95000;
            pd1.pdtQuantity = 1;

            pd2.pdtId = 102;
            pd2.pdtName = "Thinkpad Laptop";
            pd2.pdtCost = 65000;
            pd2.pdtQuantity = 20;

            Console.WriteLine("ProductId: {0}, ProductNAme: {1}, ProductCost: {2}, ProductQuantity: {3}, PurchaseDate: {4}", pd1.pdtId, pd1.pdtName, pd1.pdtCost, pd1.pdtQuantity, pd1.dateOfPurchase);

            Console.WriteLine("ProductId: {0}, ProductNAme: {1}, ProductCost: {2}, ProductQuantity: {3}, PurchaseDate: {4}", pd2.pdtId, pd2.pdtName, pd2.pdtCost, pd2.pdtQuantity, pd2.dateOfPurchase);

            Console.WriteLine("Static Field Value: {0}", Product.TotalNoofProducts);

            Console.WriteLine("Product Category :{0}", Product.pdtCategory);

            Console.ReadKey();
        }
    }
}
