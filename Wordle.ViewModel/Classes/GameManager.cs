using Microsoft.AspNetCore.Components;

namespace Wordle.ViewModel.Classes
{
    public class GameManager
    {
        //All letters
        public string[,] Field { get; set; }
        public string Term { get; set; } = "HELLO";
        public int NumberRows { get; set; }
        public int NumberColumns { get; set; }
        public ElementReference[,] Squares { get; set; }


        public GameManager( int numberRows, int numberColumns )
        {
            Field = new string[ numberRows, numberColumns ];
            NumberRows = numberRows;
            NumberColumns = numberColumns;
            Squares = new ElementReference[ numberRows, numberColumns ];
        }

        /// <summary>
        /// Checks letter validity.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public string CheckLetter( int row, int column )
        {
            //has letter, right place
            if( Field[ row, column ].ToString() == Term[ column ].ToString() )
            {
                return "g";
            }

            //has letter, wrong place
            else if( Term.Contains( Field[ row, column ] ) )
            {
                return "o";
            }

            //neither
            else
            {
                return "b";
            }
        }
    }
}
