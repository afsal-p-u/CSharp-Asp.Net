/*
    A class is a blueprint or template for creating objects, while an object is an instance of a class. 
    A class defines the properties (data) and methods (behavior) that objects will have. 
    An object is created from a class using the new keyword.
*/

using System;

class Car {
    public string name = "Beta";
    public string year;
    public string company { get; set; }
    public string country;

    //properties
    public string CountryManufactured { get { return country; } set { country = value; }}

    //methods
    public string latestModel() {
        return "Alhpa";
    }
}

class Program {
    static void Main(string[] args) {
        Car car = new Car();

        Console.WriteLine(car.name);
        car.company = "TATA Motors";
        Console.WriteLine(car.company);
        car.year = "2002";
        Console.WriteLine(car.year);

        //method
        Console.WriteLine(car.latestModel());

        // properties
        car.CountryManufactured = "India";
        Console.WriteLine(car.CountryManufactured);
        //Console.ReadLine();
    }
}