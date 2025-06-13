using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProperty
{
    public class Person
    {
        private int age;
        private string name;
        public int Age
        {              // Property or indexer cannot have void type.
            get { return age; }
            set
            {
                if (value > 17)
                {
                    age = value;
                }
            }

            //set{age = value;}   
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

            // or               
            // get; set;             // This can only be done when there is absolutely no customization.
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 14;
            p1.Name = "Bilas Kumar";
            Console.WriteLine($"Name : {p1.Name}. \nAge : {p1.Age}");
        }
    }
}
