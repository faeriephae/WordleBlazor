using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Models.Interfaces;

namespace Wordle.Models
{
    public class Stat : IStat
    {
        [Key]
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        //1 Stat belongs to 1 game
        [Key, Required]
        public int GameId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Game Game { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public int GamesPlayed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public int GamesWon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public int MaxStreak { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public int Streak { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public int WinPercentage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //One Stat has many Games
        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
