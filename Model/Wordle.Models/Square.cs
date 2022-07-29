using Wordle.Models.Interfaces;

namespace Wordle.Models
{
    public class Square : IShape
    {
        //to keep track of the active square number
        private static int squaresAlive;

        public Square()
        {
            SetId();
        }

        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Adds squares to row.
        /// </summary>
        /// <param name="sq1"></param>
        /// <param name="sq2"></param>
        /// <param name="sq3"></param>
        /// <param name="sq4"></param>
        /// <param name="sq5"></param>
        public static void AddSquaresToRow( Square sq1, Square sq2, Square sq3, Square sq4, Square sq5, Row row )
        {
            row.GetSquares().Add(sq1);
            row.GetSquares().Add(sq2);
            row.GetSquares().Add(sq3);
            row.GetSquares().Add(sq4);
            row.GetSquares().Add(sq5);
        }

        /// <summary>
        /// Adds squares to row.
        /// </summary>
        /// <param name="sq"></param>
        public void AddSquareToRow( Square sq, Row row )
        {
            row.GetSquares().Add(sq);
        }

        public void SetId()
        {
            Id = squaresAlive++;
            squaresAlive = Id;
            Board.NumSquares = squaresAlive;
        }
    }
}
