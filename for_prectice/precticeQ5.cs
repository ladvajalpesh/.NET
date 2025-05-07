//How does Abstraction work in C#?
//Create an abstract class Vehicle with an abstract method StartEngine(),
//and derive classes Car and Bike that implement it.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



// Abstract class
abstract class Vehicle
{
    // Abstract method (no implementation here)
    public abstract void StartEngine();

    // Non-abstract method (with implementation)
    public void DisplayInfo()
    {
        Console.WriteLine("This is a vehicle.");
    }
}

// Derived class Car
class Car : Vehicle
{
    
    // Implementing the abstract method
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started with a key!");
    }
}

// Derived class Bike
class Bike : Vehicle
{
    // Implementing the abstract method
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started with a kick!");
    }
}

// Main Class
class precticeQ5
{
    static void Main()
    {
        // Using Car
        Vehicle myCar = new Car();
        myCar.DisplayInfo();
        myCar.StartEngine();

        Console.WriteLine();

        // Using Bike
        Vehicle myBike = new Bike();
        myBike.DisplayInfo();
        myBike.StartEngine();
    }
}

