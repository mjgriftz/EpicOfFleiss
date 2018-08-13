using System;
using System.Collections.Generic;
namespace Fleiss.Engine
{
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
        protected size size_;
        protected List<TextView> children_;

        public TextWindow() : this(80, 24) { }

        public TextWindow(int width, int height)
        {
            //initialize the drawData_ buffer
            size_ = new size(width, height);
            drawData_ = new char[width, height];
            children_ = new List<TextView>();

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    drawData_[i, j] = '$';
                }
            }
        }

        public override void Draw()
        {

            foreach (TextView view in this.children_)
            {
                view.Draw(this);
            }
            for (int i = 0; i < size_.Width; i++)
            {
                for (int j = 0; j < size_.Height; j++)
                {
                    Console.Write(drawData_[i, j]);
                }
            }
        }

        public void addChild(TextView view)
        {
            children_.Add(view);
        }
    }
}
