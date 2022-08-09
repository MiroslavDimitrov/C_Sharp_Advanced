namespace C_sharp_advanced
{
    class Program
    {
        enum Month {January = 1, February, March, April, May, June, July = 15, August, September, October, November, December};
        enum Day {Mon = 1, Tue, Wed, Thr, Fri, Sat, Sun };
        static void Main(string[] args)
        {
            Console.WriteLine((int)Month.February);
            //because the value of July is equal to 15
            Console.WriteLine((int)Month.August);

            Day one = Day.Mon;
            Day two = Day.Mon;
            Console.WriteLine(one == two);
            Console.WriteLine(Day.Sun);
            Console.WriteLine((int)Day.Mon);
        }
    }
}