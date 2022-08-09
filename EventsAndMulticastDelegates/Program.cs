using EventsAndMulticastDelegates;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();
            Player playerOne = new Player("Todorov");
            Player playerTwo = new Player("Dimitrov");
            Player palyerThree = new Player("Peshev");

            GameEventManager.TriggerGame();

            Console.WriteLine("Press any key to stop the game.");

            GameEventManager.TriggerGameOver();
        }
    }
}