namespace C_Sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            //celling to the next higher number
            Console.WriteLine("Celling: " + Math.Ceiling(15.3));
            //celling without the decimal part of the current number
            Console.WriteLine("Floor: " + Math.Floor(15.3));

            int numberOne = 25;
            int numberTwo = 50;

            Console.WriteLine("Lower of number one: {0} and number two: {1} is {2}", numberOne, numberTwo, Math.Min(numberOne, numberTwo));
            Console.WriteLine("Higher of number one: {0} and number two: {1} is {2}", numberOne, numberTwo, Math.Max(numberOne, numberTwo));

            Console.WriteLine("Cos of 1 is: {0}", Math.Cos(1));
            //calculate the current number multiply the result by the number (power)
            Console.WriteLine("3 to the power of 5 is {0}", Math.Pow(3, 5));
        }
    }
}