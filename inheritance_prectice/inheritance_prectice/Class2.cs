//Create a class Animal with a method MakeSound().
//Inherit it into a class Dog and override MakeSound() to print "Dog Barks".
//Create another class Cat that also overrides MakeSound() to print "Cat Meows"

using System;

namespace inheritance_prectice {
    public class Animal1 {
        public virtual void makesound() {
            Console.WriteLine("Animal makes a sound");
        }
    }
    public class dog1 : Animal1 {
        public override void makesound() {
            Console.WriteLine("dog barks");
        }
    }
    public class cat : Animal1 {
        public override void makesound() {
            Console.WriteLine("cat meows");
        }
    }

    internal class Class2 {
        static void Main(string[] args) {
            dog1 d = new dog1();
            d.makesound();
            cat c = new cat();
            c.makesound();
        }
    }
}
