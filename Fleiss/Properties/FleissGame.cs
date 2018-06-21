using System;
namespace Fleiss.Properties
{
    public class FleissGame
    {
        private InputEngine gameInput;
        private RenderEngine gameWindow;
        public bool exitStatus = false;

        public FleissGame()
        {
            //Perform Game Configuration
            gameInput = InputEngine.DefaultEngine();
            gameWindow = RenderEngine.DefaultWindow();


        }
        //Game Loop Implementation
        public void GameMain()
        {
            GetInput();
            Update();
            Render();
        }

        private void GetInput()
        {
            //TODO
            gameInput.GetInput();
        }

        private void Update()
        {
            //TODO
            exitStatus = gameInput.DidExit();
        }

        private void Render()
        {
            //TODO
            gameWindow.DrawWindow();
        }
    }
}
