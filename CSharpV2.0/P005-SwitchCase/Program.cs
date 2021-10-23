using System;

namespace P005_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            char gradeLetter='A';

            string gradeDescription;

            switch (gradeLetter)
            {
                case 'O': gradeDescription = "Outstanding";
                          break;
                case 'A': gradeDescription = "Excellent";
                          break;
                case 'B':
                    gradeDescription = "Good";
                    break;
                case 'C':
                    gradeDescription = "Average";
                    break;
                case 'F':
                    gradeDescription = "Failed";
                    break;
                default:
                    gradeDescription = "None";
                    break;
            }
            Console.WriteLine(gradeDescription);
            Console.ReadKey();
        }
    }
}
