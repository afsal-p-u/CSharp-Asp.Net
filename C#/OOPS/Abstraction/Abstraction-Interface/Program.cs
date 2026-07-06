/* 
    Abstraction means hiding the implementation, showing only the necessary details.
    It lets users interact with an object without needing to know how it works internally.
    Abstraction achieved by using abstract class and interface
*/

// Abstraction using interface
/*
    Interface have constracts (defention not implementation), multiple inhertance acheived by 
    using interfaces. 
*/

using System;

interface Animal
{
    public void Sound();
}

class Cat: Animal
{
    public void Sound()
    {
        Console.WriteLine("cat sound");
    }
}

class Dog: Animal
{
    public void Sound()
    {
        Console.WriteLine("dog sound");
    }
}

class Adil: Cat
{
    public void MakeSound()
    {
        Console.WriteLine("Adil sound");
    }
}

class Program
{
    static void Main(String[] args)
    {
        Animal an = new Cat();
        an.Sound();

        Animal an1 = new Dog();
        an1.Sound();

        Adil ad = new Adil();
        ad.Sound();
        ad.MakeSound();
    }
}