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
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required, StringLength(100)]
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required, StringLength(200)]
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [StringLength(2), Column( TypeName="varchar")]
        public char Language { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
