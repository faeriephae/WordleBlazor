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
        public int Id => throw new NotImplementedException();

        [Key, Required]
        public int GameId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Game Games { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Key, Required]
        public int PlayerId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Player player { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

    }
}
