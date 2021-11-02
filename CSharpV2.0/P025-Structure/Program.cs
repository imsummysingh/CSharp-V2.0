using System;

namespace P025_Structure
{
    struct Students
    {
        private int _rollno;
        private string _fname;
        private string _lname;

        public int RollNo
        {
            set
            {
                _rollno = value;
            }
            get
            {
                return _rollno;
            }
        }

        public string fName
        {
            set
            {
                _fname = value;
            }
            get
            {
                return _fname;
            }
        }

        public string lName
        {
            set
            {
                _lname = value;
            }
            get
            {
                return _lname;
            }
        }

        public string GetFullName()
        {
            return fName + lName;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating structure instance
            Students s = new Students();
            //Students s;

            s.RollNo = 101;
            s.fName = "Summy";
            s.lName = "Singh";

            Console.WriteLine("Roll No: {0}",s.RollNo);
            Console.WriteLine("First Name: {0} & Last Name: {1}",s.fName,s.lName);
            Console.WriteLine("Full Name: {0}", s.GetFullName());

            Console.ReadLine();
        }
    }
}
