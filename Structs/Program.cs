namespace C_sharp_advanced
{

    struct Game
    {
        public string Nmae;
        public string Developer;
        public double Rating;
        public string ReleaseDate;
    }
    class Progam
    {
        static void Main(string[] args)
        {
            Game gameOne;
            gameOne.Nmae = "Legacy of Kain";
            gameOne.Developer = "Nickolay";
            gameOne.Rating = 9.5;
            gameOne.ReleaseDate = "22/11/1995";
        }
    }
}