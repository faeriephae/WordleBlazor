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
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Key, Required]
        public int PlayerId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int GamesPlayed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public int GamesWon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public int MaxStreak { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public int Streak { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public int WinPercentage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual Player Player { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
