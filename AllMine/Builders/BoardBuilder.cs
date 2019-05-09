using System;
using System.Collections.Generic;
using System.Text;
using AllMine.Models;

namespace AllMine.Builders
{
    class BoardBuilder : IBoardBuilder
    {

        public IBoard Build(int height, int width, int mines)
        {
            IBoard board = new Board(new Cell [height,width]);

            InitBoard(board);

            PopulateBoard(board, mines);


            return board;

        }

       

        private void InitBoard(IBoard b)
        {

            for (int r= 0; r < b.Cells.GetLength(0); r++)
            {
                for (int c = 0; c < b.Cells.GetLength(1); c++)
                {
                    var cell = new Cell
                    {
                        Row = r,
                        Column = c
                    };

                    b.Cells[r, c] = cell;
                }

            }
           // b.CurrentLocation = GameSettings.BOARD_HEIGHT - 1; //start at the bottom
            b.CurrentLocation().IsRevealed = true; // initilze first sqaure
        }


        /*
         * Get the number of mines and randomly add to the board 
         * making sure the first position cant be a mine !! that wouldnt be fair 
         * Think about populating the surrounding mines variable for a cell 
         */
        private void PopulateBoard(IBoard b, int mines)
        {
            int mineCount = 0;
            Random random = new Random(DateTime.Now.Second);
            while (mineCount < mines)
            {
               
                int randomRow = random.Next(0, b.Cells.GetLength(0));
                int randomColumn = random.Next(0, b.Cells.GetLength(1));

                if (randomRow == 0 && randomColumn == 0)
                    continue;
                if (b.Cells[randomRow, randomColumn].IsMine) //already is a mine
                    continue;

                b.Cells[randomRow, randomColumn].IsMine = true;
                mineCount++;
            }
            b.Mines = mines;
        }
    }
}
