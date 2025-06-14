/*
  Encapsulation is a process of
     01. packaging variables and methods into a single unit.
     02. protecting data by declaring them as private.
*/

using System;

namespace Encaps
{
    public class Student
    {
        private String studentName;
        private int studentAge;
        public String StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int StudentAge
        {
            get { return studentAge; }
            set { studentAge = value; }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.StudentName = "Bilas";
            obj.StudentAge = 25;

            Console.WriteLine(" Name: " + obj.StudentName);
            Console.WriteLine(" Age: " + obj.StudentAge);
        }
    }
}
