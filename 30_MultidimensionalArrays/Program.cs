using System;

namespace MultidimensionalArrays {
    class Program {
        static void Main(String[] args) {
            /*
                30. Multi-dimensional arrays. Arrays which contain more than one dimension.

                The most notable example is a two-dimensional (2D) array, which consists of
                multiple 1D arrays as elements within ANOTHER 1D array.

                The higher the number of dimensions the array has, the more degrees of nesting
                exist within it.

                Nonetheless, the types of all elements in all 1D arrays within the
                multi-dimensional array must be of ONE type only!
            */

            // Here, we have a 2D array consisting of a supermini, a family hatchback and a crossover,
            // from three different car manufacturers whose cars are sold in the UK.

            // NOTE: n-dimensional arrays contain (n - 1) commas within the square brackets of the array type.
            //       For example, a 2D array would contain 1 comma and a 3D array would contain 2 commas
            String[,] makeAndSegments = {
                {"Fiesta", "Focus", "Kuga"},
                {"Polo", "Golf", "Tiguan"},
                {"Clio", "Megane", "Kadjar"}
            };

            // Console.WriteLine(makeAndSegments[0, 0]); // "Fiesta"
            // Console.WriteLine(makeAndSegments[2, 1]); // "Megane"
            
            // // We can traverse the elements horizontally (from top-left to bottom-right) easily by using a foreach loop:
            // foreach (String model in makeAndSegments) {
            //     Console.WriteLine(model);
            // }

            // // To traverse the elements vertically (also from top-left to bottom-right) will be a bit more complex:
            // for (int j = 0; j < makeAndSegments.GetLength(1); j++) {
            //     for (int i = 0; i < makeAndSegments.GetLength(1); i++) {
            //         Console.WriteLine(makeAndSegments[i, j]);
            //     }
            // }

            // Similarly, we can print out each element in a manner representative of its dimensional location within the array.
            for (int i = 0; i < makeAndSegments.GetLength(0); i++) {     // Note use of the "GetLength()" method, which lets us obtain the length
                for (int j = 0; j < makeAndSegments.GetLength(1); j++) { // Of the array in a specific dimension. Here, "0" is the parameter used
                                                                         // To obtain the number of rows and "1" is the parameter used to obtain
                                                                         // the number of columns.
                    Console.Write(makeAndSegments[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Console.ReadKey(); // Reminder that this statement waits for the user to press a key
                                  // in order to terminate the program after it's finished running
        }
    }
}