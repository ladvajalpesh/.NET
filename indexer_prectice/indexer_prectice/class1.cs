using System;
namespace indexer_prectice {
    class Product {
        private string[] items = new string[3];
        private int[] prices = new int[3];


        public string this[int index] {
            get { return items[index]; }
            set { items[index] = value; }
        }


        public int this[string itemName] {
            get {
                for (int i = 0; i < items.Length; i++) {
                    if (items[i] == itemName)
                        return prices[i];
                }
                return 0;
            }
            set {
                for (int i = 0; i < items.Length; i++) {
                    if (items[i] == itemName) {
                        prices[i] = value;
                        return;
                    }
                }
            }
        }
    }
    class class1 {
        static void Main(string[] args) {
            Product p = new Product();


            p[0] = "Pen";
            p[1] = "Book";
            p[2] = "Pencil";


            p["Pen"] = 10;
            p["Book"] = 20;
            p["Pencil"] = 5;


            Console.WriteLine(p[1]);
            Console.WriteLine(p["Pencil"]);
        }
    }
}