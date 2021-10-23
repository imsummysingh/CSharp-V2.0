using System;

namespace P004_NestedIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks = 70;
            char gradeLetter;

            if (marks >= 85)
            {
                gradeLetter = 'O';
            }
            else if(marks>=60 && marks < 85)
            {
                gradeLetter = 'A';
            }
            else if(marks>=50 && marks < 60)
            {
                gradeLetter = 'B';
            }
            else if(marks>=35 && marks < 50)
            {
                gradeLetter = 'C';
            }
            else
            {
                gradeLetter = 'F';
            }

            Console.WriteLine(gradeLetter);
            Console.ReadKey();
        }
    }
}
