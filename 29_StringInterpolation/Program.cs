using System;

namespace StringInterpolation {
    class Program {
        static void Main(String[] args) {
            /*
                29. String Interpolation. This allows us to insert variables into a string literal.

                *   For a given string literal we want to insert string literals into, we must
                    precede that string literal with a "$" symbol.
                *   We then enclose one or more variables into the string literal, enclosed by curly braces "{}"
            */
            String firstName = "Aaron";
            String lastName  = "Bee";
            int age = 27;

            Console.WriteLine($"Hello. My first name is {firstName} and my last name is {lastName}.");
            Console.WriteLine($"As of writing this, I am {age, 8} years old.");
            // Here, the "8" tells the compiler we want to allocate 8 characters in the string to our "age" value, including the value,
            // itself, and that the "age" value is right-aligned. If we specify "-8" instead, the only difference is that the "age" value
            // will be left-aligned instead.

            // Console.ReadKey(); // Reminder that this statement waits for the user to press a key
                                  // in order to terminate the program after it's finished running
        }
    }
}