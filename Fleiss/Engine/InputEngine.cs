using System;
namespace Fleiss.Engine
{
    public abstract class InputEngine
    {
        public InputEngine()
        {
            //TODO
        }

        public static InputEngine DefaultEngine()
        {
            return new TextInputEngine();
        }

        public virtual bool DidExit()
        {
            //TODO
            return false;
        }

        public virtual void GetInput()
        {
            
        }
    }

    public class TextInputEngine: InputEngine
    {
        public TextInputEngine() : base()
        {
            
        }
        public override void GetInput()
        {
            Console.ReadLine(); //This is for testing
        }
    }
}


