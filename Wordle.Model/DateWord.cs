﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class DateWord : IDateWord
    {
        [Key]
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public int WordId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Word Word { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Required]
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}