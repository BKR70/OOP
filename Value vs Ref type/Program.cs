using System;
class Person {
    public string name; 
    public int age;
    public Person(string n,int ag) {

        //Console.WriteLine("Default Constructor is called");
        name = n; age = ag;
    }
}
class Test {
    public static void Main(string[] args) {

        Person p1 = new Person("Bilas",25);
        Console.WriteLine($"Before refering P1.name is {p1.name}, P1.age is {p1.age}.");
        Console.WriteLine();

        Person p2 = p1;
        p2.name = "Virat Kohli";
        p2.age = 29;

        Console.WriteLine($"P2.name is {p2.name}, P2.age is {p2.age}.");
        Console.WriteLine($"After refering P1.name is {p1.name}, P1.age is {p1.age}.");

        Console.ReadKey();
    }
}