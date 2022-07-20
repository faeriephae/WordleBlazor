namespace Wordle.Models.Interfaces
{
    public interface IStat
    {
        int Id { get; }
        int GamesPlayed { get; set; }
        int GamesWon { get; set; }
        int MaxStreak { get; set; }
        int Streak { get; set; }
        int WinPercentage { get; set; }

        public int GameId { get; set; }
        public Game Games { get; set; }

        //FK
        public int PlayerId { get; set; }
        public Player player { get; set; }
    }
}