using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class Game : IGame
    {
        [Key]
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        [Required, Column(TypeName = "DATETIME2")]
        public DateTime CurrentDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int NumTries { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int WordId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual Word Word { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int PlayerId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual Player? Player { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}