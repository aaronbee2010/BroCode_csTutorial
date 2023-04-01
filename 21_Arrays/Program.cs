using System;

namespace Arrays {
    class Program {
        static void Main(String[] args) {
            /*
                21. Arrays: Variables that can store a fixed number of different values, all of the same type.
            */

            // String array with predetermined values
            String[] array1 = {"Somebody", "Once", "Told", "Me"};

            // Empty string array
            String[] array2 = new String[6];

            // Add values to the empty array
            array2[0] = "The";
            array2[1] = "World";
            array2[2] = "Was";
            array2[3] = "Gonna";
            array2[4] = "Roll";
            array2[5] = "Me";

            // Print values within an array
            for (int i = 0; i < array1.Length; i++) { // The "Length" attribute of an array comes in useful here.
                Console.WriteLine(array1[i]);
            }
        }
    }
}