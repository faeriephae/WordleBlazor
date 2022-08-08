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
        public string IP { get; set; }
        public char Language { get; set; }
        public string Email { get; set; }

        //Idk if the player needs this but it can't hurt
        public ICollection<Game> Games { get; set; }
    }
}
