using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Model;

namespace Wordle.Model.Interfaces
{
    public interface IDateWord
    {
        public int WordId { get; set; }
        public Word Word { get; set; }
        public DateTime Date { get; set; }
    }
}
