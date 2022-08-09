using InheritanceNew;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Post postOne = new Post("Thanks for the lesson.", true, "Miroslav Dimitrov");
            Console.WriteLine(postOne.ToString());
            ImagePost imagePostOne = new ImagePost("Check this out.", "Miroslav Dimitrov", "https://images.com/shoes", true);
            Console.WriteLine(imagePostOne.ToString());
            VideoPost videoPostOne = new VideoPost("Fake link", "Miroslav Dimitrov", "https://videos-online.com", 5, true);
            Console.WriteLine(videoPostOne.ToString());
            videoPostOne.Play();
            //Console.WriteLine("Press any key to stop the video.");
            Console.ReadKey();
            videoPostOne.Stop();
        }
    }
}