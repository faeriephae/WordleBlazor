using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class Player : IPlayer
    {
        [Key]
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [StringLength(100)]
        public string IP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [StringLength(2), Column(TypeName = "varchar")]
        public char? Language { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual ICollection<IGame> Games { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
