using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Implemented_Property
{
    public class Student
    {
        public string Name { get; set; } = "GFG";            // Auto-implemented property
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("Name: " + s.Name);

            // Changing property value

            s.Name = "Geeky";
            Console.WriteLine("Changed Name: " + s.Name);
        }
    }
}
