namespace C_sharp_advanced
{
    class Progrm
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1983, 11, 22);
            DateTime date = new DateTime();
            date = DateTime.Now;
            DateTime tomorrow = GetTommorrow();
            Console.WriteLine("The date is {0}", dateTime);
            Console.WriteLine("Today is: {0}", DateTime.Today.DayOfWeek);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(tomorrow);
            Console.WriteLine("{0} o'clock, {1} minutes,and {2} seconds", date.Hour, date.Minute, date.Second);
        }

        static DateTime GetTommorrow()
        { 
            return DateTime.Today.AddDays(1);
        }
    }
}