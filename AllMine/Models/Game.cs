using AllMine.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllMine.Models
{
    class Game : IGame
    {

        private IBoard Board;

        private IOutputBuilder Output;
        private bool Escaped = false;

        public bool Complete => Board.MinesHit >= 2 || Board.CurrentLocation().Column == Board.Cells.GetLength(1)-1||Escaped;


        public Game(int height, int width, int mines)
        {
            var BoardBuilder = Injector.StartUp.InjectionContainer.GetInstance<IBoardBuilder>();

            Board = BoardBuilder.Build(height, width, mines);

            Output = Injector.StartUp.InjectionContainer.GetInstance<IOutputBuilder>();



        }
       

       

       

        public void Play()
        {
            while (!Complete)
            {

                Output.Output(Board,Complete);

                var input = Console.ReadKey().KeyChar;

                if (!Board.Move(input))
                {
                    Escaped = true;
                    break;
                }



            }
            Output.Output(Board,Complete);
            Console.ReadLine();

            
        }
    }
}
