namespace Wordle.Models.Interfaces
{
    public interface IPlayer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public char? Language { get; set; }

        public Stat Stats { get; set; }
    }
}
