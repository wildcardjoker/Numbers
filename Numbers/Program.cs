using System;
using System.Drawing;
using Console = Colorful.Console;

namespace Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteAscii("Guess the number", Color.Coral);
            Console.WriteLine("Shall we play a game?");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Try and guess it!");
            Console.WriteLine("If you want to quit, just press 0.");
            Console.WriteLine();
            var guess = -1;
            var random = new Random();
            var correctGuess = random.Next(1, 101);
            var guessCount = 0;
            var countMessage = "It took you {0} guesses to win. Great game!";
            var correctMessage = "The correct number was {0}.";
            var rangeMessage = "You should guess a number between {0} and {1}";
            var min = 1;
            var max = 100;

            while (guess != correctGuess)
            {
                Console.WriteLineFormatted(rangeMessage, Color.Fuchsia, Color.Gainsboro, min, max);
                Console.Write("What's your guess? ");
                int.TryParse(Console.ReadLine(), out guess);
                guessCount++;

                if (guess == 0)
                {
                    Console.WriteLine("The game is forfeit :(");
                    return;
                }

                if (guess != correctGuess)
                    Console.WriteLine(guess < correctGuess ? "Higher..." : "Lower...",
                        guess < correctGuess ? Color.Gold : Color.LightSkyBlue);
                if (guess<correctGuess)
                {
                    min = guess;
                }
                else
                {
                    max = guess;
                }
            }

            Console.WriteAscii($"{correctGuess} - You win!", Color.SpringGreen);
            Console.WriteLineFormatted(correctMessage, Color.CornflowerBlue, Color.LawnGreen, correctGuess);
            Console.WriteLineFormatted(countMessage, Color.Aqua, Color.Gray, guessCount);
        }
    }
}