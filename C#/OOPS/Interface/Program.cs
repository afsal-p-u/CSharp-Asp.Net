using System;

interface IMethod1
{
    int sub(int a, int b);    
}

interface IMethod
{
    int add(int a, int b);

    int mul(int a, int b);
}

class Calc: IMethod, IMethod1
{
    public int add(int a, int b)
    {
        return a + b;
    }

    public int mul(int a, int b)
    {
        return a * b;
    }

    public int div(int a, int b)
    {
        return a / b;
    }

    public int sub(int a, int b)
    {
        return a - b;
    }
}

class Calc1 : IMethod
{
    public int add(int a, int b)
    {
        return a + b;
    }

    public int mul(int a, int b)
    {
        return a * b;
    }
}

class Calc2 : IMethod1
{
    public int sub(int a, int b)
    {
        return a - b;
    }
}

class Program {
    static void Main(string[] args)
    {
        Calc c = new Calc();

        Console.WriteLine(c.add(10,30));
        Console.WriteLine(c.mul(20,30));
        Console.WriteLine(c.div(20,30));
        Console.WriteLine(c.sub(40,30));

        IMethod i = new Calc();
        Console.WriteLine(i.add(10,30));
        Console.WriteLine(i.mul(10,30));

        IMethod i2 = new Calc1();
        Console.WriteLine(i2.add(20,40));
        Console.WriteLine(i2.mul(20,40));
        
        IMethod1 i1 = new Calc2();
        Console.WriteLine(i1.sub(30,10));
    }
}