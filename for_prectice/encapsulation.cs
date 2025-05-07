using System;
//Explain Encapsulation in C#. Create a BankAccount class with
//private fields _balance and provide public methods Deposit() and Withdraw() to update the balance.
namespace for_prectice
{
    public class bank
    {
        private string account_type;
        private double balance;
        private double account_num;
       

        public bank() {
            account_type = "saving";
            balance = 50000;
            account_num = 142536789651;
            

        }

        public bank(double balance, double account_num, string account_type)
        {
            account_type = "bussness";
            balance = 500000;
            account_num = 145235261;
        }

        public void deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("diposit" + amount);

            }
            else
            {
                Console.WriteLine("invalid balance");
            }

        }
                public void withdwar(double amount)
        {
            if (amount > 0 && amount < balance)
            {
                balance -= amount;
                Console.WriteLine("withdwar succesfully" + amount);
            }
            else
            {
                Console.WriteLine("invelid withdwar plz! check your balance:");
            }
        }
        public void display()
        {
            Console.WriteLine(" account_type " + account_type + "\n" + "balance " + balance + "\n" + " account_num " + account_num  );
        }
    }
    class encapsulation
    {

        public static void Main(string[] arg)
        {
            bank mybank = new bank();
            mybank.deposit(10000);
            mybank.withdwar(500);
            mybank.display();

            bank mybank2 = new bank();
            mybank2.deposit(150000);
            mybank2.withdwar(50000);
            mybank2.display();
        }
    }
}
