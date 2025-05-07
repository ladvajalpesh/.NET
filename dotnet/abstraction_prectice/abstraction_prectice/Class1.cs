//Create an abstract class Animal with an abstract method MakeSound().
//Inherit it in two classes: Dog and Cat. Each class should print a different sound message.

using System;

namespace abstraction_prectice {

    abstract class Animal {
        public abstract void MakeSound(); // Abstract method to make sound

    }
    class Dog : Animal {
        public override void MakeSound() {
            Console.WriteLine("Dog barks");
        }
    }
    class Cat : Animal {
        public override void MakeSound() {
            Console.WriteLine("Cat meows");
        }
    }

    internal class Class1 {
        static void Main(string[] args) {
            Animal dog = new Dog();
            dog.MakeSound();
            Animal cat = new Cat();
            cat.MakeSound();
        }
    }
}
