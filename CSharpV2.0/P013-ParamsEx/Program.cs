using System;

namespace P013_ParamsEx
{
    class Student
    {
        public void DisplaySubjects(params string[] subjects)
        {
            for(int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i]);
            }

            //Console.WriteLine(subjects[0]);
            //Console.WriteLine(subjects[1]);
            //Console.WriteLine(subjects[2]);
            //Console.WriteLine(subjects[3]);
            //Console.WriteLine(subjects[4]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.DisplaySubjects("C", "C++", "C#");
            s.DisplaySubjects("TOC", "CN", "DBMS", "Maths3", "OS");

            Console.ReadKey();
        }
    }
}
