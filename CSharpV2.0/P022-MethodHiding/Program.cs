using System;

namespace P022_MethodHiding
{
    class Parent
    {
        public void Print()
        {
            Console.WriteLine("Calling from parent");
        }
    }
    class Child : Parent
    {
        public new void Print()
        {
            //base.Print();
            Console.WriteLine("Calling from child by hiding parent class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Print();  //calling from parent

            Child c = new Child();
            c.Print();  //calling from child

            Parent p1 = new Child();
            p1.Print();     //calling from parent

            //Child c1 = new Parent();
            //c1.Print();     //cannot implicityly convert- explicit conversion needed

            Console.ReadLine();
        }
    }
}
