namespace Numbers;

#region Using Directives
using System;
using System.Drawing;
using NumbersHelper;
using Console = Colorful.Console;
#endregion

internal class Program
{
    #region Constants
    private const string CorrectMessage = "The correct number was {0}.";
    private const string CountMessage   = "It took you {0} guesses to win. Great game!";
    private const string RangeMessage   = "You should guess a number between {0} and {1}";
    #endregion

    private static void DisplayWinnerMessage(NumbersLib game)
    {
        Console.WriteAscii($"{game.CurrentGuess} - You win!", Color.SpringGreen);
        Console.WriteLineFormatted(CorrectMessage, Color.CornflowerBlue, Color.LawnGreen, game.CurrentGuess);
        Console.WriteLineFormatted(CountMessage,   Color.Aqua,           Color.Gray,      game.NumberOfGuesses);
    }

    private static void Main(string[] args)
    {
        var game = new NumbersLib();
        Console.WriteAscii("Guess the number", Color.Coral);
        Console.WriteLine("Shall we play a game?");
        Console.WriteLine($"I'm thinking of a number between {game.MinimumNumber} and {game.MaximumNumber}. Try and guess it!");
        Console.WriteLine("If you want to quit, just press 0.");
        Console.WriteLine();

        while (!game.CorrectGuess && !game.Forfeit)
        {
            RequestGuessWithinCurrentRange(game);
            Console.Write("What's your guess? ");

            // If user doesn't enter a valid number, guess == 0 and the user forfeits
            _ = int.TryParse(Console.ReadLine(), out var guess);
            var result = game.MakeGuess(guess);
            switch (result)
            {
                case GuessResult.Higher:
                    Console.WriteLine("Higher...", Color.Gold);
                    break;
                case GuessResult.Lower:
                    Console.WriteLine("Lower...", Color.LightSkyBlue);
                    break;
                case GuessResult.Forfeit:
                    Console.WriteLine("The game is forfeit :(");
                    break;
                case GuessResult.CorrectGuess:
                    DisplayWinnerMessage(game);
                    break;
                case GuessResult.PreviousGuess:
                    Console.WriteLine("You've already guessed this number. Try again...", Color.DarkOrange);
                    break;
                case GuessResult.PreviousGuessHigher:
                    Console.WriteLine($"You already know the number is lower than {game.ThresholdHigh}...", Color.DarkOrange);
                    break;
                case GuessResult.PreviousGuessLower:
                    Console.WriteLine($"You already know that the number is lower than {game.ThresholdLow}...", Color.DarkOrange);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private static void RequestGuessWithinCurrentRange(NumbersLib game)
    {
        Console.WriteLineFormatted(RangeMessage, Color.Fuchsia, Color.Gainsboro, game.ThresholdLow, game.ThresholdHigh);
    }
}