using AllMine.Builders;
using AllMine.Models;
using CommandLine;
using System;
using AllMine.Command;

[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute("AllMineTest")]
namespace AllMine
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Parser.TryParse(args, out Args arguments))
            {
                return;
            }

            Injector.StartUp.Start();

            var GameBuilder = Injector.StartUp.InjectionContainer.GetInstance <IGameBuilder>();

            IGame game = GameBuilder.Build(arguments.Height, arguments.Width, arguments.Mines);

           


            game.Play();
                

        }
    }
}
