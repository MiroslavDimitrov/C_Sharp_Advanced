using System;
using System.Threading.Tasks;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 1");
            Thread.Sleep(7000);
            Console.WriteLine("Hello World! 2");
            Console.WriteLine("Hello World! 3");
            Console.WriteLine("Hello World! 4");
            Console.WriteLine("Hello World! 5");

            var taskComplete = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Thread.Sleep(3000);
                taskComplete.SetResult(true);
            });

            var test = taskComplete.Task.Result;
        }
    }
}