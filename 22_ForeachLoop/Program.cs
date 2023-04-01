using System;

namespace ForeachLoop {
    class Program {
        static void Main(String[] args) {
            /*
                22. Foreach loops. A variant of a for loop used specifically for iterating through elements in an array.
            */
            String[] colours = {"Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet"};

            foreach (String colour in colours) {
                Console.WriteLine(colour);
            }
        }
    }
}