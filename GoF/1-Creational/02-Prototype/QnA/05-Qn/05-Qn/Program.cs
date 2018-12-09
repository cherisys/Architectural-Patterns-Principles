using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Qn
{
    class Student
    {
        int RollNo;
        string Name;

        //Instance Constructor
        public Student(int rollno, string name)
        {
            this.RollNo = rollno;
            this.Name = name;
        }

        //Copy Constructor
        public Student(Student student)
        {
            this.RollNo = student.RollNo;
            this.Name = student.Name;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student Name: {0}, Roll No.: {1}", Name, RollNo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Calling instance constructor.
            Student s1 = new Student(1, "John");
            Console.WriteLine("Displaying Created Student Details.");
            s1.DisplayDetails();
            
            //Calling user-defined copy constructor.
            Student s2 = new Student(s1);
            Console.WriteLine("Displaying Copied Student Details.");
            s2.DisplayDetails();
            Console.Read();
        }
    }
}
