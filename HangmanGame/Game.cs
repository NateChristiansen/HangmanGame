using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Game
    {

        public Dictionary<string, bool> IsVisible { get; set; }
        public string MissedLetters { get; set; }
        public string HiddenWord { get; set; }
        public string GuessedWord { get; set; }
        public int GuessesLeft { get; set; }
        public Dictionary<int, string> BodyIndex { get; set; } = new Dictionary<int, string>
        {
            {0, "head"},
            {1, "body"},
            {2, "leftArm"},
            {3, "rightArm"},
            {4, "leftHand"},
            {5, "rightHand"},
            {6, "leftLeg"},
            {7, "rightLeg"},
            {8, "leftFoot"},
            {9, "rightFoot"}
        };
        public const int Maxturns = 10;

        public Game()
        {
            GuessesLeft = 10;

            IsVisible = new Dictionary<string, bool>
            {
                {"head", false},
                {"body", false},
                {"leftArm", false },
                {"rightArm", false },
                {"leftHand", false },
                {"rightHand", false },
                {"leftLeg", false },
                {"rightLeg", false },
                {"leftFoot", false },
                {"rightFoot", false },
            };

            MissedLetters = string.Empty;
            HiddenWord = GenerateWord();
            GuessedWord = new string(HiddenWord.Select(c => '*').ToArray());

        }
        public void Guess(char myGuess)
        {
            var inWord = false;
            var word = new StringBuilder();

            for (var i = 0; i < HiddenWord.Length; i++)
            {
                if (GuessedWord[i] != '*')
                    word.Append(GuessedWord[i]);
                else if (HiddenWord[i] == myGuess)
                {
                    inWord = true;
                    word.Append(myGuess);
                }
                else
                    word.Append('*');
            }

            GuessedWord = word.ToString();

            if (inWord) return;
            MissedLetters += myGuess;
            IsVisible[BodyIndex[Maxturns - GuessesLeft]] = true;
            GuessesLeft--;
        }
        public string GenerateWord()
        {
            var words = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("HangmanGame.Words.txt")).ReadToEnd().Replace("\r\n", "\n").Split('\n');
            return words[new Random().Next() % words.Length].ToLower();
        }
    }
}