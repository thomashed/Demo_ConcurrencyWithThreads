using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Demo_ConcurrencyWithThreads
{
    class PauseThreadDemo
    {
        private Thread _threadOne;

        public PauseThreadDemo()
        {
            _threadOne = new Thread(StartThreadOne);
        }

        internal void StartThreadOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.Write(1);
            }
        }
    }
}
