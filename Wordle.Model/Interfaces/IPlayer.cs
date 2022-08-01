using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Model.Interfaces
{
    public interface IPlayer
    {
        public int Id { get; set; }
        public string? IP { get; set; }
        public char? Language { get; set; }
    }
}
