using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithConstructor
{
    public class Student
    {
        private int rollNo;
        public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                rollNo = value;
            }
        }

        public Student(int rollNo)
        {
            RollNo = rollNo;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student(147);
            Console.WriteLine($"Roll No: {obj.RollNo}");

            obj.RollNo = 123;
            Console.WriteLine($"Changed Roll No: {obj.RollNo}");
        }
    }
}
