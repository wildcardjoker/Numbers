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
            lblRange = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            lblWinBanner = new Label();
            lblGuessCount = new Label();
            lblResult = new Label();
            btnForfeit = new Button();
            btnPlayAgain = new Button();
            btnQuit = new Button();
            txtMin = new TextBox();
            txtMax = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnStartGame = new Button();
            cboDifficulty = new ComboBox();
            label5 = new Label();
            panelCustomGame = new Panel();
            panelCustomGame.SuspendLayout();
            SuspendLayout();
            // 
            // lblRange
            // 
            lblRange.AutoSize = true;
            lblRange.Location = new Point(12, 91);
            lblRange.Name = "lblRange";
            lblRange.Size = new Size(104, 15);
            lblRange.TabIndex = 0;
            lblRange.Text = "Range of numbers";
            lblRange.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(278, 15);
            label2.TabIndex = 1;
            label2.Text = "Try to guess the number in the least number of tries";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Your Guess?";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(152, 113);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(47, 23);
            txtGuess.TabIndex = 3;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(224, 113);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(75, 23);
            btnGuess.TabIndex = 4;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // lblWinBanner
            // 
            lblWinBanner.AutoSize = true;
            lblWinBanner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWinBanner.Location = new Point(12, 143);
            lblWinBanner.Name = "lblWinBanner";
            lblWinBanner.Size = new Size(321, 21);
            lblWinBanner.TabIndex = 5;
            lblWinBanner.Text = "Winner! [Number] is the correct number!";
            // 
            // lblGuessCount
            // 
            lblGuessCount.AutoSize = true;
            lblGuessCount.Location = new Point(12, 164);
            lblGuessCount.Name = "lblGuessCount";
            lblGuessCount.Size = new Size(74, 15);
            lblGuessCount.TabIndex = 6;
            lblGuessCount.Text = "Guess Count";
            lblGuessCount.Visible = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 143);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(73, 15);
            lblResult.TabIndex = 7;
            lblResult.Text = "Guess Result";
            lblResult.Visible = false;
            // 
            // btnForfeit
            // 
            btnForfeit.Location = new Point(305, 112);
            btnForfeit.Name = "btnForfeit";
            btnForfeit.Size = new Size(75, 23);
            btnForfeit.TabIndex = 8;
            btnForfeit.Text = "Give Up";
            btnForfeit.UseVisualStyleBackColor = true;
            btnForfeit.Visible = false;
            btnForfeit.Click += btnForfeit_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Location = new Point(12, 182);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(75, 23);
            btnPlayAgain.TabIndex = 9;
            btnPlayAgain.Text = "Play again";
            btnPlayAgain.UseVisualStyleBackColor = true;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(93, 182);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(62, 3);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(54, 23);
            txtMin.TabIndex = 11;
            txtMin.KeyPress += txtValue_KeyPress;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(155, 3);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(54, 23);
            txtMax.TabIndex = 12;
            txtMax.KeyPress += txtValue_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 6);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 13;
            label3.Text = "Between";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 6);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 14;
            label4.Text = "and";
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(305, 26);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(75, 23);
            btnStartGame.TabIndex = 15;
            btnStartGame.Text = "Go!";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // cboDifficulty
            // 
            cboDifficulty.FormattingEnabled = true;
            cboDifficulty.Location = new Point(73, 27);
            cboDifficulty.Name = "cboDifficulty";
            cboDifficulty.Size = new Size(121, 23);
            cboDifficulty.TabIndex = 16;
            cboDifficulty.SelectedIndexChanged += cboDifficulty_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 30);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 17;
            label5.Text = "Difficulty";
            // 
            // panelCustomGame
            // 
            panelCustomGame.Controls.Add(label3);
            panelCustomGame.Controls.Add(txtMin);
            panelCustomGame.Controls.Add(label4);
            panelCustomGame.Controls.Add(txtMax);
            panelCustomGame.Location = new Point(12, 56);
            panelCustomGame.Name = "panelCustomGame";
            panelCustomGame.Size = new Size(225, 32);
            panelCustomGame.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 214);
            Controls.Add(panelCustomGame);
            Controls.Add(label5);
            Controls.Add(cboDifficulty);
            Controls.Add(btnStartGame);
            Controls.Add(btnQuit);
            Controls.Add(btnPlayAgain);
            Controls.Add(btnForfeit);
            Controls.Add(lblResult);
            Controls.Add(lblGuessCount);
            Controls.Add(lblWinBanner);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblRange);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Guess the number";
            Load += Form1_Load;
            panelCustomGame.ResumeLayout(false);
            panelCustomGame.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtMin;
        private TextBox txtMax;
        private Label label3;
        private Label label4;
        private Button btnStartGame;
        private ComboBox cboDifficulty;
        private Label label5;
        private Panel panelCustomGame;
    }
}