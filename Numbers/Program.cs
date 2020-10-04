using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shall we play a game?");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Try and guess it!");
            Console.WriteLine();
            var guess = 0;
            var random = new Random();
            var correctGuess = random.Next(1, 101);
            var guessCount = 0;

            while(guess != correctGuess)
            {
                Console.Write("What's your guess? ");
                int.TryParse(Console.ReadLine(), out guess);
                guessCount++;

                if (guess != correctGuess)
                {
                    if (guess < correctGuess)
                    {
                        Console.WriteLine("Higher...");
                    }
                    else
                    {
                        Console.WriteLine("Lower...");
                    }
                }
            }
            Console.WriteLine($"You win! The correct number was {correctGuess}");
            Console.WriteLine($"It took you {guessCount} guesses to win. Great game!");
            Console.Write("Press the any key to exit :)");
            Console.ReadKey();
        }
    }
}
