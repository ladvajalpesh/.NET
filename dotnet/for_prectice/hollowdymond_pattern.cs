using System;

namespace for_prectice {
    internal class hollowdymond_pattern {
        k
        public static void Main(string[] args) {
            int n = 5;

            // Upper half of the hollow diamond
            for (int i = 1; i <= n; i++) {
                for (int j = i; j < n; j++) {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++) {
                    if (j == 1 || j == (2 * i - 1)) {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Lower half of the hollow diamond
            for (int i = n - 1; i >= 1; i--) {
                for (int j = n; j > i; j--) {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++) {
                    if (j == 1 || j == (2 * i - 1)) {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }


}