using System;

namespace solid_principles {

    // first_principle -- single responsibility principle
    public class Order {
        public int orderId { get; set; }
        public string orderName { get; set; }
        public double orderPrice { get; set; }
        public double taxpercentage { get; set; }

        public void calculateOrder() {

            double totalamount = orderPrice + (orderPrice * taxpercentage / 100);
            Console.WriteLine(totalamount);
        }
    }
    public class EmailOrder {
        public string Email { get; set; } = "custemor123@gmail.com";

        public void sendEmail() {
            Console.WriteLine($"Email sent to {Email} with order details");
        }
    }
    //second_principle -- open to extension and closed to modification
    public class Customer : Order { // create new class name is customer
        public double balance { get; set; }


    }

    //third_principle -- liskov substitution principle
    public interface Ishape {

    }
    public class rectangle : Ishape {
        public double height { get; set; }
        public double width { get; set; }
        public void Getarea() {
            Console.WriteLine($"Area of rectangle is {height * width}");
        }

    }
    public class square : Ishape {
        public double height { get; set; }
        public double width { get; set; }
        public void Getarea() {
            Console.WriteLine($"Area of square is {height * height}");
        }
    }

}


