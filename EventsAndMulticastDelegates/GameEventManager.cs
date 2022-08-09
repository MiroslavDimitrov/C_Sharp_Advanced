using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class GameEventManager
    {
        public delegate void GameEvent();
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static event GameEvent OnGameStart, OnGameOver;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static void TriggerGame()
        {
            if (OnGameStart != null)
            {
                Console.WriteLine("The game has started.");
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("The game has stopped.");
                OnGameOver();
            }
        }
    }
}
