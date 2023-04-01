using System;

namespace LogicalOperators {
    class Program {
        static void Main(String[] args) {
            /*
                14. Logical Operators: Can be used to check if *more than* 1 condition is true or false.
                    We will be looking at the following operators:
                    * && (AND)
                    * || (OR)
            */
            Console.Write("What is the temperature today: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 15 && temp <= 25) {
                Console.WriteLine("The weather is pleasant.");
            } else if (temp <= -5 || temp >= 40) {
                Console.WriteLine("The weather is dangerous. Do not go outside unless in an emergency.");
            } else {
                Console.WriteLine("The weather is tolerable.");
            }
        }
    }
}