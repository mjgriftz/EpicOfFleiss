using System;
using System.Collections.Generic;
namespace Fleiss.Engine
{
    public abstract class GameView
    {

        public virtual void Draw(GameWindow window)
        {
            
        }
    }

    public class TextView : GameView
    {

        protected size size_;
        protected location location_;
        protected List<TextView> children_;

        public override void Draw(GameWindow window)
        {
            //View Draws itself, then all its children

            foreach (TextView view in this.children_)
            {
                view.Draw(window);
            }
        }
    }
}
