// Abstraction using interface

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