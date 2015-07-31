using System;
using System.Windows.Forms;
using HangmanGame.Properties;

namespace HangmanGame
{
    public partial class Form1 : Form
    {
        private Game _myGame;
        private readonly string[] _endingText = { "Congratulations! You won the game!", "Aww, you have lost. Try again Scrub." };

        public Form1()
        {
            InitializeComponent();
            _myGame = new Game();
        }

        private void GameState()
        {
            guess.Text = string.Empty;
            guess.Focus();
            head.Visible = _myGame.IsVisible["head"];
            body.Visible = _myGame.IsVisible["body"];
            leftArm.Visible = _myGame.IsVisible["leftArm"];
            leftHand.Visible = _myGame.IsVisible["leftHand"];
            leftLeg.Visible = _myGame.IsVisible["leftLeg"];
            leftFoot.Visible = _myGame.IsVisible["leftFoot"];
            rightArm.Visible = _myGame.IsVisible["rightArm"];
            rightHand.Visible = _myGame.IsVisible["rightHand"];
            rightLeg.Visible = _myGame.IsVisible["rightLeg"];
            rightFoot.Visible = _myGame.IsVisible["rightFoot"];

            hiddenWord.Text = _myGame.GuessedWord;
            missedLetters.Text = _myGame.MissedLetters;
            incorrectGuessesCounter.Text = _myGame.GuessesLeft.ToString();

            if (_myGame.GuessesLeft == 0 || _myGame.GuessedWord == _myGame.HiddenWord)
            {
                GameOver(_myGame.GuessesLeft);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gameOverText.Visible = false;
            GameState();
        }
        
        private void GameOver(int guesses)
        {
            guess.Enabled = false;
            gameOverText.Text = _endingText[guesses > 0 ? 0 : 1];
            hiddenWord.Text = _myGame.HiddenWord;
            gameOverText.Visible = true;
        }

        private void gameOverButton_Click(object sender, EventArgs e)
        {
            gameOverText.Visible = false;
            guess.Enabled = true;
            _myGame = new Game();
            GameState();
        }

        private void guess_KeyDown(object sender, KeyEventArgs e)
        {
            _myGame.Guess((char)(e.KeyCode + 32));
            GameState();
            guess.Text = string.Empty;
            guess.Focus();
        }
    }
}