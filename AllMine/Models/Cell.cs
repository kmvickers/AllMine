using System;
using System.Collections.Generic;
using System.Text;

namespace AllMine.Models
{
    class Cell : ICell
    {
        public bool IsRevealed { get; set; }
        public bool IsMine { get ; set; }
        public int Row { get;set ; }
        public int Column {get ;set; }


        /* Output its own symbol for the board 
         * Should we take into account if I am the current positon and 
         * change the symbol (lowercase) 
         * 
         */
        public override string ToString()
        {
            if (IsRevealed)
            {
                return IsMine ? "X" : "O";

            }

            return "?";
        }
    }
}
