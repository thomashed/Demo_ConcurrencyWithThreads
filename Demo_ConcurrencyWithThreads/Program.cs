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
            var pauseThreadDemo = new PauseThreadDemo();

            // demo: start threads
            //startThreadDemo.StartThreadOne();
            //startThreadDemo.StartThreadTwo();

            // demo: pause threads
            pauseThreadDemo.StartThreadOne();

            Console.WriteLine("threading is still on...");
            Console.ReadLine();
        }
         
        

    }
}
