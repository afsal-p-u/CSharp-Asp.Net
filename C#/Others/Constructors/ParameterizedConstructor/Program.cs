/*
    Constructor is a special method that is automatically called when an object of a class is created.
    It is used to initialize the objects feild or properties.
*/

/*
    Parameterized Constructor.
    A constructor that accept parameter to initialize an object.
*/

using System;

class Calculation
{
    public int balance;

    public Calculation(int value)
    {
        balance = value;
    }
}

class Program
{
    static void Main()
    {
        Calculation c = new Calculation(400);
        Console.WriteLine(c.balance);
    }
}