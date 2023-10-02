namespace Numbers;

#region Using Directives
using System;
using System.Drawing;
using System.Linq;
using NumbersHelper;
#endregion

internal class Program
{
    #region Constants
    private const string CorrectMessage = "The correct number was {0}.";
    private const string CountMessage   = "It took you {0} guesses to win. Great game!";
    private const string RangeMessage   = "You should guess a number between {0} and {1}";
    #endregion

    private static NumbersLib DisplayMenu()
    {
        var difficultyValues = Enum.GetValues(typeof(Difficulty)).Cast<int>().ToList();
        foreach (var value in difficultyValues)
        {
            Console.WriteLine($"{value}: {(Difficulty) value}");
        }

        var response           = -1;
        var selectedDifficulty = Difficulty.Custom;
        while (!difficultyValues.Contains(response))
        {
            Console.Write("\nPlease select a difficulty from the values above: ");
            int.TryParse(Console.ReadLine(), out response);
            selectedDifficulty = (Difficulty) response;
        }

        if (selectedDifficulty != Difficulty.Custom)
        {
            return NumbersLib.NewGame(selectedDifficulty);
        }

        var minResult = GetRangeValue(true);
        var maxResult = GetRangeValue(false);
        return new NumbersLib(minResult, maxResult);
    }

    private static void DisplayWinnerMessage(NumbersLib game)
    {
        Colorful.Console.WriteAscii($"{game.CurrentGuess} - You win!", Color.SpringGreen);
        Colorful.Console.WriteLineFormatted(CorrectMessage, Color.CornflowerBlue, Color.LawnGreen, game.CurrentGuess);
        Colorful.Console.WriteLineFormatted(CountMessage,   Color.Aqua,           Color.Gray,      game.NumberOfGuesses);
    }

    private static int GetRangeValue(bool minValue)
    {
        Colorful.Console.Write(
            $"Please enter the {(minValue ? "lowest" : "highest")} number in the range, equal to or greater than {(minValue ? "1" : int.MaxValue - 1)}: ");
        var response = Colorful.Console.ReadLine();
        if (!int.TryParse(response, out var rangeResult) || rangeResult <= 0)
        {
            rangeResult = minValue ? NumbersLib.DefaultMin : NumbersLib.DefaultMax;
        }

        return rangeResult;
    }

    private static void Main(string[] args)
    {
        Colorful.Console.WriteAscii("Guess the number", Color.Coral);
        Colorful.Console.WriteLine("Shall we play a game?");
        var game = DisplayMenu();
        Colorful.Console.WriteLine($"I'm thinking of a number between {game.MinimumNumber} and {game.MaximumNumber}. Try and guess it!");
        Colorful.Console.WriteLine("If you want to quit, just press 0.");
        Colorful.Console.WriteLine();

        while (!game.CorrectGuess && !game.Forfeit)
        {
            RequestGuessWithinCurrentRange(game);
            Colorful.Console.Write("What's your guess? ");

            // If user doesn't enter a valid number, guess == 0 and the user forfeits
            _ = int.TryParse(Colorful.Console.ReadLine(), out var guess);
            var result = game.MakeGuess(guess);
            switch (result)
            {
                case GuessResult.Higher:
                    Colorful.Console.WriteLine("Higher...", Color.Gold);
                    break;
                case GuessResult.Lower:
                    Colorful.Console.WriteLine("Lower...", Color.LightSkyBlue);
                    break;
                case GuessResult.Forfeit:
                    Colorful.Console.WriteLine("The game is forfeit :(");
                    break;
                case GuessResult.CorrectGuess:
                    DisplayWinnerMessage(game);
                    break;
                case GuessResult.PreviousGuess:
                    Colorful.Console.WriteLine("You've already guessed this number. Try again...", Color.DarkOrange);
                    break;
                case GuessResult.PreviousGuessHigher:
                    Colorful.Console.WriteLine($"You already know the number is lower than {game.ThresholdHigh}...", Color.DarkOrange);
                    break;
                case GuessResult.PreviousGuessLower:
                    Colorful.Console.WriteLine($"You already know that the number is lower than {game.ThresholdLow}...", Color.DarkOrange);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private static void RequestGuessWithinCurrentRange(NumbersLib game)
    {
        Colorful.Console.WriteLineFormatted(RangeMessage, Color.Fuchsia, Color.Gainsboro, game.ThresholdLow, game.ThresholdHigh);
    }
}