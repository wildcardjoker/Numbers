namespace NumbersHelper;

#region Using Directives
using Humanizer;
#endregion

public class NumbersLib
{
    #region Constants
    public const  int DefaultForfeitThreshold = 3;
    public const  int DefaultMax              = 100;
    public const  int DefaultMin              = 1;
    public const  int ExpertForfeitThreshold  = 20;
    public const  int HardForfeitThreshold    = 10;
    public const  int MediumForfeitThreshold  = 5;
    private const int HardMax                 = 1000000;
    private const int MediumMax               = 1000;
    #endregion

    #region Constructors
    public NumbersLib() : this(DefaultMin, DefaultMax, DefaultForfeitThreshold) {}

    public NumbersLib(int minimum, int maximum, int forfeitThreshold)
    {
        MinimumNumber    = minimum;
        MaximumNumber    = maximum;
        ThresholdHigh    = MaximumNumber;
        ThresholdLow     = MinimumNumber;
        ForfeitThreshold = forfeitThreshold;
        var rnd = new Random();
        SecretNumber = rnd.Next(MinimumNumber, MaximumNumber + 1);
    }
    #endregion

    #region Properties
    public bool CanForfeit           => NumberOfGuesses >= ForfeitThreshold;
    public bool CorrectGuess         {get; private set;}
    public int  CurrentGuess         {get; private set;}
    public bool Forfeit              {get; private set;}
    public int  ForfeitThreshold     {get;}
    public int  GuessesBeforeForfeit => ForfeitThreshold - NumberOfGuesses;
    public int  MaximumNumber        {get;}
    public int  MinimumNumber        {get;}
    public int  NumberOfGuesses      {get; private set;}

    public int SecretNumber  {get;}
    public int ThresholdHigh {get; private set;}
    public int ThresholdLow  {get; private set;}
    #endregion

    public static NumbersLib NewGame(Difficulty difficulty)
    {
        return difficulty switch
        {
            Difficulty.Easy   => new NumbersLib(DefaultMin, DefaultMax,       DefaultForfeitThreshold),
            Difficulty.Medium => new NumbersLib(DefaultMin, MediumMax,        MediumForfeitThreshold),
            Difficulty.Hard   => new NumbersLib(DefaultMin, HardMax,          HardForfeitThreshold),
            Difficulty.Expert => new NumbersLib(DefaultMin, int.MaxValue - 1, ExpertForfeitThreshold),
            _                 => throw new ArgumentOutOfRangeException(nameof(difficulty), difficulty, null)
        };
    }

    public string GetRemainingGuessesBeforeForfeit() => "guess".ToQuantity(GuessesBeforeForfeit);

    public GuessResult MakeGuess(string guess)
    {
        _ = int.TryParse(guess, out var guessResult);
        return MakeGuess(guessResult);
    }

    /// <summary>Checks the user's guess against the secret number.</summary>
    /// <param name="guess">The current number being guessed.</param>
    /// <returns>
    ///     A <see cref="GuessResult" /> indicating the relationship between the guess and the secret number.
    /// </returns>
    /// <remarks>
    ///     Possible values are:
    ///     CorrectGuess: the user guess the correct number
    ///     Higher: the user guessed higher than the secret number
    ///     Lower: the user guessed lower than the secret number
    ///     PreviousGuess: The user guessed this number previously
    ///     PreviousGuessHigher: The user guessed a lower number already - this guess is already outside the possible range
    ///     PreviousGuessLower The user guessed a higher number already - this guess is already outside the possible range
    ///     Forfeit: the user entered 0 (or invalid input) - assume they wish to exit the game
    /// </remarks>
    public GuessResult MakeGuess(int guess)
    {
        CurrentGuess = guess;

        if (guess == 0)
        {
            if (!CanForfeit)
            {
                return GuessResult.Higher;
            }

            Forfeit = true;
            return GuessResult.Forfeit;
        }

        NumberOfGuesses++;
        if (CurrentGuess == SecretNumber)
        {
            CorrectGuess = true;
            return GuessResult.CorrectGuess;
        }

        if (CurrentGuess < ThresholdLow)
        {
            return GuessResult.PreviousGuessLower;
        }

        if (CurrentGuess > ThresholdHigh)
        {
            return GuessResult.PreviousGuessHigher;
        }

        if (CurrentGuess < SecretNumber)
        {
            ThresholdLow = CurrentGuess;
            return GuessResult.Higher;
        }

        ThresholdHigh = CurrentGuess;
        return GuessResult.Lower;
    }
}