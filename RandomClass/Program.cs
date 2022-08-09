namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        { 
            Random dice = new Random();
            int numEyes;

            for (int i = 0; i < 10; i++)
            {
                //print numbers between 1 and 7, excluvive the upper bound which in our case is 7
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }
        }
    }
}