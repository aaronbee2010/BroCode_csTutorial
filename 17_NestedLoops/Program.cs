using System;

namespace NestedLoops {
    class Program {
        static void Main(String[] args) {
            /*
                17: Nested loops. Loops that execute within other loops.

                Let's plot a grid of an inputted character.
            */
            Console.Write("Please enter the symbol you would like to plot in a grid: ");
            char sym = Convert.ToChar(Console.ReadLine());

            Console.Write("\nPlease enter the horizontal number of symbols to place: ");
            int col = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter the vertical number of symbols to place: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour grid of dots is displayed below:\n");

            for (int i = 1; i <= row; i++) {
                for (int j = 1; j <= col; j++) {
                    Console.Write(sym + " ");
                }
                
                Console.Write("\n");
            }

            Console.Write("\n");
        }
    }
}
