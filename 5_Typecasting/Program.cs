using System;

namespace Typecasting {
    class Program {
        static void Main(String[] args) {
            /*
                5. Typecasting: Converting a value to a different data type.
                *   This is useful when we accept user input (string), but we want to treat it as a integer, for example.
                *   Different data types can do different things, hence the need for typecasting.
            */
            double a = 3.14159;
            Console.WriteLine(a); // Prints "3.14159" to the console. 
            Console.WriteLine(a.GetType()); // The "GetType()" method displays the type of a given value, in this case: "System.Double"

            int b = Convert.ToInt32(a); // Converts value of variable "a" to a signed 4-byte integer and assigns this value
                                        // to a new variable "b". This works by rounding the double to the nearest integer.
            Console.WriteLine(b); // Prints "3" to the console. 
            Console.WriteLine(b.GetType()); // Prints "System.Int32" to the console.

            double c = Convert.ToDouble(b);
            Console.WriteLine(c); // Prints "3" to the console. The output appears to be an integer,
                                  // but the next statement confirms it's of the "double" data type.
            Console.WriteLine(c.GetType()); // Prints "System.Double" to the console.

            String e = Convert.ToString(a);
            Console.WriteLine(e); // Prints "3.14159" to the console. The output appears to be a double,
                                  // but the next statement confirms it's of the "string" data type. 
            Console.WriteLine(e.GetType()); // Prints "System.String" to the console.

            String f = "G";
            char g = Convert.ToChar(f);
            Console.WriteLine(g); // Prints "G" to the screen. The output looks like it could be a string or char,
                                  // but the next statement confirms it's of the "char" data type.
            Console.WriteLine(g.GetType()); // Prints "System.Char" to the console.

            String h = "false";
            bool i = Convert.ToBoolean(h);
            Console.WriteLine(i); // Prints "False" to the screen. The output looks like it could be a string or bool,
                                  // but the next statement confirms it's of the "bool" data type.
            Console.WriteLine(i.GetType()); // Prints "System.Boolean" to the console.

            bool j = true;
            int k = Convert.ToInt32(j);
            Console.WriteLine(k); // Prints "1" to the screen.
            Console.WriteLine(k.GetType()); // Prints "System.Int32" to the screen.
        }
    }
}








