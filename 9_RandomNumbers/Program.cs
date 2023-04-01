using System;

namespace RandomNumbers {
    class Program {
        static void Main(String[] args) {
            // 9. Random numbers
            // Technically, these numbers are not truly random. Instead, they are "pseudorandom".

            Random randomObject = new Random();
            // Generates an object ("randomObject") which can be used to generate random numbers via various methods.
            // This object only needs to be instantiated ONCE.

            /*
                Integers
            */
            int a = randomObject.Next();
            // Generates a random integer between 0 (inclusive) and 2147483647 (exclusive), then assigns its value to "a"
            Console.WriteLine(a);

            int b = randomObject.Next(35);
            // Generates a random integer between 0 (inclusive) and 35 (exclusive), then assigns its value to "b"
            Console.WriteLine(b);

            int c = randomObject.Next(24, 35);
            // Generates a random integer between 24 (inclusive) and 35 (exclusive), then assigns its value to "c"
            Console.WriteLine(c);

            /*
                Doubles
            */
            double d = randomObject.NextDouble();
            // Generates a random floating-point number between 0.0 (inclusive) and 1.0 (exclusive), then assigns its value to "d"
            Console.WriteLine(d);

            double e = randomObject.NextDouble() * 50;
            // Generates a random floating-point number between 0.0 (inclusive) and 50.0 (exclusive), then assigns its value to "e"
            Console.WriteLine(e);

        }
    }
}