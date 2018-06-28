using System;
namespace Fleiss.Engine
{
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

    public abstract class GameWindow
    {
        public virtual void Draw() { }
        public static TextWindow MakeTextWindow()
        {
            return new TextWindow();
        }
    }

    public class TextWindow : GameWindow
    {

        protected char[,] drawData_;
        protected int width_;
        protected int height_;

        public TextWindow() : this(80, 24) { }

        public TextWindow(int height, int width)
        {
            //initialize the drawData_ buffer
            drawData_ = new char[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    drawData_[i, j] = ' ';
                }
            }
        }

        public override void Draw()
        {
            for (int i = 0; i < width_; i++)
            {
                for (int j = 0; j < height_; j++)
                {
                    Console.Write(drawData_[i, j]);
                }
            }
        }
    }
}


