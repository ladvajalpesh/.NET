using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    public class vihical
    {
        public string brand;
        public string color;
    }
    public class car : vihical
    {
        public int speed = 300;

    }
    public class bike : vihical
    {
        public int speed = 200;
    }
    public class inheritance
    {
        public static void Main(string[] args) {

            car mycar = new car();
            mycar.brand = "toyota";
            mycar.color = "red";
       
            Console.WriteLine(" brand :- " + mycar.brand + "\n"+" color :- " + mycar.color+" \n Speed="+mycar.speed);


            bike mybike = new bike();
            mybike.brand = "honda";
            mybike.color = "black";
    
            Console.WriteLine(" brand :-  " + mybike.brand  + "\n"+" color :- " +  mybike.color + "\n Speed= " +mybike.speed);

        }
    }
}
