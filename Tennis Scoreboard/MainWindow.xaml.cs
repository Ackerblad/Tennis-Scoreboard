using System.Windows;

namespace Tennis_Scoreboard
{
    public partial class MainWindow : Window
    {
        private ScoreManager scoreManager = new ScoreManager();

        public MainWindow()
        {
            InitializeComponent();
            UpdateScoreboard();
        }

        //Player buttons, updates the score for the corresponding player
        private void PlayerScoreButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == player1Button)
            {
                scoreManager.PlayerScores(1);
            }
            else if (sender == player2Button)
            {
                scoreManager.PlayerScores(2);
            }
            UpdateScoreboard();
        }

        //Reset all scores
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            scoreManager.ResetAll();
            UpdateScoreboard();
        }

        //Update the scoreboard UI with the latest scores
        private void UpdateScoreboard()
        {
            pointLabel.Content = scoreManager.Score();
            gameLabel.Content = scoreManager.DisplayGames();
            setLabel.Content = scoreManager.DisplaySets();
        }
    }
}