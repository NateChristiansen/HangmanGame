namespace HangmanGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.noose = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.PictureBox();
            this.body = new System.Windows.Forms.PictureBox();
            this.leftArm = new System.Windows.Forms.PictureBox();
            this.rightArm = new System.Windows.Forms.PictureBox();
            this.leftHand = new System.Windows.Forms.PictureBox();
            this.rightFoot = new System.Windows.Forms.PictureBox();
            this.rightHand = new System.Windows.Forms.PictureBox();
            this.rightLeg = new System.Windows.Forms.PictureBox();
            this.leftLeg = new System.Windows.Forms.PictureBox();
            this.leftFoot = new System.Windows.Forms.PictureBox();
            this.hiddenWord = new System.Windows.Forms.Label();
            this.missedLetters = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.TextBox();
            this.incorrectGuessesLabel = new System.Windows.Forms.Label();
            this.incorrectGuessesCounter = new System.Windows.Forms.Label();
            this.gameOverText = new System.Windows.Forms.Label();
            this.gameOverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightFoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftFoot)).BeginInit();
            this.SuspendLayout();
            // 
            // noose
            // 
            this.noose.Image = ((System.Drawing.Image)(resources.GetObject("noose.Image")));
            this.noose.Location = new System.Drawing.Point(12, 12);
            this.noose.Name = "noose";
            this.noose.Size = new System.Drawing.Size(271, 443);
            this.noose.TabIndex = 0;
            this.noose.TabStop = false;
            // 
            // head
            // 
            this.head.Image = ((System.Drawing.Image)(resources.GetObject("head.Image")));
            this.head.Location = new System.Drawing.Point(221, 67);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(56, 52);
            this.head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.head.TabIndex = 1;
            this.head.TabStop = false;
            // 
            // body
            // 
            this.body.Image = ((System.Drawing.Image)(resources.GetObject("body.Image")));
            this.body.Location = new System.Drawing.Point(243, 116);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(10, 182);
            this.body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.body.TabIndex = 2;
            this.body.TabStop = false;
            // 
            // leftArm
            // 
            this.leftArm.Image = ((System.Drawing.Image)(resources.GetObject("leftArm.Image")));
            this.leftArm.Location = new System.Drawing.Point(206, 140);
            this.leftArm.Name = "leftArm";
            this.leftArm.Size = new System.Drawing.Size(39, 69);
            this.leftArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftArm.TabIndex = 3;
            this.leftArm.TabStop = false;
            // 
            // rightArm
            // 
            this.rightArm.Image = ((System.Drawing.Image)(resources.GetObject("rightArm.Image")));
            this.rightArm.Location = new System.Drawing.Point(251, 136);
            this.rightArm.Name = "rightArm";
            this.rightArm.Size = new System.Drawing.Size(39, 86);
            this.rightArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightArm.TabIndex = 4;
            this.rightArm.TabStop = false;
            // 
            // leftHand
            // 
            this.leftHand.Image = ((System.Drawing.Image)(resources.GetObject("leftHand.Image")));
            this.leftHand.Location = new System.Drawing.Point(182, 187);
            this.leftHand.Name = "leftHand";
            this.leftHand.Size = new System.Drawing.Size(25, 37);
            this.leftHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftHand.TabIndex = 5;
            this.leftHand.TabStop = false;
            // 
            // rightFoot
            // 
            this.rightFoot.Image = ((System.Drawing.Image)(resources.GetObject("rightFoot.Image")));
            this.rightFoot.Location = new System.Drawing.Point(288, 351);
            this.rightFoot.Name = "rightFoot";
            this.rightFoot.Size = new System.Drawing.Size(37, 11);
            this.rightFoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightFoot.TabIndex = 6;
            this.rightFoot.TabStop = false;
            // 
            // rightHand
            // 
            this.rightHand.Image = ((System.Drawing.Image)(resources.GetObject("rightHand.Image")));
            this.rightHand.Location = new System.Drawing.Point(286, 197);
            this.rightHand.Name = "rightHand";
            this.rightHand.Size = new System.Drawing.Size(26, 25);
            this.rightHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightHand.TabIndex = 7;
            this.rightHand.TabStop = false;
            // 
            // rightLeg
            // 
            this.rightLeg.Image = ((System.Drawing.Image)(resources.GetObject("rightLeg.Image")));
            this.rightLeg.Location = new System.Drawing.Point(250, 279);
            this.rightLeg.Name = "rightLeg";
            this.rightLeg.Size = new System.Drawing.Size(49, 77);
            this.rightLeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightLeg.TabIndex = 8;
            this.rightLeg.TabStop = false;
            // 
            // leftLeg
            // 
            this.leftLeg.Image = ((System.Drawing.Image)(resources.GetObject("leftLeg.Image")));
            this.leftLeg.Location = new System.Drawing.Point(191, 281);
            this.leftLeg.Name = "leftLeg";
            this.leftLeg.Size = new System.Drawing.Size(54, 78);
            this.leftLeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftLeg.TabIndex = 9;
            this.leftLeg.TabStop = false;
            // 
            // leftFoot
            // 
            this.leftFoot.Image = ((System.Drawing.Image)(resources.GetObject("leftFoot.Image")));
            this.leftFoot.Location = new System.Drawing.Point(160, 351);
            this.leftFoot.Name = "leftFoot";
            this.leftFoot.Size = new System.Drawing.Size(37, 16);
            this.leftFoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftFoot.TabIndex = 10;
            this.leftFoot.TabStop = false;
            // 
            // hiddenWord
            // 
            this.hiddenWord.AutoSize = true;
            this.hiddenWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenWord.Location = new System.Drawing.Point(289, 424);
            this.hiddenWord.Name = "hiddenWord";
            this.hiddenWord.Size = new System.Drawing.Size(86, 31);
            this.hiddenWord.TabIndex = 11;
            this.hiddenWord.Text = "label1";
            // 
            // missedLetters
            // 
            this.missedLetters.AutoSize = true;
            this.missedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missedLetters.Location = new System.Drawing.Point(7, 492);
            this.missedLetters.Name = "missedLetters";
            this.missedLetters.Size = new System.Drawing.Size(70, 26);
            this.missedLetters.TabIndex = 12;
            this.missedLetters.Text = "label1";
            // 
            // guess
            // 
            this.guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess.Location = new System.Drawing.Point(295, 458);
            this.guess.MaxLength = 1;
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(70, 32);
            this.guess.TabIndex = 13;
            this.guess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guess_KeyDown);
            // 
            // incorrectGuessesLabel
            // 
            this.incorrectGuessesLabel.AutoSize = true;
            this.incorrectGuessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectGuessesLabel.Location = new System.Drawing.Point(441, 9);
            this.incorrectGuessesLabel.Name = "incorrectGuessesLabel";
            this.incorrectGuessesLabel.Size = new System.Drawing.Size(224, 26);
            this.incorrectGuessesLabel.TabIndex = 15;
            this.incorrectGuessesLabel.Text = "Incorrect guesses left:";
            // 
            // incorrectGuessesCounter
            // 
            this.incorrectGuessesCounter.AutoSize = true;
            this.incorrectGuessesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectGuessesCounter.Location = new System.Drawing.Point(671, 9);
            this.incorrectGuessesCounter.Name = "incorrectGuessesCounter";
            this.incorrectGuessesCounter.Size = new System.Drawing.Size(36, 26);
            this.incorrectGuessesCounter.TabIndex = 16;
            this.incorrectGuessesCounter.Text = "10";
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverText.Location = new System.Drawing.Point(336, 136);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(365, 26);
            this.gameOverText.TabIndex = 17;
            this.gameOverText.Text = "Congratulations! You won the game!";
            // 
            // gameOverButton
            // 
            this.gameOverButton.Location = new System.Drawing.Point(609, 492);
            this.gameOverButton.Name = "gameOverButton";
            this.gameOverButton.Size = new System.Drawing.Size(98, 36);
            this.gameOverButton.TabIndex = 18;
            this.gameOverButton.Text = "New Game";
            this.gameOverButton.UseVisualStyleBackColor = true;
            this.gameOverButton.Click += new System.EventHandler(this.gameOverButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 540);
            this.Controls.Add(this.gameOverButton);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.incorrectGuessesCounter);
            this.Controls.Add(this.incorrectGuessesLabel);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.missedLetters);
            this.Controls.Add(this.hiddenWord);
            this.Controls.Add(this.rightFoot);
            this.Controls.Add(this.leftFoot);
            this.Controls.Add(this.leftLeg);
            this.Controls.Add(this.rightLeg);
            this.Controls.Add(this.rightHand);
            this.Controls.Add(this.leftHand);
            this.Controls.Add(this.rightArm);
            this.Controls.Add(this.leftArm);
            this.Controls.Add(this.body);
            this.Controls.Add(this.head);
            this.Controls.Add(this.noose);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightFoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftFoot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox noose;
        private System.Windows.Forms.PictureBox head;
        private System.Windows.Forms.PictureBox body;
        private System.Windows.Forms.PictureBox leftArm;
        private System.Windows.Forms.PictureBox rightArm;
        private System.Windows.Forms.PictureBox leftHand;
        private System.Windows.Forms.PictureBox rightFoot;
        private System.Windows.Forms.PictureBox rightHand;
        private System.Windows.Forms.PictureBox rightLeg;
        private System.Windows.Forms.PictureBox leftLeg;
        private System.Windows.Forms.PictureBox leftFoot;
        private System.Windows.Forms.Label hiddenWord;
        private System.Windows.Forms.Label missedLetters;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Label incorrectGuessesLabel;
        private System.Windows.Forms.Label incorrectGuessesCounter;
        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Button gameOverButton;
    }
}

