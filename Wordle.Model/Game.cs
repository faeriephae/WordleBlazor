using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class Game : IGame
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CurrentDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumTries { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int WordId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Word Word { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PlayerId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Player? Player { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}