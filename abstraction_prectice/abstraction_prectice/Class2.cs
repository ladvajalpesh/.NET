//Create an abstract class Account with an abstract method CalculateInterest().
//Inherit it in SavingsAccount and CurrentAccount classes and implement different interest logics.

using System;

namespace abstraction_prectice {
    abstract class Account {
        public abstract double CalculateInterest(); // Abstract method to calculate interest
        public double Balance { get; set; }
    }
    class Savingaccount : Account {
        public override double CalculateInterest() {
            return Balance * 0.05; // Example interest calculation for savings account
        }

    }
    class Currentaccount : Account {
        public override double CalculateInterest() {
            return Balance * 0.03; // Example interest calculation for current account
        }
    }
    internal class Class2 {
        static void Main(string[] args) {
            Account account = new Savingaccount();
            account.Balance = 1000;
            Console.WriteLine("Interest for Savings Account: " + account.CalculateInterest());
            Account account2 = new Currentaccount();
            account2.Balance = 5000;
            Console.WriteLine("Interest for Current Account: " + account2.CalculateInterest());
        }

    }
}
