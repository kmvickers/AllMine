using System;
using System.Collections.Generic;
using System.Text;

namespace AllMine.Models
{
    interface ICell
    {
        bool IsRevealed { get; set; }
        bool IsMine { get; set; }   
        int Row { get; set; }

        int Column { get; set; }

        //could add neighbouring mines 

    }
}
