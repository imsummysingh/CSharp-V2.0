using System;

namespace P012_RefReturn
{
    class Student
    {
        public int grade = 2;

        public void PrintGrade()
        {
            Console.WriteLine("Grade: {0}", grade);
        }

        public ref int DoWork()
        {
            return ref grade;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.PrintGrade();

            ref int g = ref s.DoWork();

            //update the ref return
            g = 5;

            //call print grade after updating value of 'ref return'
            s.PrintGrade();

            Console.ReadLine();
        }
    }
}
