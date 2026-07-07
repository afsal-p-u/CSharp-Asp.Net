/*
    One class (child,derived class) acquires properties and methods of another class (parent/base class) 
*/

/*
    Multiple inhertance.
    Derived class inherits from one base class. then anther class derived from the derived class.
    A class inherits from another derived class.
*/

using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog: Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Puppy: Dog
{
    public void Weep()
    {
        Console.WriteLine("Puppy is weeping");
    }
}

class Program
{
    static void Main()
    {
        Puppy p = new Puppy();
        p.Eat();
        p.Bark();
        p.Weep();
    }
}