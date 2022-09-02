using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Model
{
    public class Board
    {
        public Board( int id )
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
