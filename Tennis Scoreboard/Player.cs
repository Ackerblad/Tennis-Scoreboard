namespace Tennis_Scoreboard
{
    public class Player
    {
        public int PlayerId { get; private set; }
        public int Points { get; private set; }
        public int Games { get; private set; }
        public int Sets { get; private set; }

        public Player(int playerId)
        {
            PlayerId = playerId;
        }

        public void ScorePoint()
        {
            Points++;
        }

        //Add a game and reset points 
        public void WinGame()
        {
            Games++;
            ResetPoints();
        }

        //Add a set and reset games
        public void WinSet()
        {
            Sets++;
            ResetGames();
        }

        //Reset points 
        public void ResetPoints()
        {
            Points = 0;
        }

        //Reset games
        public void ResetGames()
        {
            Games = 0; 
        }

        //Reset all previous scores
        public void ResetScore()
        {
            ResetPoints();
            ResetGames();
            Sets = 0;
        }
    }
}
