using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wordle.Models.Interfaces;

namespace Wordle.Models
{
    public class Game : IGame
    {
        [Key]
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required, Column(TypeName = "DATETIME2")]
        public DateTime CurrentDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //FK
        public int CurrentWordId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Word Word { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}