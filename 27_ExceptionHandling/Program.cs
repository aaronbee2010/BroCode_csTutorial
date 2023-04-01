using System;

namespace HelloWorld {
    class Program {
        static void Main(String[] args) {
            /*
                27. Exception handling
                The term "exception" refers to errors that occur during execution.

                Here are three types of blocks that we'll be making use of:
                * try     - Try some code suspected to yield an exception
                * catch   - Code in this block is intended to handle the exception if/when it occurs
                * finally - Code in this block always runs regardless of whether or not an exception has occured
            */


            // Now let's look at a "try" statement in action:
            int a;
            int b;
            double c;

            try {
                Console.Write("Please enter a integer: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Now please enter another integer: ");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                Console.WriteLine("Result: " + c);

            } catch (FormatException e) { // Code in this block executes if code in the "try" block generates a "FormatException"
                Console.WriteLine("You can only enter integers.");
            } catch (DivideByZeroException e) { // Code in this block executes if code in the "try" block generates a "DivideByZeroException"
                Console.WriteLine("You cannot divide by zero.");
            } catch (Exception e) { // Code in this block executes if code in the "try" block generates ANY OTHER exception
                Console.WriteLine("Something seems to have gone wrong.");
            } finally { // Code in this block always runs regardless of whether or not an exception has occured
                Console.WriteLine("Goodbye.");
            }
        }
    }
}