using System;
using System.Collections.Generic;
using System.Threading;

namespace Demo_ConcurrencyWithThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to start threading...");
            Console.ReadLine();

            // initialize new thread
            Thread t = new Thread(PrintOne);

            Console.WriteLine("Before thread start...");
            // start executing thread t
            t.Start();
            Console.WriteLine("After thread start...");
            PrintZero();

            Console.ReadLine();
        }
         
        public static void PrintOne()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
            Console.WriteLine();
            Console.WriteLine("PrintOne done");
        }

        public static void PrintZero()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
            Console.WriteLine();
            Console.WriteLine("PrintZero done");
        }

    }
}
