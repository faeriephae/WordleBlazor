using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Model.Interfaces
{
    public interface IGame
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int DateWordId { get; set; }
        public int NumTries { get; set; }

        public Player Player { get; set; }
    }
}
