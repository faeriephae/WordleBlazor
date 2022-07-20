using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Models.Interfaces
{
    public interface IWord
    {
        public int Id { get; set; }
        public string Term { get; set; }
        public int Difficulty { get; set; }
    }
}
