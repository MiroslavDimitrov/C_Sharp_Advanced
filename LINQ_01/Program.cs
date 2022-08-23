using System;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            PrintOddNumbers(numbers);
        }

        static void PrintOddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd numbers: ");

            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            Console.WriteLine(oddNumbers);

            foreach (int number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}