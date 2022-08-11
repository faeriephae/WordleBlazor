using Microsoft.AspNetCore.Components;

namespace Wordle.ViewModel.Classes
{
    public class GameManager
    {
        public string[,] Field { get; set; }

        public string Term { get; set; } = "HELLO";

        public int NumberRows { get; set; }

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

        public string[] CheckRow(int row)
        {
            string[] check = new string[NumberColumns];
            for (int i = 0; i < NumberColumns; i++)
            {
                if (Field[row, i].ToString() == Term[i].ToString())
                {
                    check[i] = "g";
                }
                else if (Term.Contains(Field[row, i]))
                {
                    check[i] = "o";
                }
                else
                {
                    check[i] = "b";
                }
            }
            return check;
        }
    }
}
