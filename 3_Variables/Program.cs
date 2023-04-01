using System;

namespace Variables {
    class Program {
        static void Main(String[] args) {
            int x; // Variable declaration
            x = 123; // Variable initialisation

            int y = 321; // Simultaneous variable declaration and initialisation

            int z = x + y;

            Console.WriteLine(x); // '123\n'
            Console.WriteLine(y); // '321\n'
            Console.WriteLine(z); // '444\n'

            int age = 27; // The "int" data type stores signed (positive and negative) integers within 4 bytes of memory.
                          // This means that this type can store any integer from -2,147,483,648 to 2,147,483,647.
            Console.WriteLine("I am " + age + " years old.");

            double pi = 3.14; // The "double" data type stores signed decimal numbers that can fit within 8 bytes of memory.
                              // The approximate range of values that can be stored within this type is ±5.0e−324 to ±1.7e308.
            Console.WriteLine("The circumference of a circle is its diameter multiplied by " + pi + ".");

            bool isAGamer = true; // The "bool" data type can only store two possible values, "true" and "false". They take 1 byte of memory.
            Console.WriteLine("I am a gamer. The previous statement is " + isAGamer + ".");

            char symbol = '@'; // The "char" data type can store 1 of 256 distinct characters within 1 byte of memory.
                               // The character assigned is enclosed within SINGLE quotes.
            Console.WriteLine("Here is an example of a symbol: " + symbol);

            String username = "aaronbee2010"; // The "String" data type can store a sequence of characters.
                                   // The sequence assigned is enclosed within DOUBLE quotes.
            Console.WriteLine("My username is " + username + ".");

            String twitterHandle = symbol + username; // Characters and strings can be concatenated together like so.
            Console.WriteLine("My Twitter handle is " + twitterHandle);

            String myHomeDirectory = "C:\\Users\\aaron";
            Console.WriteLine("My home directory is: " + myHomeDirectory);
            myHomeDirectory = @"C:\Users\aaron";
            // Here, the "@" preceding the string tells the compiler to interpret all characters (including
            // backslashes) as literal, which eliminates the need for double backshashes.
            Console.WriteLine("My home directory is: " + myHomeDirectory);
        }
    }
}







