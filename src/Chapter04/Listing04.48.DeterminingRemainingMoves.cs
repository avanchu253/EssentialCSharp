namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_48
{
    public class TicTacToe // Declares the TicTacToe class
    {
        public static void Main() // Declares the entry point of the program
        {
            #region INCLUDE
            // Hardcode initial board as follows
            // ---+---+---
            //  1 | 2 | 3
            // ---+---+---
            //  4 | 5 | 6
            // ---+---+---
            //  7 | 8 | 9
            // ---+---+---
            char[] cells = {
                '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };

            Console.Write(
                "The available moves are as follows: ");

            // Write out the initial available moves
            foreach(char cell in cells)
            {
                if(cell != 'O' && cell != 'X')
                {
                    Console.Write($"{ cell } ");
                }
            }
            #endregion INCLUDE
        }
    }
}
