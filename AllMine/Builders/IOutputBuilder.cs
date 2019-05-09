using AllMine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllMine.Builders
{
    interface IOutputBuilder
    {
        void Output(IBoard board, bool complete);


    }
}
