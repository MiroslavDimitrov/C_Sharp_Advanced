using System;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started.");

            Thread threadOne = new Thread(ThreadFunction);
            Thread threadTwo = new Thread(ThreadSecondFunction);

            threadOne.Start();
            threadTwo.Start();


            if (threadOne.Join(1000))
            {
                Console.WriteLine("Thread one function done");
            }
            else
            {
                Console.WriteLine("Thread one wasn't ready within one second.");
            }

            for (int i = 0; i < 10; i++)
            {
                if (threadOne.IsAlive)
                {
                    Console.WriteLine("Still active.");
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("Thread is finished.");
                }
            }

            Console.WriteLine("Thread second function done.");
            Console.WriteLine("Main thread ended.");
        }

        public static void ThreadFunction()
        {
            Console.WriteLine("Thread function is started.");
            Thread.Sleep(3000);
        }

        public static void ThreadSecondFunction()
        {
            Console.WriteLine("Second thread function is started.");
        }
    }
}