using System;

namespace access_specifiers {
    public class A {
        public string name;
        protected string address;
        private string phone;
        internal string email;
        protected internal string ssn;
        private protected string bankAccount;

        public void Display() {
            Console.WriteLine($"public Name: {name}");
            Console.WriteLine($"protected Address: {address}");
            Console.WriteLine($"private Phone: {phone}");
            Console.WriteLine($"internal Email: {email}");
            Console.WriteLine($"protected internal SSN: {ssn}");
            Console.WriteLine($"private protected Bank Account: {bankAccount}");
        }
    }
    public class B : A {
        public void Show() {
            Console.WriteLine($"public Name: {name}");
            Console.WriteLine($"protected Address: {address}");
            Console.WriteLine($"private Phone: {phone}"); // not accessible
            Console.WriteLine($"internal Email: {email}");
            Console.WriteLine($"protected internal SSN: {ssn}");
            Console.WriteLine($"private protected Bank Account: {bankAccount}"); // not accessible
        }
    }
    public class C {
        public void Show() {
            A a = new A();
            Console.WriteLine($"public Name: {a.name}");
            Console.WriteLine($"protected Address: {a.address}"); // Not accessible
            Console.WriteLine($"private Phone: {a.phone}"); // Not accessible
            Console.WriteLine($"internal Email: {a.email}");
            Console.WriteLine($"protected internal SSN: {a.ssn}"); // Not accessible
            Console.WriteLine($"private protected Bank Account: {a.bankAccount}"); // Not accessible
        }
    }

    internal class Program {
        static void Main(string[] args) {
            B b = new B();
            b.name = "John Doe";
            b.address = "123 Main St"; // Accessible
            b.phone = "123-456-7890"; // Not accessible
            b.ssn = "123-45-6789"; // Accessible
                                   //  b.bankAccount = "123456789"; // Accessible

        }
    }
}
