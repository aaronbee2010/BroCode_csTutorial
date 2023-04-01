using System;

namespace ArithmeticOperators {
    class Program {
        static void Main(String[] args) {
            /*
                7. Arithmetic Operators
            */
            int myNumber = 7;
            Console.WriteLine(myNumber); // 7

            // Incrementation
            myNumber = myNumber + 1; // Increments the value within "myNumber" by 1 then reassigns it to "myNumber"
            Console.WriteLine(myNumber); // 8
            myNumber += 1; // "var += num" is a shorthand for "var = var + num"
            Console.WriteLine(myNumber); // 9
            myNumber++; // The "++" operator is shorthand for incrementing a given variable by "1" specifically.
            Console.WriteLine(myNumber); // 10

            // Decrementation
            myNumber = myNumber - 1; // Decrements the value within "myNumber" by 1 then reassigns it to "myNumber"
            Console.WriteLine(myNumber); // 9
            myNumber -= 1; // "var -= num" is a shorthand for "var = var - num"
            Console.WriteLine(myNumber); // 8
            myNumber--; // The "--" operator is shorthand for decrementing a given variable by "1" specifically.
            Console.WriteLine(myNumber); // 7

            // Multiplication
            myNumber = myNumber * 2; // 14
            Console.WriteLine(myNumber); // Multiplies the value within "myNumber" by 2 then reassigns it to "myNumber"
            myNumber *= 2; // 28
            Console.WriteLine(myNumber); // "var *= num" is a shorthand for "var = var * num"

            // Division
            myNumber = myNumber / 2; // 14
            Console.WriteLine(myNumber); // Divides the value within "myNumber" by 2 then reassigns it to "myNumber"
            myNumber /= 2; // 7
            Console.WriteLine(myNumber); // "var /= num" is a shorthand for "var = var / num"

            // Modulus (remainder)
            int remainder = myNumber % 5; // Divides "myNumber" by 5, determines remainder and assigns it to "remainder"
            Console.WriteLine(remainder); // 2

        }
    }
}