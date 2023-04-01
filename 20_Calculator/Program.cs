using System;

namespace Calculator {
    class Program {
        static void Main(String[] args) {
            /*
                20. Calculator
            */
            String useAgain = "y";
            double a;
            double b;
            String symbol;
            double c = 0;

            Console.WriteLine("______________");
            Console.WriteLine("| Calculator |");
            Console.WriteLine("--------------");
            Console.WriteLine("");

            while (useAgain == "y") {
                Console.Write("Please enter a number: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Great. Please enter another number: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Great. Please choose which operation you");
                Console.WriteLine("would like to perform on these two numbers: ");
                Console.WriteLine("");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exponentiation");
                Console.WriteLine("6. Remainder");

                symbol = Console.ReadLine();
                if (symbol == "") {
                    symbol = "0";
                }

                switch (symbol) {
                    case "1":
                        c = a + b;
                        Console.WriteLine("Result: " + c);
                        break;
                    case "2":
                        c = a - b;
                        Console.WriteLine("Result: " + c);
                        break;
                    case "3":
                        c = a * b;
                        Console.WriteLine("Result: " + c);
                        break;
                    case "4":
                        c = a / b;
                        Console.WriteLine("Result: " + c);
                        break;
                    case "5":
                        c = Math.Pow(a, b);
                        Console.WriteLine("Result: " + c);
                        break;
                    case "6":
                        c = a % b;
                        Console.WriteLine("Result: " + c);
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }

                Console.Write("Would you like to make another calculation? If so, type \"y\". ");
                useAgain = Console.ReadLine();
            }
        }
    }
}