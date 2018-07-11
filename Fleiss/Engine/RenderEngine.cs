using System;
using System.Collections.Generic;
namespace Fleiss.Engine
{

    public struct location
    {
        public readonly int X;
        public readonly int Y;

        public location(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    public struct size
    {
        public readonly int Width;
        public readonly int Height;

        public size(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }

    public class RenderEngine
    {
        public GameWindow rootWindow;

        public RenderEngine()
        {
            rootWindow = GameWindow.MakeTextWindow();
        }

        public static RenderEngine DefaultWindow()
        {
            //Update 

            return new RenderEngine();
        }

        public void DrawWindow()
        {
            this.rootWindow.Draw();
        }
    }
}


