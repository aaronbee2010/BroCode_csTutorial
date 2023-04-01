using System;

namespace HelloWorld {
    class Program {
        static void Main(String[] args) {
            /*
                25. Method overloading.

                You can have multiple methods with the same name, but different parameters, whether this
                means that there are a different number of parameters and/or the parameters have a different
                combination of types and/or the return type have different values.
            */
            Console.WriteLine("Hello World");

            double x = Multiply(7, 15);
            double y = Multiply(3, 5, 7);

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }

        static double Multiply(double a, double b) {
            return (a * b);
        }
        static double Multiply(double a, double b, double c) {
            return (a * b * c);
        }
    }
}