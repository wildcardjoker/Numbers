namespace NumbersWinforms;

#region Using Directives
using Humanizer;
using NumbersHelper;
#endregion

public partial class Form1 : Form
{
    #region Constants
    private const int DefaultMax = NumbersLib.DefaultMax;
    private const int DefaultMin = NumbersLib.DefaultMin;

    private const string StillCountsAsAGuess = "This still counts as a guess";
    #endregion

    #region Fields
    private NumbersLib _game = null!;
    #endregion

    #region Constructors
    public Form1()
    {
        InitializeComponent();
        SetupGame();
    }
    #endregion

    private void btnForfeit_Click(object sender, EventArgs e)
    {
        txtGuess.Text = "0";
        MakeGuess();
    }

    private void btnGuess_Click(object sender, EventArgs e)
    {
        MakeGuess();
        updateForfeitButton();
    }

    private void btnPlayAgain_Click(object sender, EventArgs e)
    {
        SetupGame();
    }

    private void btnQuit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtMin.Text, out var min))
        {
            SetDefaultValue(txtMin, DefaultMin);
            min = DefaultMin;
        }

        if (!int.TryParse(txtMax.Text, out var max))
        {
            SetDefaultValue(txtMax, DefaultMax);
            max = DefaultMax;
        }

        _game = new NumbersLib(min, max);
        SetRangeFieldsEnabled(false);
        DisplayRangeDetails();
    }

    private void DisplayRangeDetails()
    {
        lblRange.Text = $"Please guess a number between {_game.ThresholdLow} and {_game.ThresholdHigh}";
    }

    private void DisplayWinBanner()
    {
        lblWinBanner.Text     = $"Congratulations! {_game.SecretNumber} is the right answer!";
        lblGuessCount.Text    = $"It took you {"guess".ToQuantity(_game.NumberOfGuesses)} to win. Great game!";
        lblResult.Visible     = false;
        lblGuessCount.Visible = true;
        lblWinBanner.Visible  = true;
        setPlayQuitButtonVisibility(true);
    }

    private void MakeGuess()
    {
        var result        = _game.MakeGuess(txtGuess.Text);
        var resultMessage = string.Empty;
        switch (result)
        {
            case GuessResult.CorrectGuess:
                DisplayWinBanner();
                break;
            case GuessResult.Lower:
                resultMessage = "Lower...";
                break;
            case GuessResult.Higher:
                resultMessage = "Higher...";
                break;
            case GuessResult.PreviousGuess:
                resultMessage = $"Same as previous guess. {StillCountsAsAGuess}!";
                break;
            case GuessResult.PreviousGuessHigher:
                resultMessage = $"You've already guessed lower than {_game.CurrentGuess}. {StillCountsAsAGuess}.";
                break;
            case GuessResult.PreviousGuessLower:
                resultMessage = $"You've already guessed higher than {_game.CurrentGuess}. {StillCountsAsAGuess}.";
                break;
            case GuessResult.Forfeit:
                resultMessage = $"You forfeit. {_game.SecretNumber} was the right answer!";
                setPlayQuitButtonVisibility(true);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        DisplayRangeDetails();
        lblResult.Text = resultMessage;
        lblResult.ForeColor = result switch
        {
            GuessResult.Higher              => Color.Red,
            GuessResult.Lower               => Color.Green,
            GuessResult.PreviousGuessHigher => Color.DarkOrange,
            GuessResult.PreviousGuessLower  => Color.DarkOrange,
            _                               => Color.Black
        };

        lblResult.Visible = true;
    }

    private void SetDefaultValue(TextBox t, int value)
    {
        t.Text = value.ToString();
    }

    private void setPlayQuitButtonVisibility(bool isVisible)
    {
        btnPlayAgain.Visible = isVisible;
        btnQuit.Visible      = isVisible;
    }

    private void SetRangeFieldsEnabled(bool isEnabled)
    {
        txtMax.Enabled = isEnabled;
        txtMin.Enabled = isEnabled;
    }

    private void SetupGame()
    {
        SetDefaultValue(txtMax, DefaultMax);
        SetDefaultValue(txtMin, DefaultMin);

        lblResult.Visible     = false;
        lblWinBanner.Visible  = false;
        lblGuessCount.Visible = false;
        txtGuess.Text         = string.Empty;
        btnForfeit.Enabled    = false;
        setPlayQuitButtonVisibility(false);
        SetRangeFieldsEnabled(true);
    }

    private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void updateForfeitButton()
    {
        if (_game.NumberOfGuesses > 0)
        {
            btnForfeit.Enabled = true;
        }
    }
}