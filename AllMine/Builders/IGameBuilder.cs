using AllMine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllMine.Builders
{
    interface IGameBuilder
    {
        IGame Build(int height, int width, int mines);

       
    }
}
