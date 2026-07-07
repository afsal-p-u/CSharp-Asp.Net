/*
    one class (child,derived class) acquires properties and methods of another class (parent/base class) 
*/

/*
    Single inhertance.
    One single class inherits from one parent class.
*/

using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
        d.Bark();
    }
}
