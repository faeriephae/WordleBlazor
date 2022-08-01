using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class Player : IPlayer
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char? Language { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICollection<IGame> Games { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
