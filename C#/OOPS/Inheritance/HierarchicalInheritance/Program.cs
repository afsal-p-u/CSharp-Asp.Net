/*
    One class (child,derived class) acquires properties and methods of another class (parent/base class) 
*/

/*
    Hierarchical inhertance.
    Multiple child classes inherit from the same parent class.
*/

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog: Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Puppy: Animal
{
    public void Weep()
    {
        Console.WriteLine("Puppy is weeping");
    }
}

class Program
{
    static void Main()
    {
        Puppy p = new Puppy();
        p.Eat();
        p.Weep();

        Dog d = new Dog();
        d.Eat();
        d.Bark();
    }
}

