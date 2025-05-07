////Create a BankAccount class
//The class should have private variables for balance.
//Create Deposit() and Withdraw() methods to modify the balance.
//Use GetBalance() to return the current balance.

using System;

namespace encapsulation_prectice {
    internal class bankprogram {
        public class bankaccount {
            private double balance;
            private string account_type;

            public bankaccount(Double balance, string account_type) {
                this.balance = balance;
                this.account_type = account_type;


            }
            public void deposit(double amount) {
                if (amount > 0) {
                    balance += amount;
                    Console.WriteLine("Amount deposited successfully");
                }
                else {
                    Console.WriteLine("Amount should be greater than 0");
                }
                Console.WriteLine("after deposit your balance is:-", balance);
            }
            public void withdraw(double amount) {
                if (balance >= 0) {
                    balance -= amount;
                    Console.WriteLine("Amount withdraw successfully");
                }
                else {
                    Console.WriteLine("your balance is not avelable ");
                }
            }
            public void display() {
                Console.WriteLine("balance:-  " + balance + "\n" + "account_type:- " + account_type);
            }
        }
        static void Main(string[] args) {
            bankaccount b = new bankaccount(50000, "saving");
            b.deposit(1000);
            b.withdraw(500);
            b.display();

        }
    }
}
