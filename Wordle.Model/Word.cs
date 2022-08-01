using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class Word : IWord
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Term { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Difficulty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
