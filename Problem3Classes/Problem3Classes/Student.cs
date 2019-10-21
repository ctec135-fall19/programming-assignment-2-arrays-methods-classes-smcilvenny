using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Classes
{
    class Student
    {
        private string studentName;
        private string v;

        public string GetName() { return studentName; }

        public int StudentId
        {
            get { return StudentId; }
            set
            {
                if (StudentId > 100000 && StudentId < 99999) { StudentId = value; }
                else Console.WriteLine("Student ID is invalid");
            }
        }

        public double gpa { get; set; }

        public Student(string name, int id, double gpavg)
        {
            studentName = name;
            StudentId = id;
            gpa = gpavg;

        }

        //public Student(string v) : this("none", 0, 0.0) { }
        public Student(string name, int id) : this(name, 100001, 0.0) { }

        public Student(string v)
        {
            this.v = v;
        }

        public void PrintState()
        {
            Console.WriteLine("Name: {0}", studentName);
            Console.WriteLine("ID: {0}", StudentId);
            Console.WriteLine("GPA: {0}", gpa);
        }
        
    }
}
