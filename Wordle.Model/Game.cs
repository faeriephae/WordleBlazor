using System.ComponentModel.DataAnnotations;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class Game : IGame
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public int NumTries { get; set; }

        public virtual Player Player { get; set; }
        public virtual DateWord DateWord { get; set; }
        public int DateWordId { get; set; }
    }
}