namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_02
{
    using System;
    #region INCLUDE
    using System.Collections.Generic;

    public class Program
    {
        #region EXCLUDE
        public static void Main()
        {
            Sketch();
        }
        #endregion EXCLUDE

        public static void Sketch()
        {
            Stack<Cell> path = new Stack<Cell>();
            Cell currentPosition;
            ConsoleKeyInfo key;
            #region EXCLUDE
            Console.WriteLine("Use arrow keys to draw. X to exit.");
            for(int i = 2; i < Console.WindowHeight; i++)
            {
                Console.WriteLine();
            }

            currentPosition = new Cell(Console.WindowWidth / 2, Console.WindowHeight / 2);
            path.Push(currentPosition);
            FillCell(currentPosition);
            #endregion EXCLUDE

            do
            {
                // Etch in the direction indicated by the
                // arrow keys that the user enters
                key = Move();

                switch(key.Key)
                {
                    case ConsoleKey.Z:
                        // Undo the previous Move
                        if(path.Count >= 1)
                        {
                            #region HIGHLIGHT
                            currentPosition = (Cell)path.Pop();
                            #endregion HIGHLIGHT
                            Console.SetCursorPosition(
                                currentPosition.X, currentPosition.Y);
                            #region EXCLUDE
                            FillCell(currentPosition, ConsoleColor.Black);
                            #endregion EXCLUDE
                            Undo();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        #region EXCLUDE
                        if (Console.CursorTop < Console.WindowHeight - 2)
                        {
                            currentPosition = new Cell(
                                Console.CursorLeft, Console.CursorTop + 1);
                        }
                        path.Push(currentPosition);
                        FillCell(currentPosition);
                        break;
                        #endregion EXCLUDE
                    case ConsoleKey.UpArrow:
                        #region EXCLUDE
                        if (Console.CursorTop > 1)
                        {
                            currentPosition = new Cell(
                                Console.CursorLeft, Console.CursorTop - 1);
                        }
                        path.Push(currentPosition);
                        FillCell(currentPosition);
                        break;
                        #endregion EXCLUDE
                    case ConsoleKey.LeftArrow:
                        #region EXCLUDE
                        if (Console.CursorLeft > 1)
                        {
                            currentPosition = new Cell(
                                Console.CursorLeft - 1, Console.CursorTop);
                        }
                        path.Push(currentPosition);
                        FillCell(currentPosition);
                        break;
                        #endregion EXCLUDE
                    case ConsoleKey.RightArrow:
                        // SaveState()
                        if(Console.CursorLeft < Console.WindowWidth - 2)
                        {
                            currentPosition = new Cell(
                                Console.CursorLeft + 1, Console.CursorTop);
                        }
                        #region HIGHLIGHT
                        path.Push(currentPosition);
                        #endregion HIGHLIGHT
                        #region EXCLUDE
                        FillCell(currentPosition);
                        #endregion EXCLUDE
                        break;

                    default:
                        Console.Beep();
                        break;
                }
            }
            while(key.Key != ConsoleKey.X);  // Use X to quit.
        }
        #region EXCLUDE
        private static ConsoleKeyInfo Move()
        {
            return Console.ReadKey(true);
        }

        private static void Undo()
        {
            // stub
        }

        private static void FillCell(Cell cell)
        {
            FillCell(cell, ConsoleColor.White);
        }

        private static void FillCell(Cell cell, ConsoleColor color)
        {
            Console.SetCursorPosition(cell.X, cell.Y);
            Console.BackgroundColor = color;
            Console.Write(' ');
            Console.SetCursorPosition(cell.X, cell.Y);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        #endregion EXCLUDE
    }

    public struct Cell
    {
        public int X { get; }
        public int Y { get; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    #endregion INCLUDE
}
