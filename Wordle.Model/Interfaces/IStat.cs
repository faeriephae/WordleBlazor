using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Model;

namespace Wordle.Model.Interfaces
{
    public interface IStat
    {
        public int Id { get; set; }
        int PlayerId { get; set; }
        int GamesPlayed { get; set; }
        int GamesWon { get; set; }
        int MaxStreak { get; set; }
        int Streak { get; set; }
        int WinPercentage { get; set; }

        public Player Player { get; set; }
    }
}
