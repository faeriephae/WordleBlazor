using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Model
{
    public class Square
    {
        public Square(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public char Letter { get; set; }
    }
}
