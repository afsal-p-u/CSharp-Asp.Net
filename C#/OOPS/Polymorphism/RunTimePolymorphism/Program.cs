/*
    Polymorphism allows the same method name to perform different action depending on how it is used.
    There are two types of polymorphism,
    Compile time polymorphism and Run time polymorphism
*/

/*
    Run time polymorphism (method overriding).
    The method that runs is decided at runtime based on the actual object.
    The keyword virtual (method in the base class) used in the parent class and the keyword 
    override (method in the derived class) used in the derived class to override the method.
*/

using System;

class Dog
{
    public virtual int calc (int a, int b)
    {
        return a + b;
    }
}

class Cat: Dog
{
    public override int calc (int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string [] args)
    {
        Dog d = new Dog();
        Dog c = new Cat();
        Cat f = new Cat();
        Console.WriteLine(d.calc(10, 20));
        Console.WriteLine(c.calc(10, 30));
        Console.WriteLine(f.calc(10, 40));
        Console.ReadLine();
    }
}