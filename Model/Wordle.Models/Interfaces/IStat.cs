namespace Wordle.Models.Interfaces
{
    public interface IStat
    {
        int PlayerId { get; set; }
        public Player Player { get; set; }

        int GamesPlayed { get; set; }
        int GamesWon { get; set; }
        int MaxStreak { get; set; }
        int Streak { get; set; }
        int WinPercentage { get; set; }

        //FK
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}