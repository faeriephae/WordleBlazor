using Microsoft.AspNetCore.Components;

namespace Wordle.ViewModel.Classes
{
    public class GameManager
    {
        //All letters
        public string[,] Field { get; set; }

        //Word
        public string Term { get; set; } = "HELLO";

        //How many rows does the game have?
        public int NumberRows { get; set; }

        //How many columns does the game have?
        public int NumberColumns { get; set; }

        public ElementReference[,] Squares { get; set; }

        public GameManager(int numberRows, int numberColumns)
        {
            Field = new string[numberRows, numberColumns];
            NumberRows = numberRows;
            NumberColumns = numberColumns;
            Squares = new ElementReference[numberRows, numberColumns];
        }

        public async void FocusNextSquare(int row, int col)
        {
            await Squares[row, col].FocusAsync();
        }

        public string CheckRow(int row, int column)
        {
            if (Field[row, column].ToString() == Term[column].ToString())
            {
                return "g";
            }
            else if (Term.Contains(Field[row, column]))
            {
                return "o";
            }
            else
            {
                return "b";
            }
        }
    }
}
