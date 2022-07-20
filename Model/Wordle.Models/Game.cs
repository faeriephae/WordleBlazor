using System.ComponentModel.DataAnnotations;

namespace Wordle.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
    }
}