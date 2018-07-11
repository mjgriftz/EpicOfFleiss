using System;
using Fleiss.Engine;

namespace Fleiss
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Initialize Game
            FleissGame game = new FleissGame();

            //Start Game Loop
            game.GameMain();
        }
    }
}
