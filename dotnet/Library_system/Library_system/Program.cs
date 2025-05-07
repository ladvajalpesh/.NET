//Create a Library system
//Create a Book class with title, author, and ISBN.
//Create a Member class with name and membershipID.
//Create a Library class that allows adding books and borrowing books.

namespace Library_system {
    public class Book {
        public string title { get; set; }
        public string author { get; set; }
        public long ISBN { get; set; }

        public Book(string title, string author, long ISBN) {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }
    }
    public class Member {
        public string name { get; set; }
        public int membershipID { get; set; }
        public Member(string name, int membershipID) {
            this.name = name;
            this.membershipID = membershipID;
        }
    }
    public class Library {



    }
    internal class Program {
        static void Main(string[] args) {
        }
    }
}
