/*
    Constructor is a special method that is automatically called when an object of a class is created.
    It is used to initialize the objects feild or properties.
*/

/*
    Constructor Overloading.
    A class can have multiple constructors with different parameter lists.
*/

using System;

class Language
{
    public Language()
    {
        Console.WriteLine("Hindi");
    }

    public Language(string lang)
    {
        Console.WriteLine(lang);
    }

    public Language(string lang, string country)
    {
        Console.WriteLine($"{country} - {lang}");
    }
}

class Program
{
    static void Main()
    {
        Language l = new Language();
        Language l1 = new Language("English");
        Language l2 = new Language("Portugese", "Portugal");
    }
}