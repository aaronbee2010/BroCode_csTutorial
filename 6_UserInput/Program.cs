using System;

namespace UserInput {
    class Program {
        static void Main(String[] args) {
            /*
                6. User Input
            */
            Console.Write("Please enter your username then press \"Enter\": ");
            var username = Console.ReadLine();
            // String? username = Console.ReadLine();
                /*
                    We're setting the variable type as "var" because this function can either store a string
                    (if input is given by the user) or a "null" value if no input is provided.
                    The "var" keyword will then set the variable to the same type as the provided value.

                    Alternatively, uou can use the "String?" keyword to set the type of the input to a 
                    "nullable string".
                */
            Console.WriteLine("The username you provided is \"" + username + "\"");
                // Note how you can state literal quotes using the escape character (backslash)
            
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old.");
            // Console.WriteLine(age.GetType()); // "SystemInt32"
        }
    }
}