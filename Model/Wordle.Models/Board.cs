namespace Wordle.Models
{
    public class Board
    {
        public Board()
        {

        }

        public static List<Row> Rows { get; set; }
        public static int NumRows = 6;
        public static int NumSquares = (6 * 5);

    }
}
