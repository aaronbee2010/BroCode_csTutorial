using System;

namespace RockPaperScissors {
    class Program {
        static void Main(String[] args) {
            /*
                19. Rock Paper Scissors
            */
            Random randomNumberGenerator = new Random(); // Instantiate pseudorandom number generator object
            String playAgain = "y"; // This bool is used to repeat the game if the player wants to
            int randomNumber; // This number can either be 0, 1 or 2, which corresponds to Rock, Paper and Scissors, respectively
            String cpuChoice = ""; // Selection CPU opts for. Derived from result of pseudorandom value assigned to "randomNumber"
            String userChoice; // Selection user opts for
            bool validSelection = false; // This is used to prevent user from progressing without inputting a valid selection
            String choiceCombo; // The winner will be chosen based on the combination of choices stored in this variable.

            while (playAgain == "y") {

                Console.WriteLine("_______________________");
                Console.WriteLine("| Rock Paper Scissors |");
                Console.WriteLine("-----------------------");
                Console.WriteLine("");
                Console.Write("Please choose from \"Rock\", \"Paper\" or \"Scissors\": ");

                // Users choice. We read input from user then adjust it so the first letter is uppercase and all others are lowercase
                userChoice = Console.ReadLine();

                if (userChoice == "") { // Failsafe against user typing a null value
                    userChoice = "  ";
                }

                userChoice = userChoice.ToLower();
                userChoice = userChoice.Substring(0,1).ToUpper() + userChoice.Substring(1);

                while (validSelection == false) {
                    if (userChoice == "Rock" || userChoice == "Paper" || userChoice == "Scissors") {
                        Console.WriteLine("You have selected " + userChoice + ".");
                        validSelection = true;
                    } else {
                        Console.WriteLine("Invalid selection. Please try again.");
                        Console.Write("Please choose from \"Rock\", \"Paper\" or \"Scissors\": ");

                        userChoice = Console.ReadLine();
                        if (userChoice == "") {
                            userChoice = "  ";
                        }
                        userChoice = userChoice.ToLower();
                        userChoice = userChoice.Substring(0,1).ToUpper() + userChoice.Substring(1);
                    }
                }

                // CPUs choice
                randomNumber = randomNumberGenerator.Next(3);
                switch (randomNumber) {
                    case 0:
                        cpuChoice = "Rock";
                        break;
                    case 1:
                        cpuChoice = "Paper";
                        break;
                    case 2:
                        cpuChoice = "Scissors";
                        break;
                }
                Console.WriteLine("The CPU has chosen " + cpuChoice + ".");

                // Compare choices and determine game result
                choiceCombo = userChoice + cpuChoice;

                if (userChoice == cpuChoice) {
                    Console.WriteLine("The game is a tie.");
                } else if (choiceCombo == "RockScissors" || choiceCombo == "ScissorsPaper" || choiceCombo == "PaperRock") {
                    Console.WriteLine("You win!");
                } else if (choiceCombo == "ScissorsRock" || choiceCombo == "PaperScissors" || choiceCombo == "RockPaper") {
                    Console.WriteLine("You lose!");
                }

                Console.Write("Would you like to play again? Type \"y\" to play again.");
                playAgain = Console.ReadLine();
                if (playAgain == "") { // Failsafe against user typing a null value
                    playAgain = "  ";
                }
                playAgain = playAgain.ToLower();
            }
        }
    }
}