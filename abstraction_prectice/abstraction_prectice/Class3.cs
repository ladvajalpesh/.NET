//Create an abstract class Vehicle with a non-abstract method StartEngine()and an abstract method Drive().
//Create a class Bike that implements the Drive() method and uses StartEngine().

using System;

namespace abstraction_prectice {
    abstract class Vehicle {
        public void startEngine() {
            Console.WriteLine("Engine started");
        }
        abstract public void drive();
    }
    class Bike : Vehicle {
        public override void drive() {
            Console.WriteLine("Bike is driving");
        }
    }

    internal class Class3 {
        static void Main(string[] args) {
            Vehicle vehicle = new Bike();
            vehicle.startEngine(); // Call non-abstract method
            vehicle.drive(); // Call abstract method
        }
    }
}
