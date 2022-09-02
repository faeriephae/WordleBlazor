using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class Stat : IStat
    {
        [Key]
        public int Id { get; set; }
        [Key, Required]
        public int PlayerId { get; set; }
        public int GamesPlayed { get; set; }

        [Required]
        public int GamesWon { get; set; }

        [Required]
        public int MaxStreak { get; set; }

        [Required]
        public int Streak { get; set; }

        [Required]
        public int WinPercentage { get; set; }

        public virtual Player Player { get; set; }
    }
}
