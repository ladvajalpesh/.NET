//3️⃣ Create a base class Person with a method ShowDetails() that prints Name and Age.
//Derive a class Student that adds a Grade property. Override ShowDetails() to include Grade.

using System;

namespace inheritance_prectice {
    public class Person1 {
        public string name { get; set; }
        public int age { get; set; }

        public virtual void showdetails() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("age" + age);

        }
    }
    public class Student : Person1 {
        public string grade { get; set; }
        public override void showdetails() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade: " + grade);
        }
    }
    internal class question3 {
        static void Main(string[] args) {
            Student student = new Student();
            student.name = "mahesh";
            student.age = 20;
            student.grade = "A";
            student.showdetails();

            Console.Read();
        }
    }
}

