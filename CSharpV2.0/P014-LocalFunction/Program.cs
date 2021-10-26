using System;

namespace P014_LocalFunction
{
    class Student
    {
        public void DisplayMarks(int marks1, int marks2, int marks3)
        {
            double avgMarks = getAverageMarks();
            double getAverageMarks()
            {
                double avg;
                avg = (double)(marks1 + marks2 + marks3) / 3;
                return avg;
            }
            Console.WriteLine("Marks1: {0}", marks1);
            Console.WriteLine("Marks2: {0}", marks2);
            Console.WriteLine("Marks3: {0}", marks3);

            Console.WriteLine("Average Marks: {0}", avgMarks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.DisplayMarks(90, 93, 96);
            Console.ReadLine();
        }
    }
}
