using System;

namespace BasicArithmetic {
    class Program {
        static void Main(String[] args) {
            // 8. Basic Arithmetic
            double a = Math.Pow(6, 2);    // Determines value of 6 to the power of 2 and assigns it to "a"
            Console.WriteLine(a);         // 36

            double b = Math.Sqrt(169);    // Determines square root of 169 and assigns it to "b"
            Console.WriteLine(b);         // 13

            double c = Math.Abs(-7);      // Determines absolute value (magnitude) of -7 and assigns it to "c"
            Console.WriteLine(c);         // 7

            double d = Math.Round(5.5);   // Determines value of 5.5 rounded to the nearest integer and assigns it to "d"
            Console.WriteLine(d);         // 6

            double e = Math.Ceiling(2.3); // Determines value of 2.3 rounded to the next integer up and assigns it to "e"
            Console.WriteLine(e);         // 3

            double f = Math.Floor(4.8);   // Determines value of 4.8 rounded to the previous integer down and assigns it to "f"
            Console.WriteLine(f);         // 4

            double g = Math.Max(3, 5);    // Evaluates 3 and 5 then assigns the larger value out of them to "g"
            Console.WriteLine(g);         // 5

            double h = Math.Min(2, 4);    // Evaluates 2 and 4 then assigns the smaller value out of them to "h"
            Console.WriteLine(h);         // 2

        }
    }
}