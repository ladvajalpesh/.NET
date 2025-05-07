//Create an abstract class Shape with an abstract method CalculateArea().
//Inherit it in a class Rectangle and implement the method to calculate area of a rectangle.

using System;

namespace abstraction_prectice {
    abstract class Shape {
        public abstract double CalculateArea(); 
        public double Length { get; set; }
        public double Width { get; set; }

    }
    class Rectangle : Shape {
        public override double CalculateArea() {
            return Length * Width; 
        }

    }
    internal class Program {
        static void Main(string[] args) {
            Shape rectangle = new Rectangle();
            rectangle.Length = 5;
            rectangle.Width = 10;
            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());

        }
    }
}
