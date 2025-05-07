//Create a base class called Person with properties Name and Age.
//Create a derived class Student that adds a property RollNumber.
//Create an object of Student and print all details.
using System;
namespace inheritance_prectice {
    public class Person {
        public string Name;
        public int Age;
    }
    public class student : Person {
        public int RollNumber;

        public void showdetails() {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Roll Number: " + RollNumber);
        }

    }
    internal class personandstudent {
        static void Main(string[] args) {
            student s = new student();
            s.Name = "John Doe";
            s.Age = 20;
            s.RollNumber = 12345;
            s.showdetails();


            Console.ReadLine();
        }

    }
}
