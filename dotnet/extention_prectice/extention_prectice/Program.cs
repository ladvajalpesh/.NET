using myclasslib;
namespace extention_prectice {

    public static class Myclass {
        public static void newMethod(this Class1 class1) {
            Console.WriteLine("Hello this is method 1 from extention_prectice");
        }
        public static void newMethod2(this Class1 class1) {
            Console.WriteLine("Hello this is method 2 from extention_prectice");
        }
    }
    internal class Program {
        static void Main(string[] args) {
            Class1 obj = new Class1();
            obj.addition();
            obj.substraction();
            obj.multiplication();
            Myclass.newMethod(obj);
            Myclass.newMethod2(obj);

            Console.Read();
        }
    }
}
