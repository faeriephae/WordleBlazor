using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class Player : IPlayer
    {
        [Key]
        public int Id { get; set; }
        public string IP { get; set; }

        [StringLength( 2 )]
        public string Language { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
