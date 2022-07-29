using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wordle.Models.Interfaces;

namespace Wordle.Models
{
    public class Player : IPlayer
    {

        [Key, Required]
        public int Id { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(200)]
        public string? Email { get; set; }

        [StringLength(2), Column(TypeName = "varchar")]
        public char? Language { get; set; }


        //1 player n games
        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
        public Stat Stats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
