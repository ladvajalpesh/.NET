using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    public class bank
    {
        private string account_type;
        private double balance;
        public bank()
        {
            account_type = "bussines";
            balance = 500000;


        }

        public bank(string account_type, double balance)
        {
            account_type = "saving";
            balance = 5000;
        }
        public void deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("deposit" + amount);
            }
            else
            {
                Console.WriteLine("invelid amount");
            }

        }
        public void withdrow(double amount)
        {
            if (amount > 0 && amount < balance)
            {
                balance -= amount;
                Console.WriteLine("withdrow" + amount);
            }
            else
            {
                Console.WriteLine("invelid withdrow");
            }
        }
        public void display()
        {
            Console.WriteLine("account type" + account_type + " " + "balance" + balance);
        }
   
    public static void Main(string[] agrs)
        {
            bank saving = new bank("saving", 5000);
            saving.deposit(1000);
            saving.withdrow(500);
            saving.display();

            bank b = new bank("bussins", 100000);
            b.deposit(20000);
            b.withdrow(3000);
            b.display();

        }
    }
}