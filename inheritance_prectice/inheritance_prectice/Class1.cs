//Create a class Vehicle with a method Start().
//Inherit this class into a new class Car and override the Start()
//method to print a custom message. Call the method using an object of Car.

using System;

namespace inheritance_prectice {
    public class vehicle1 {
        public virtual void Start() {
            Console.WriteLine("Vehicle is starting");
        }
    }
    public class newcar : vehicle1 {
        public override void Start() {
            Console.WriteLine("Car is starting with a custom message");
        }
    }

    internal class Class1 {
        static void Main(string[] args) {
            newcar car = new newcar();
            car.Start();
        }
    }
}
