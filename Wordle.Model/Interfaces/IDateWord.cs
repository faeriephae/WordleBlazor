﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Model.Interfaces
{
    public interface IDateWord
    {
        public int Id { get; set; }
        public int WordId { get; set; }
        public DateTime Date { get; set; }
    }
}
