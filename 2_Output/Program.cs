using System;

// Single-line comment

/*
Multi-line
comment
*/

namespace Output {
    class Program {
        static void Main(String[] args) {
            Console.Write("Hello "); // Prints string without appending newline.
            Console.WriteLine("World"); // Prints string with appended newline.

            Console.Write("\tGoodbye World\n"); // Newlines and other escape sequences can be added manually

            Console.ReadKey(); // Waits for key to be input before terminating program.
        }
    }
}