//2️⃣ Create a base class Vehicle with properties Brand and Speed. 
//Derive a class Car from it and add a new property NumberOfDoors.Instantiate a Car object and set all properties.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_prectice {
    public class vehicle {
        public string brand { get; set; }
        public int speed { get; set; }

    }
    public class car : vehicle {
        public int numberofdoors { get; set; }

        public void display() {

            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Number of Doors: " + numberofdoors);
        }
    }

    internal class question2 {
        static void Main(string[] args) {
            car mycar = new car();
            mycar.brand = "Toyota";
            mycar.speed = 120;
            mycar.numberofdoors = 4;
            mycar.display();

        }
    }
}