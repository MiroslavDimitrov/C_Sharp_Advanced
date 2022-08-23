using System;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        { 
            var taskCompletiionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Thread.Sleep(3000);
                taskCompletiionSource.TrySetResult(true);
            });

            Console.WriteLine($"{thread.ManagedThreadId}");
            thread.Start();
            var task = taskCompletiionSource.Task.Result;
            Console.WriteLine("{0}", task);
        }
    }
}