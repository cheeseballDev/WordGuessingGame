namespace WordGuessingGame
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
            panel1 = new Panel();
            wordLabel = new Label();
            guessTextBox = new RichTextBox();
            guessButton = new Button();
            guessStatusLabel = new Label();
            listOfGuessedWords = new ListBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(wordLabel);
            panel1.Location = new Point(83, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 114);
            panel1.TabIndex = 0;
            // 
            // wordLabel
            // 
            wordLabel.AutoSize = true;
            wordLabel.Location = new Point(194, 49);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(42, 15);
            wordLabel.TabIndex = 0;
            wordLabel.Text = "WORD";
            wordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guessTextBox
            // 
            guessTextBox.Location = new Point(143, 229);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(305, 30);
            guessTextBox.TabIndex = 2;
            guessTextBox.Text = "";
            // 
            // guessButton
            // 
            guessButton.Location = new Point(230, 265);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(130, 23);
            guessButton.TabIndex = 3;
            guessButton.Text = "button1";
            guessButton.UseVisualStyleBackColor = true;
            guessButton.Click += guessButton_Click;
            // 
            // guessStatusLabel
            // 
            guessStatusLabel.AutoSize = true;
            guessStatusLabel.Location = new Point(55, 12);
            guessStatusLabel.Name = "guessStatusLabel";
            guessStatusLabel.Size = new Size(84, 15);
            guessStatusLabel.TabIndex = 0;
            guessStatusLabel.Text = "GUESS_STATUS";
            guessStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listOfGuessedWords
            // 
            listOfGuessedWords.FormattingEnabled = true;
            listOfGuessedWords.ItemHeight = 15;
            listOfGuessedWords.Location = new Point(3, 49);
            listOfGuessedWords.Name = "listOfGuessedWords";
            listOfGuessedWords.Size = new Size(194, 244);
            listOfGuessedWords.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(listOfGuessedWords);
            panel2.Controls.Add(guessStatusLabel);
            panel2.Location = new Point(551, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 299);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guessButton);
            Controls.Add(guessTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label wordLabel;
        private RichTextBox guessTextBox;
        private Button guessButton;
        private Label guessStatusLabel;
        private ListBox listOfGuessedWords;
        private Panel panel2;
    }
}
