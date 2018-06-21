using System;
using Fleiss.Properties;

namespace Fleiss
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Initialize Game
            FleissGame game = new FleissGame();

            //Start Game Loop
            while(!game.exitStatus)
            {
                game.GameMain();
            }
        }
    }
}
