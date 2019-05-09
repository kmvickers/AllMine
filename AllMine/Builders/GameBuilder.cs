using AllMine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllMine.Builders
{
    class GameBuilder:IGameBuilder
    {
       
        IGame IGameBuilder.Build(int height, int width, int mines)
        {
            IGame g = new Game(height,width,mines);

            return g; 
        }
    }

}
