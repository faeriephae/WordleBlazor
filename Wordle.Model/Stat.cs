using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class Stat : IStat
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int GameId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Game Game { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int GamesPlayed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int GamesWon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxStreak { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Streak { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int WinPercentage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
