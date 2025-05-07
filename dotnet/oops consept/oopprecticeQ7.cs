using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using oops_consept;
// Q1) Create a class called Car with properties
//like Brand, Model, and Year. Instantiate an object and display its details
namespace oops_consept
{
    public class car
    {
        private readonly string modal;
        public string brand;
        public string model;
        public int year;

        public car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public void display()
        {
            Console.WriteLine("Brand: " + brand + "model: " + modal + "Year" + year);
        }


        internal class oopprecticeQ7
        {
            public static void Main(string[] args)
            {
                car mycar = new car("bmw", "m4 csl", 1999);
                mycar.display();
            }
        }
    }
}
