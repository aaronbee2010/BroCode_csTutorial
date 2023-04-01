using System;

namespace NumberGuessingGame {
    class Program {
        static void Main(String[] args) {
            /*
                18. Number guessing game

                This game will give players 10 attempts to guess a number between 1 and 100.
            */

            Random rng = new Random(); // Instantiate our pseudorandom number generator object.
            
            int correctAnswer = rng.Next(100) + 1; // "Randomly" generates a random integer between 1 and 100.
            int currentGuess;
            int guessCount = 1;
            bool win = false;
            bool playAgain = true;
            char endAnswer;
  
            Console.WriteLine("Number guessing game! You have 10 chances to guess the correct number!\n");

            while (playAgain) {
                for (int i = 1; i <= 10; i++) {
                    if (i == 10) { // Warning message that appears when player is on their last chance.
                        Console.WriteLine("Oh dear! It looks like you're on your last guess! No pressure!\n");
                    }

                    Console.Write("Attempt " + i + ". Please guess a number between 1 and 100: ");
                    currentGuess = Convert.ToInt32(Console.ReadLine());
                    if (currentGuess == correctAnswer) {
                        win = true;
                        i = 10;
                    } else if (currentGuess < correctAnswer) {
                        Console.WriteLine("Wrong! Your answer is too low! Please try again!\n");
                        guessCount++;
                    } else if (currentGuess > correctAnswer) {
                        Console.WriteLine("Wrong! Your answer is too high! Please try again!\n");
                        guessCount++;
                    }
                }

                if (win == true) {
                    Console.WriteLine("Congratulations! You guessed the correct answer in " + guessCount + " attempts!");
                } else if (win == false) {
                    Console.WriteLine("Too bad! The correct answer was " + correctAnswer + "!");
                }

                Console.Write("Would you like to play again? Type \"y\" to play again. ");
                endAnswer = Convert.ToChar(Console.ReadLine());

                if (endAnswer != 'y') {
                    Console.WriteLine("Goodbye!");
                    playAgain = false;
                }
            }
        }
    }
}