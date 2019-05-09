using CommandLine.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllMine.Command
{
    class Args
    {
        [OptionalArgument(Settings.BoardWidth, "w", "width")]
        public int Width { get; set; }

        [OptionalArgument(Settings.BoardHeight, "h", "height")]
        public int Height { get; set; }

        [OptionalArgument(Settings.MinesCount, "m", "mines")]
        public int Mines { get; set; }
    }
}
