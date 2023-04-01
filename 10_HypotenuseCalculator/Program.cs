using System;

namespace HypotenuseCalculator {
    class Program {
        static void Main(String[] args) {
            Console.WriteLine("            .  . .  .  __   __  ____  __ .  . .  .  __   __   ");
            Console.WriteLine("  |\\        |__| |__| |__| |  |   |  |__ |\\ | |  | |__  |__ ");
            Console.WriteLine("  | \\       |  | ___| |    |__|   |  |__ | \\| |__| __|  |__ ");
            Console.WriteLine("a |  \\ h     __   __  .     __  .  . .    __  ___   __   __  ");
            Console.WriteLine("  |_  \\     |    |__| |    |    |  | |   |__|  |   |  | |__| ");
            Console.WriteLine("  |_|__\\    |__  |  | |__  |__  |__| |__ |  |  |   |__| | \\ ");
            Console.WriteLine("     b                                                        ");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Please enter the length of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Great! Now please enter the length of b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");

            double a2 = Math.Pow(a, 2);
            double b2 = Math.Pow(b, 2);
            double h =  Math.Sqrt(a2 + b2);

            Console.WriteLine("The length of the hypotenuse is: " + h);
        }
    }
}