/*
    Encapsulation means wrapping data (fields) and methods (functions) together into single unit (class),
    and restrict direct access to it. It can access through methods or properties
*/

using System;

class BankAccount
{
    private double balance; // hidden field

    // add balance using property
    public double AddBalance { 
        get { return balance; } 
        set
        {
            if (value > 0) balance = value;
        }
    }

    // Add balance using method
    public void AddBalanceFn(double value)
    {
        if (value > 0) balance = value;
    }

    // show balance using method
    public double GetBalance() 
    {
        return balance;    
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount b = new BankAccount();

        // using property
        b.AddBalance = 1000; 
        Console.WriteLine(b.AddBalance);

        // using method
        b.AddBalanceFn(2000);
        Console.WriteLine(b.GetBalance());
    }
}