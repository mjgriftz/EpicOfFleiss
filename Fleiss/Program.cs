using System;
using Fleiss.Properties;
using Fleiss.Engine;

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
            game.GameMain();
        }
    }
}
