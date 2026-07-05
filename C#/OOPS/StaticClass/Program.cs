using System;

static class Dog {

    private static string name;

    // constructor
    static Dog()
    {
        name = "Value assigned by constuctor";
        Console.WriteLine("constructor");
    }

    // properties
    public static string Name {get {return name;} set { name = value; } }

    // method
    public static void sound()
    {
        Console.WriteLine("sound method call");
    }

    // parameterized method
    public static int add(int a, int b)
    {
        return a+b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog.sound();
        Console.WriteLine(Dog.add(30,40));
        Console.WriteLine(Dog.Name);
        Console.WriteLine(Dog.Name = "Value assigned by property");
        Console.ReadKey();
    }
}