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

            // init demo instances
            var startThreadDemo = new StartThreadDemo();


            startThreadDemo.StartThreadOne();
            startThreadDemo.StartThreadTwo();

            Console.ReadLine();
        }
         
        

    }
}
