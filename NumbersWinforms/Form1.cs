using NumbersHelper;
// ReSharper disable once RedundantUsingDirective
using Humanizer;
namespace NumbersWinforms;

public partial class Form1 : Form
{
    private const string StillCountsAsAGuess = "This still counts as a guess";
    private NumbersLib _game = null!;

    public Form1()
    {
        InitializeComponent();
        SetupGame();
    }

    private void btnGuess_Click(object sender, EventArgs e)
    {
        MakeGuess();
    }

    private void MakeGuess()
    {
        var result = _game.MakeGuess(txtGuess.Text);
        switch (result)
        {
            case GuessResult.CorrectGuess:
                DisplayWinBanner();
                break;
            case GuessResult.Lower:
                DisplayResult("Lower...");
                break;
            case GuessResult.Higher:
                DisplayResult("Higher...");
                break;
            case GuessResult.PreviousGuess:
                DisplayResult($"Same as previous guess. {StillCountsAsAGuess}!");
                break;
            case GuessResult.PreviousGuessHigher:
                DisplayResult($"You've already guessed lower than {_game.CurrentGuess}. {StillCountsAsAGuess}.");
                break;
            case GuessResult.PreviousGuessLower:
                DisplayResult($"You've already guessed higher than {_game.CurrentGuess}. {StillCountsAsAGuess}.");
                break;
            case GuessResult.Forfeit:
                DisplayResult("You forfeit.");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void DisplayResult(string s)
    {
        DisplayRangeDetails();
        lblResult.Text = s;
        lblResult.Visible = true;
    }

    private void DisplayRangeDetails()
    {
        lblRange.Text = $"Please guess a number between {_game.ThresholdLow} and {_game.ThresholdHigh}";
    }

    private void DisplayWinBanner()
    {
        lblWinBanner.Text = $"Congratulations! {_game.SecretNumber} is the right answer!";
        lblGuessCount.Text = $"It took you {"guess".ToQuantity(_game.NumberOfGuesses)} to win. Great game!";
        lblResult.Visible = false;
        lblGuessCount.Visible = true;
        lblWinBanner.Visible = true;
    }

    private void btnForfeit_Click(object sender, EventArgs e)
    {
        txtGuess.Text = "0";
        MakeGuess();
    }

    private void btnPlayAgain_Click(object sender, EventArgs e)
    {
        SetupGame();
    }

    private void SetupGame()
    {
        _game = new NumbersLib();
        DisplayRangeDetails();
        lblResult.Visible = false;
        lblWinBanner.Visible = false;
        lblGuessCount.Visible = false;
        txtGuess.Text = string.Empty;
    }

    private void btnQuit_Click(object sender, EventArgs e)
    {
        Close();
    }
}