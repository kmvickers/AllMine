using System;
using System.Collections.Generic;
using System.Text;

using AllMine.Models;

namespace AllMine.Builders
{
    interface IBoardBuilder
    {
        IBoard Build(int height, int width, int mines);
    }
}
