namespace NumbersWinforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRange = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblWinBanner = new System.Windows.Forms.Label();
            this.lblGuessCount = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnForfeit = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(12, 24);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(104, 15);
            this.lblRange.TabIndex = 0;
            this.lblRange.Text = "Range of numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Try to guess the number in the least number of tries";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Guess?";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(88, 51);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(47, 23);
            this.txtGuess.TabIndex = 3;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(141, 50);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblWinBanner
            // 
            this.lblWinBanner.AutoSize = true;
            this.lblWinBanner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWinBanner.Location = new System.Drawing.Point(12, 81);
            this.lblWinBanner.Name = "lblWinBanner";
            this.lblWinBanner.Size = new System.Drawing.Size(321, 21);
            this.lblWinBanner.TabIndex = 5;
            this.lblWinBanner.Text = "Winner! [Number] is the correct number!";
            // 
            // lblGuessCount
            // 
            this.lblGuessCount.AutoSize = true;
            this.lblGuessCount.Location = new System.Drawing.Point(12, 115);
            this.lblGuessCount.Name = "lblGuessCount";
            this.lblGuessCount.Size = new System.Drawing.Size(74, 15);
            this.lblGuessCount.TabIndex = 6;
            this.lblGuessCount.Text = "Guess Count";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 86);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 15);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Guess Result";
            this.lblResult.Visible = false;
            // 
            // btnForfeit
            // 
            this.btnForfeit.Location = new System.Drawing.Point(222, 51);
            this.btnForfeit.Name = "btnForfeit";
            this.btnForfeit.Size = new System.Drawing.Size(75, 23);
            this.btnForfeit.TabIndex = 8;
            this.btnForfeit.Text = "Give Up";
            this.btnForfeit.UseVisualStyleBackColor = true;
            this.btnForfeit.Click += new System.EventHandler(this.btnForfeit_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(12, 133);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.btnPlayAgain.TabIndex = 9;
            this.btnPlayAgain.Text = "Play again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(93, 133);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 165);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnForfeit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblGuessCount);
            this.Controls.Add(this.lblWinBanner);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Guess the number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRange;
        private Label label2;
        private Label label1;
        private TextBox txtGuess;
        private Button btnGuess;
        private Label lblWinBanner;
        private Label lblGuessCount;
        private Label lblResult;
        private Button btnForfeit;
        private Button btnPlayAgain;
        private Button btnQuit;
    }
}