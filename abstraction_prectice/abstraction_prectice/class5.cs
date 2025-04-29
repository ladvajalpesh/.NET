using System;

namespace abstraction_prectice {

    public class Employee {
        public int Emp_id { get; set; }
        public string Emp_name { get; set; }
        public double grosspay { get; set; }
        double taxdeduction = 0.1; // 10%
        double netsalary;

        public Employee(int emp_id, string emp_name, double grosspay) {
            Emp_id = emp_id;
            Emp_name = emp_name;
            this.grosspay = grosspay;
        }
        void calculate() {
            if (grosspay >= 30000) {
                netsalary = grosspay - (grosspay * taxdeduction);

                Console.WriteLine($"Net Salary of {Emp_name} is {netsalary}");
            }
            else {
                Console.WriteLine($"Net Salary of {Emp_name} is {grosspay}");
            }
        }
        public void showEmployeeDetails() {
            this.calculate();
        }
    }
    internal class class5 {
        public static void Main(string[] args) {
            Employee emp = new Employee(1, "John Doe", 35000);
            emp.showEmployeeDetails();
            Console.Read();
        }
    }
}


