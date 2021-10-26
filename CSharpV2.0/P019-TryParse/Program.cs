using System;

namespace P019_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter a Number");
            s = Console.ReadLine();

            //tryparse
            bool b = int.TryParse(s, out int n);

            if (b == true)
            {
                Console.WriteLine("Conversion is Successful");
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Conversion Failed");
            }

            Console.ReadLine();
        }
    }
}
