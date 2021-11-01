using System;

namespace P023_MethodOverriding
{
    class Parent
    {
        public virtual void Print()
        {
            Console.WriteLine("Calling from parent");
        }
    }

    class Child : Parent
    {
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Calling from child by Overriding parent class method");
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
            p1.Print();     //calling from child            

            Console.ReadLine();
        }
    }
}
