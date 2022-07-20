using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Models.Interfaces;

namespace Wordle.Models
{
    public class Word : IWord
    {
        [Key]
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //Seven, in case difficulty is implemented by making words longer
        [Required, StringLength(7)] 
        public string Term { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        
        public int Difficulty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
