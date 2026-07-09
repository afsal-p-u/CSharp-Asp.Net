/*
    Constructor is a special method that is automatically called when an object of a class is created.
    It is used to initialize the objects feild or properties.
*/

/*
    Default Constructor.
    Constructor with no parameters.
*/

using System;

class Animal
{
    public Animal()
    {
        Console.WriteLine("Constructor");
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Animal();
    }
}