namespace solid_principles {
    internal class Program {

        static void Main(string[] args) {

            Customer order = new Customer();
            order.balance = 1000000;
            order.orderId = 1;
            order.orderName = "Laptop";
            order.orderPrice = 200000000;
            order.taxpercentage = 10;

            order.calculateOrder();


            // Create an instance of EmailOrder to call the non-static method
            EmailOrder obj = new EmailOrder();
            obj.sendEmail();

            //create third principle object
            Ishape obj1 = new rectangle();


            obj1 = new square();


        }
    }
}
