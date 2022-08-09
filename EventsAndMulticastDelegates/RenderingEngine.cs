using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    public class RenderingEngine
    {

        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine("Engine started.");
            Console.WriteLine("Drawing visuals.");
        }

        private void GameOver()
        {
            Console.WriteLine("Engine stopped.");
        }
    }
}
