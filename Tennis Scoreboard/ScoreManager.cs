namespace Tennis_Scoreboard
{
    public class ScoreManager
    {
        private Player player1 = new Player(1);
        private Player player2 = new Player(2);

        public void PlayerScores(int playerId)
        {
            if (playerId == 1)
            {
                player1.ScorePoint();
                CheckGame(player1, player2);
            }
            else
            {
                player2.ScorePoint();
                CheckGame(player2, player1);
            }
        }

        //Check if the scoring player has won a game
        private void CheckGame(Player scoringPlayer, Player otherPlayer)
        {
            if (scoringPlayer.Points >= 4 && scoringPlayer.Points - otherPlayer.Points >= 2)
            {
                scoringPlayer.WinGame();
                otherPlayer.ResetPoints();
                CheckSet(scoringPlayer, otherPlayer);
            }
        }

        //Check if the scoring player has won a set
        private void CheckSet(Player scoringPlayer, Player otherPlayer)
        {
            if (scoringPlayer.Games >= 6 && scoringPlayer.Games - otherPlayer.Games >= 2)
            {
                scoringPlayer.WinSet();
                otherPlayer.ResetGames();
            }
        }

        //Reset players previous scores 
        public void ResetAll()
        {
            player1.ResetScore();
            player2.ResetScore();
        }

        //Return the current score in tennis terms
        public string Score()
        {
            if (player1.Points >= 3 && player2.Points >= 3)
            {
                if (player1.Points == player2.Points)
                {
                    return "Deuce";
                }
                else if (player1.Points > player2.Points)
                {
                    return "Advantage Player 1";
                }
                else
                {
                    return "Advantage Player 2";
                }
            }
            return $"{TranslatePoints(player1.Points)} - {TranslatePoints(player2.Points)}";
        }

        //Convert the point numbers into tennis terms
        private string TranslatePoints(int points)
        {
            switch (points)
            {
                case 0: return "Love";
                case 1: return "Fifteen";
                case 2: return "Thirty";
                case 3: return "Forty";
                default: return "";
            }
        }

        //Return the current game score
        public string DisplayGames()
        {
            return $"{player1.Games} - {player2.Games}";
        }

        //Return the current set score
        public string DisplaySets()
        {
            return $"{player1.Sets} - {player2.Sets}";
        }
    }
}
