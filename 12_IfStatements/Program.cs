using System;

namespace IfStatements {
    class Program {
        static void Main(String[] args) {
            // 11. "if", "else" and "else if" statements.
            Console.Write("Please enter your legal age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 65) {
                Console.WriteLine("You are too old to purchase this product.");
            } else if (age < 18) {
                Console.WriteLine("You are too young to purchase this product.");
            } else {
                Console.WriteLine("Here you are. Have a nice day");
            }
        }
    }
}