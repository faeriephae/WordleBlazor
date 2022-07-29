namespace Wordle.Models.Interfaces
{
    public interface IGame
    {
        public int Id { get; set; }
        public DateTime CurrentDate { get; set; }
        public int NumTries { get; set; }

        //FK -> 1 game
        public int CurrentWordId { get; set; }
        public Word Word { get; set; }

        //FK
        public int CurrentPlayerId { get; set; }
        public Player Player { get; set; }

    }
}
