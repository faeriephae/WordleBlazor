using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Models.Interfaces;

namespace Wordle.Models
{
    public class Row : IShape
    {
        //to keep tracks of active rows
        private static int rowsAlive;
        public Row()
        {
            SetId();
        }

        public new int Id { get; set; }

        private List<Square> squares;

        public List<Square> GetSquares()
        {
            return squares;
        }

        public void SetSquares( List<Square> value )
        {
            squares = value;
        }

        public int Width { get; set; }
        public int Height {get; set; }

        public void SetId()
        {
            Id = rowsAlive++;
            rowsAlive = Id;
            Board.NumRows = rowsAlive;
        }
    }
}
