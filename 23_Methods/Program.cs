using System;

namespace Methods {
    class Program {
        static void Main(String[] args) {
            /*
                23. Methods: blocks of code that only run when called.

                This is useful as it lets us reuse code without writing it out multiple times.

                Note that it is good practice to capitalise method names,
                i.e. "HappyBirthday" instead of "happyBirthday"
            */
            HappyBirthday("Aaron", 27);
        }
        static void HappyBirthday(String name, int age) {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday dear " + name + "!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("");
            Console.WriteLine("Congratulations! You are now " + age + " years old!");
        }
    }
}