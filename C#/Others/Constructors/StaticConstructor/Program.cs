/*
    Constructor is a special method that is automatically called when an object of a class is created.
    It is used to initialize the objects feild or properties.
*/

/*
    Static Constructor.
    Used to initialize static members. It is called once before the first object is created
    or static member is accessed.
*/

class Database
{
    static Database()
    {
        Console.WriteLine("Static constructor");
    }

    public Database()
    {
        Console.WriteLine("Default constuctor");
    }
}

class Program
{
    static void Main()
    {
        Database d1 = new Database();
        Database d2 = new Database();
        Database d3 = new Database();
    }
}