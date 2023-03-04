using System.Runtime.CompilerServices;

namespace Valiasr;

public class Pre
{
    
}

class Car 
{
    string color;                 // field
    int maxSpeed;                 // field
    public void fullThrottle()    // method
    {
        Console.WriteLine("The car is going as fast as it can!"); 
    }

    static void s(string[] args)
    {
        Car myObj = new Car();
        myObj.fullThrottle();  // Call the method
    }
}

class Car2
{
    public string model;
    public string color;
    public int year;
    public void fullThrottle()
    {
        Console.WriteLine("The car is going as fast as it can!"); 
    }
}

// Create a Car class
class Car3
{
    public string model;  // Create a field

    // Create a class constructor for the Car class
    public Car3()
    {
        model = "Mustang"; // Set the initial value for model
    }

    static void s(string[] args)
    {
        Car3 Ford = new Car3();  // Create an object of the Car Class (this will call the constructor)
        Console.WriteLine(Ford.model);  // Print the value of model
    }
}

// Outputs "Mustang"

class Car4
{
    public string model;
    public string color;
    public int year;

    // Create a class constructor with multiple parameters
    public Car4(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
}

class Car5
{
    private string model = "Mustang";

    static void s(string[] args)
    {
        Car5 myObj = new Car5();
        Console.WriteLine(myObj.model);
        
    }

    void s2()
    {
        this.model = "reza";
    }
}

class Car6
{
    public string model = "Mustang";
}

class Program
{
    static void s(string[] args)
    {
        
        Car6 myObj = new Car6();
        Console.WriteLine(myObj.model);
    }
}