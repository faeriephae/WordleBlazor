using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Models.Interfaces
{
    public interface IPlayer
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
        public char Language { get; }
    }
}
