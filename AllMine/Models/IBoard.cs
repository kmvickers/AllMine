using System;
using System.Collections.Generic;
using System.Text;

namespace AllMine.Models
{
    interface IBoard
    {

        ICell[,] Cells { get; set; }

        ICell CurrentLocation();

        bool Move(char direction);

        int MinesHit { get; set; }
        int Mines { get; set; }

    }
}
