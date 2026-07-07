/*
    A partial class allows you to split definition of a single class accross multiple files.
    At compile time, the c# compiler combines all the parts into one complete class.
    A partial class can have constructors.
    A partial class can have multiple constructors, 
    as long as each has a different parameter list (constructor overloading).
    a partial class can have partial methods
*/

// 1
partial class Employee
{
    public string Name;

    // constructor
    public Employee()
    {
        Name = "afsal";
    }

    // partial class
    public partial void Logs();
}

partial class Employee
{
    public void Display()
    {
        Console.WriteLine(Name);
    }

    // constructor with different parameter
    public Employee(string name)
    {
        Name = Name;
    }

    // partial class
    public partial void Logs()
    {
        Console.WriteLine("Logs");
    }
}

// 2
partial class Product
{
    public int Id { get; set; }
    public string Username { get; set; }
}

partial class Product
{
    public void Show()
    {
        Console.WriteLine($"{Id} - {Username}");
    }
}

class Program
{
    static void Main()
    {
        // 1
        Employee n = new Employee();
        n.Display();

        // 2
        Product p = new Product();
        p.Id = 1;
        p.Username = "Afsal";

        p.Show();

        // partial clss
        n.Logs();
    }
}