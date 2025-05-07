using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Q1). What are Classes and Objects in C#? Create a class called Car with propertie
//like Brand, Model, and Year. Instantiate an object and display its details.
namespace for_prectice
{
    public class car
    {
        string model;
        String brand;
        int years;

        public car(string model, string brand, int years)
        {
            this.model = model;
            this.brand = brand;
            this.years = years;
        }

        public void display()
        {
            Console.WriteLine(" model " + model +"\n"+ " brand " +  brand +"\n"+ " years " + years);
            Console.ReadLine();
        }
        class clobj
        {
            static void Main(string[] args)
            {
                car mycar = new car("m5 cs", "bmw", 1990);
                mycar.display();

            }
        }
    }
}
