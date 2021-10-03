using System;

namespace Numbers
{
    using System;
    using System.Drawing;
    using Console = Colorful.Console;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteAscii("Guess the number",Color.Coral);
            Console.WriteLine("Shall we play a game?");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Try and guess it!");
            Console.WriteLine();
            var guess = 0;
            var random = new Random();
            var correctGuess = random.Next(1, 101);
            var guessCount = 0;
            var countMessage = "It took you {0} guesses to win. Great game!";
            var correctMessage = "The correct number was {0}.";

            while (guess != correctGuess)
            {
                Console.Write("What's your guess? ");
                int.TryParse(Console.ReadLine(), out guess);
                guessCount++;

                if (guess != correctGuess)
                {
                    Console.WriteLine(guess < correctGuess ? "Higher..." : "Lower...", guess<correctGuess? Color.Gold : Color.LightSkyBlue);
                }
            }
            Console.WriteAscii($"{correctGuess} - You win!", Color.SpringGreen);
            Console.WriteLineFormatted(correctMessage, Color.CornflowerBlue, Color.LawnGreen, correctGuess);
            Console.WriteLineFormatted(countMessage, Color.Aqua,Color.Gray,guessCount);
            Console.ResetColor();

            Console.Write("Press the any key to exit :)");
            Console.ReadKey();
        }
    }
}
