﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Model;

namespace Wordle.Model.Interfaces
{
    public interface IPlayer
    {
        public int Id { get; set; }
        public string IP { get; set; }
        public string Language { get; set; }
        public string Email { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
