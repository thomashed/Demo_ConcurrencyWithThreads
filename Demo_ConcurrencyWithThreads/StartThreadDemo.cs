using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Demo_ConcurrencyWithThreads
{
    class StartThreadDemo
    {
        private Thread _tPrintOne;
        private Thread _tPrintTwo; 
        public StartThreadDemo()
        {
            _tPrintOne = new Thread(PrintOne);
            _tPrintTwo = new Thread(PrintTwo);
        }

        public void StartThreadOne()
        {
            _tPrintOne.Start();
        }

        public void StartThreadTwo()
        {
            _tPrintTwo.Start();
        }

        public void PrintOne()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
            Console.WriteLine();
            Console.WriteLine("PrintOne done");
        }

        public void PrintTwo()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(2);
            }
            Console.WriteLine();
            Console.WriteLine("PrintTwo done");
        }


    }
}
