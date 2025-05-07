
//Create a class Employee with a method DisplayDetails().
//Create a derived class Manager that adds a new method DisplayManagerDetails().
//Create an object of Manager and call both methods.
using System;

namespace inheritance_prectice {
    public class employee {
        public void DisplayDetails() {
            Console.WriteLine("Employee details");
        }
    }
    public class manager : employee {
        public void displaymanagerdetails() {
            Console.WriteLine("Manager details");
        }
    }
    internal class Class4 {
        static void Main(string[] args) {
            manager m = new manager();
            m.DisplayDetails();
            m.displaymanagerdetails();
        }
    }
}
