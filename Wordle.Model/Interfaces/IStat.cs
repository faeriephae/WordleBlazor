﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Model.Interfaces
{
    public interface IStat
    {
        public int Id { get; set; }

        //Game has Player.Id
        int GameId { get; set; }
        public Game Game { get; set; }

        int GamesPlayed { get; set; }
        int GamesWon { get; set; }
        int MaxStreak { get; set; }
        int Streak { get; set; }
        int WinPercentage { get; set; }
    }
}