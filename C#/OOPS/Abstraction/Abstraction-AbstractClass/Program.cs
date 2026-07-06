/* 
    Abstraction means hiding the implementation, showing only the necessary details.
    It lets users interact with an object without needing to know how it works internally.
    Abstraction achieved by using abstract class and interface
*/

// Abstraction using abstract class
/* 
    Abstract class can have abstract and non abstract methods, it can have constructors.
    the abstract method defined by using abstract keyword and it is override in the derived
    class by using override keyword
*/

using System;

abstract class Animal
{
    public Animal()
    {
        Console.WriteLine("Zebra");
    }

    public abstract void MakeSound();

    public void Sound()
    {
        Console.WriteLine("Zebra sound");
    }
}

class Dog: Animal
{
    public Dog()
    {
        Console.WriteLine("Dog");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Dog sound");
    }
}

class Cat: Animal
{
    public Cat()
    {
        Console.WriteLine("Cat");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Cat sound");
    }
}

class Program {
    static void Main(String[] args)
    {
        Animal an = new Dog();
        an.MakeSound();
        an.Sound();

        Animal an1 = new Cat();
        an1.MakeSound();
        an1.Sound();
    }
}