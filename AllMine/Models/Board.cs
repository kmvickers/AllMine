using System;
using System.Collections.Generic;
using System.Text;

namespace AllMine.Models
{
    class Board : IBoard
    {
        const char ESC = '\x1B';
        public ICell[,] Cells { get ; set; }

        private int currentColumn = 0;
        private int currentRow = 0;

       public Board(Cell[,] cells)
        {
            Cells = cells;

        }
        public int MinesHit { get; set; }
        public int Mines { get; set; }

        public ICell CurrentLocation()
        {
            return Cells[currentRow, currentColumn];
        }

        public bool Move(char direction)
        {
            switch(char.ToLower(direction))
            {
                case 'u':
                    currentRow--;
                    break;
                case 'd':
                    currentRow++;
                    break;
                case 'l':
                    currentColumn--;
                    break;
                case 'r':
                    currentColumn++;
                    break;
                case ESC:
                    return false;
                    break;
            }
            if (currentRow < 0)
                currentRow = 0;
            if (currentRow >= Cells.GetLength(0))
                currentRow = Cells.GetLength(0)-1;

            if (currentColumn < 0)
                currentColumn = 0;
            if (currentColumn >= Cells.GetLength(1))
                currentColumn = Cells.GetLength(1)-1;


            CurrentLocation().IsRevealed = true;

            if (CurrentLocation().IsMine)
                MinesHit++ ;

            return true;

        }
    }
}
