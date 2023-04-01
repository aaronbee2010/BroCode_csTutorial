using System;

namespace Switches {
    class Program {
        static void Main(String[] args) {
            /*
                13. Switch statements: an elegant alternative to multiple "else if" statements.
            */
            Console.Write("Please enter the current day of the week: ");
            String? dayOfWeek = Console.ReadLine();

            switch (dayOfWeek) {
                case "Sunday":
                    Console.WriteLine("Sunday is a fun day.");
                    break;
                case "Monday":
                    Console.WriteLine("Monday is also a fun day.");
                    break;
                case "Tuesday":
                    Console.WriteLine("Tuesday is Blues day.");
                    break;
                case "Wednesday":
                    Console.WriteLine("Wednesday is my friends day.");
                    break;
                case "Thursday":
                    Console.WriteLine("Thursday is the Spurs day.");
                    break;
                case "Friday":
                    Console.WriteLine("Friday is my day.");
                    break;
                case "Saturday":
                    Console.WriteLine("Saturday is the time to stay......home?");
                    break;
                default:
                    Console.WriteLine(dayOfWeek + " is not a day!");
                    break;
            }
        }
    }
}