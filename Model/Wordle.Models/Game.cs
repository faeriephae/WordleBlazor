using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wordle.Models.Interfaces;

namespace Wordle.Models
{
    public class Game : IGame
    {
        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName = "DATETIME2")]
        public DateTime CurrentDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumTries { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //FK -> 1 Game has one *correct* word
        public int CurrentWordId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Word Word { get; set; }


        public int CurrentPlayerId { get; set; }
        public Player? Player { get; set; }

        //One game has many *tried* words
        public virtual ICollection<Word> Words { get; set; } = new List<Word>();

    }
}