using InheritanceSecondChallenge;
namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        { 
            Employee employee = new Employee("Petrov", "Victor", 2500);
            Boss boss = new Boss("Petkov", "Georgi", 7500, "Toyota");
            Trainees trainees = new Trainees("Ivelin", "Valeriev", 500, 4, 8);
            trainees.Work();
            trainees.Learn();
            boss.Lead();
            boss.Work();
        }
    }
}