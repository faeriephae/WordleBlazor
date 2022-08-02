﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Model.Interfaces
{
    public interface IWord
    {
        public int Id { get; set; }
        public string Term { get; set; }

        //Optional
        public int Difficulty { get; set; }
    }
}
