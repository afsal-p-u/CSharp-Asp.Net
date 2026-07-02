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