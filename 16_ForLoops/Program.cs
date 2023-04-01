using System;

namespace ForLoops {
    class Program {
        static void Main(String[] args) {
            /*
                16. For loops: blocks of code which repeatedly execute a defined number of times.
            */

            // Count up from 1 to 10:
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }

            // Count down from 10 to 1:
            for (int i = 10; i >= 1; i--) {
                Console.WriteLine(i);
            }
        }
    }
}