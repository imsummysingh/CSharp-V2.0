using System;

namespace P011_FieldsClassLibrary
{
    public class Product
    {
        public int pdtId;
        public string pdtName;
        public double pdtCost;
        public int pdtQuantity;
        public static int TotalNoofProducts;    //default value is 0
        public const string pdtCategory = "Electronics";

        public readonly string dateOfPurchase;

        public Product()
        {
            dateOfPurchase = DateTime.Now.ToShortDateString();
        }
    }
}
