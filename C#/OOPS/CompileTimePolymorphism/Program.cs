// method overloading

using System;

class Calc
{
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Calc c = new Calc();
        Console.WriteLine(c.Add(10,30));
        Console.WriteLine(c.Add(30, 40, 50));

        Console.ReadKey();
    }
}
