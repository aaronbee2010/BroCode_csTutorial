using System;

namespace WhileLoops {
    class Program {
        static void Main(String[] args) {
            /*
                15: While loops. Blocks of code that repeatedly executes while a condition remains true.

                Below is a good example of how while loops can be used to reject null values from the user.
            */
            String? username = "";
            Console.Write("Please enter your username: ");
            username = Console.ReadLine();

            while (username == "") {
                Console.Write("You have not entered anything. Please try again: ");
                username = Console.ReadLine();
            }

            Console.WriteLine("Welcome back " + username);
        }
    }
}