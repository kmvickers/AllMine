using AllMine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllMine.Builders
{
    class OutputBuilder : IOutputBuilder

    {
        public void Output(IBoard board,bool complete)
        {
            Console.Clear();
            Header(board,complete);

            BoardState(board);

            Footer(board,complete);
        }

       

        private void BoardState(IBoard board)
        {
            for (int r = 0; r < board.Cells.GetLength(0); r++)
            {
                for (int c = 0; c < board.Cells.GetLength(1); c++)
                {
                    Console.Write(board.Cells[r, c] + "\t");
                }
                Console.WriteLine();
            }

           


        }

        private void Footer(IBoard board, bool complete)
        {
            if (complete)
            {
                Console.WriteLine(board.MinesHit >= 2 ? "Game Over" : "Game Complete");
                Console.WriteLine("Press Enter to Close");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("            ");
                Console.WriteLine("Press u, d, l or r to move");
            }
        }

        private void Header(IBoard board,bool complete)
        {
            Console.SetCursorPosition(0, 0);
            if (!complete)
                Console.WriteLine("Press the Escape (Esc) key to Exit".PadRight(50));

            Console.WriteLine("Current Position: ");
            Console.WriteLine("Row:    {0}", board.CurrentLocation().Row+1);
            Console.WriteLine("Column: {0}", board.CurrentLocation().Column+1);
            Console.WriteLine("            ");
            Console.WriteLine("Total Mines: {0}   Mines Hit: {1}",board.Mines, board.MinesHit);
            Console.WriteLine("            ");
        }
    }
}
