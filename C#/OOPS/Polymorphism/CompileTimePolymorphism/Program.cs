/*
    Polymorphism allows the same method name to perform different action depending on how it is used.
    There are two types of polymorphism,
    Compile time polymorphism and Run time polymorphism
*/

/*
    Compile time polymorphism (method overloading).
    Method have a same name and different parameters.
    You can overload method by changing the number of parameters.
    The compiler decides which method to call based on the arguments passed.
*/

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
