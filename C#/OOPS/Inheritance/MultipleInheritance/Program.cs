/*
    One class (child,derived class) acquires properties and methods of another class (parent/base class) 
*/

/* 
    Multiple inheritance achieved by using interface
*/

using System;

interface Dog
{
    void Sleeping();
}

interface Cat
{
    void Eating();
}

class Animal : Cat, Dog
{
    public void Sleeping()
    {
        Console.WriteLine("Sleeping");
    }

    public void Eating()
    {
        Console.WriteLine("Eating");
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Animal();
        a.Eating();
        a.Sleeping();
    }
}