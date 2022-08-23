using System;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Threat 4");
            })
            { IsBackground = true };

            Enumerable.Range(0, 100).ToList().ForEach(x =>
            {
                   ThreadPool.QueueUserWorkItem((o) =>
                   {
                       Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} + started");
                       Thread.Sleep(1000);
                       Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} + ended");
                   });
            });
        }
    }
}