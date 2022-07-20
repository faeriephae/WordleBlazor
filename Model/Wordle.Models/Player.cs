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
        public Player()
        {
        }

        [Key]
        public int Id  => throw new NotImplementedException();

        [Required, StringLength(100)]
        public string Name => throw new NotImplementedException();

        [Required, StringLength(200)]
        public string Email => throw new NotImplementedException();

        [StringLength(2), Column( TypeName="varchar")]
        public char Language => throw new NotImplementedException();

    }
}
