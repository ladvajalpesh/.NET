//4️⃣ Create a class Shape with a method CalculateArea().
//Derive Rectangle and Circle from it. Implement CalculateArea() in both derived classes.


using System;

namespace inheritance_prectice {
    public class Shape {
        public double length { get; set; }
        public double width { get; set; }
        public virtual void calculateArea() {

            Console.WriteLine("Calculating area...");
        }

    }
    public class Rectangle : Shape {
        public override void calculateArea() {
            double area = length * width;
            Console.WriteLine("Area of Rectangle: " + area);
        }

    }
    public class Circle : Shape {
        public double radius { get; set; }

        public override void calculateArea() {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }

    }
    internal class question4 {
        static void Main(string[] args) {
            Rectangle rect = new Rectangle();
            rect.length = 5;
            rect.width = 10;
            rect.calculateArea();

            Circle circle = new Circle();
            circle.radius = 7;
            circle.calculateArea();

        }
    }
}
