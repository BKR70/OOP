using System;
class Person {
    private int age;
    private string name;
    public int Age {              // Property or indexer cannot have void type.
        get{return age;}
        set {
            if(value > 17) {         
                age = value;
            }
        }

        //set{age = value;}   
    }
    public string Name {
        get{return name;}
        set{name = value;}    
        
        // or               
        // get; set;             // This can only be done when there is absolutely no customization.
    }
}
class Test {
    public static void Main(string[] args) {
        Person p1 = new Person();
        p1.Age = 14;
        p1.Name = "Bilas Kumar";
        Console.WriteLine($"Name : {p1.Name}. \nAge : {p1.Age}");
    }
}