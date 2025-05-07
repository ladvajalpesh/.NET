using System;

namespace prectice_setion {
    class st {
        int a = 10;
        int b = 20;
        int result;

        public void nonstaticsum() {
            result = a + b;
            Console.WriteLine("sum of a and b is " + result);
        }

        public static void sumstatic() {
            st s = new st();
            s.a = 100;
            s.b = 200;
            s.result = s.a + s.b;
            Console.WriteLine("sum of a and b is " + s.result);

        }
    }

    internal class staticclassexm {
        static void Main(string[] args) {
            st.sumstatic();

            st s = new st();
            s.nonstaticsum();
        }
    }
}
