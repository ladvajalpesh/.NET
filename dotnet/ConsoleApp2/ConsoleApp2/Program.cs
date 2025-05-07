namespace multiplefilerun {
    internal class Program {
        static void Main(string[] args) {
            Person person = new Person();
            person.Name = "John Doe";
            person.age = 30;
            person.sleep();
            person.eat();

        }
    }
}
