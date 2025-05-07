using System;

//5️⃣ Implement multilevel inheritance: LivingBeing → Animal → Dog.
//Add appropriate methods in each class and call them using a Dog object.



namespace inheritance_prectice {
    public class livingBeing {
        public void breathe() {
            Console.WriteLine("Breathing...");
        }
    }
    public class animal : livingBeing {
        public void eat() {
            Console.WriteLine("Eating...");
        }
    }
    public class dog : animal {
        public void bark() {
            Console.WriteLine("Barking...");
        }
    }
    internal class question5 {
        public static void Main(string[] args) {
            animal a = new animal();
            a.breathe();
            a.eat();

            dog d = new dog();
            d.breathe();
            d.eat();
            d.bark();
            Console.Read();
        }

    }
}
