namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int? numberOne = null;
            int? numberTwo = 2550;

            double? numberThree = new Double?();
            double? numberFour = 3.14157;

            bool? boolaVlue = new bool?();

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", numberOne, numberTwo, numberThree, numberFour, boolaVlue);
        }
    }
}