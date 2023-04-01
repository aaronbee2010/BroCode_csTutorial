using System;

namespace ConditionalOperator {
    class Program {
        static void Main(String[] args) {
            /*
                28. Conditional Operator (also known as ternary operator)
                
                Format:    (condition) ? code_to_run_if_true : code_to_run_if_false

                This operator consists of the following:
                *   An expression which evaluates to either TRUE or FALSE
                *   A block of code that runs only if condition is TRUE
                *   A block of code that runs only if condition is FALSE
            */
            double temperature = 25;
            String message;

            message = (temperature >= 20) ? "It's warm outside!" : "It's not warm outside.";

            Console.WriteLine(message);

            // Console.ReadKey(); // Reminder that this statement waits for the user to press a key
                                  // in order to terminate the program after it's finished running
        }
    }
}