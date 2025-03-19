namespace WordGuessingGame
{
    public partial class Form1 : Form
    {

        private String[] words = { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew", "kiwi", "lemon", "mango", "nectarine", "orange", "papaya", "quince", "raspberry", "strawberry", "tangerine", "watermelon" };
        private String jumbledWord, userGuess, wordToGuess;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            int randomWordIndex = random.Next(0, words.Length);
            wordToGuess = words[randomWordIndex];
            char[] wordToChars = wordToGuess.ToCharArray();
            int randomIndex = random.Next(0, wordToChars.Length);
            for (int i = randomIndex; i < wordToChars.Length; i++)
            {
                wordToChars[i] = '#';
            }
            jumbledWord = new string(wordToChars);
            wordLabel.Text = jumbledWord;
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            userGuess = guessTextBox.Text;

            if (userGuess.Equals(wordToGuess))
            {
                wordLabel.Text = wordToGuess;
                MessageBox.Show("Congratulations! You have guessed the word correctly.");
                return;
            }
            guessStatusLabel.Text = "Wrong guess! Try again.";
            listOfGuessedWords.Items.Add(userGuess);
            
        }
    }
}
