/*
    Constructor is a special method that is automatically called when an object of a class is created.
    It is used to initialize the objects feild or properties.
*/

/*
    Private Constructor.
    Prevents objects from being created outside the class. commonly used in the singleton pattern or
    utility classes
*/

class Utility
{
    public static string name;

    private Utility()
    {
    }

    public static void show()
    {
        Console.WriteLine("Static Method");
    }
}

class Program
{
    static void Main()
    {
        Utility.show();
        Console.WriteLine(Utility.name);
    }
}
