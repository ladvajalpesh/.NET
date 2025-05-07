using System;

namespace access_specifiers {
    public class Bank {
        public static string bankname;
        public double account_NO;
        public string address;

        public void display() {
            Console.WriteLine("Bank Name: " + bankname);
            Console.WriteLine("Account Number: " + account_NO);
            Console.WriteLine("Address: " + address);
        }
    }

    internal class statickeyword {
        static void Main(string[] args) {
            Bank b = new Bank();
            Bank.bankname = "Bank of baroda";
            b.account_NO = 123456;
            b.address = "123 Main St";
            b.display();

            b.account_NO = 5486996568;
            b.address = "padra main raod vadodara";
            b.display();

            b.account_NO = 45213689;
            b.address = "sardar patel nagar vadodara";

            b.display();


            Console.Read();
        }
    }
}
