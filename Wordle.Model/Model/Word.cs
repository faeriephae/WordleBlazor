﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Interfaces;

namespace Wordle.Model.Model
{
    public class Word : IWord
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(5)]
        public string Term { get; set; }
    }
}