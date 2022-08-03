using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Model
{
    public class Row
    {
        public Row( int id )
        {
            Id = id;
        }
        public int Id { get; set; }
        public List<Square>? Squares { get; set; }
    }
}
