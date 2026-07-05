using System;

public delegate int Oper(int a, int b);
public delegate void MyMethod(string s);
public delegate void Notify();

class Calculation
{
    public int add(int a, int b)
    {
        return a + b;
    }

    public int mul(int a, int b)
    {
        return a * b;
    }

    public void method1(string a)
    {
        Console.WriteLine(a);
    }

    public void Whatsapp()
    {
        Console.WriteLine("Whatsapp");
    }

    public void Facebook()
    {
        Console.WriteLine("Facebook");
    }
}

class Progarm
{
    static void Main(string [] args)
    {
        Calculation c = new Calculation();
        Oper d = c.add;

        Console.WriteLine(d(10,30));

        d = c.mul;
        Console.WriteLine(d(30, 40));

        MyMethod m = c.method1;
        m("Hello Afsal");

        Notify n = c.Whatsapp;
        n();
        n += c.Facebook;
        n();

        //Built in delegates
        // return void
        Action<string> print = Console.WriteLine;
        print("Hello");

        // return value
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(10,30));

        // return bool
        Predicate<int> isEven = x => x % 2 == 0;
        Console.WriteLine(isEven(7));
    }
}