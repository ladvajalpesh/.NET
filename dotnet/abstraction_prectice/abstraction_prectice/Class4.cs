//Write a program where an abstract class Device has an abstract method Connect().
//Inherit it in two classes: Mouse and Keyboard. Each class should implement the Connect() method with a custom message.

using System;

namespace abstraction_prectice {
    abstract class Device {
        public abstract void Connect(); 
    }
    class Mouse : Device {
        public override void Connect() {
            Console.WriteLine("Mouse connected");
        }
    }
    class Keyboard : Device {
        public override void Connect() {
            Console.WriteLine("Keyboard connected");
        }
    }
    internal class Class4 {
        static void Main(string[] args) {
            Device mouse = new Mouse();
            mouse.Connect();
            Device keyboard = new Keyboard();
            keyboard.Connect();

        }
    }
}