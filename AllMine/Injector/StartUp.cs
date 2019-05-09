using System;
using System.Collections.Generic;
using System.Text;
using AllMine.Builders;
using AllMine.Models;
using SimpleInjector;

namespace AllMine.Injector
{

    class StartUp
    {
        public static Container InjectionContainer;
        public static void Start()
        {
           
            InjectionContainer = new Container();

            InjectionContainer.Register<IGameBuilder, GameBuilder>(Lifestyle.Singleton);
            InjectionContainer.Register<IOutputBuilder, OutputBuilder>(Lifestyle.Singleton);
            InjectionContainer.Register<IBoardBuilder, BoardBuilder>(Lifestyle.Singleton);
            
            try
            {
                InjectionContainer.Verify();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);

            }

        }
    }
}
