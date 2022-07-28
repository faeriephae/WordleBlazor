using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
