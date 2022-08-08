using System.ComponentModel.DataAnnotations;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class Game : IGame
    {
        [Key]
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public int PlayerId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public int DateWordId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumTries { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual Player Player { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual DateWord DateWord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}