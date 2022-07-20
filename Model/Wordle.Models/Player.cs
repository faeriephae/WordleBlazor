using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Wordle.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

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

        [StringLength(2), Column( TypeName="varchar")]
        public char? Language { get; set; }


        //1 player n games
        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
