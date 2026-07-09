/*
    Constructor is a special method that is automatically called when an object of a class is created.
    It is used to initialize the objects feild or properties.
*/

/*
    Copy Constructor.
    Create new object by copying another object.
*/

using System;

class Student
{
    public string Name;
    public int Age;

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Student(Student s)
    {
        Name = s.Name;
        Age = s.Age;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Afsal", 20);
        Student s1 = new Student(s);

        Console.WriteLine(s.Age);
        Console.WriteLine(s.Name);

        s1.Name = "Mesut";

        Console.WriteLine(s.Name);
        Console.WriteLine(s1.Name);

        // without copy constructor if s1 value changes it will affect original(s)
    }
}

