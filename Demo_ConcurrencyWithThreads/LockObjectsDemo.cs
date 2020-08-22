using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Demo_ConcurrencyWithThreads
{
    class LockObjectsDemo
    {

        public LockObjectsDemo()
        {

        }

        public void RunLockObjectDemo()
        {
            var bankAccount = new BankAccount(100);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "Thread_RunLockObjectDemo";

            for (int i = 0; i < threads.Length; i++)
            {
                Thread t = new Thread(new ThreadStart(bankAccount.IssueWithDraw)) { Name = i.ToString() };
                threads[i] = t;
            }

            for (int i = 0; i < threads.Length; i++)
            {
                Console.WriteLine("Thread {0}, IsAlive {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0}, IsAlive {1}", threads[i].Name, threads[i].IsAlive);
            }

            Console.WriteLine($"Thread {Thread.CurrentThread.Name}, Priority: {Thread.CurrentThread.Priority}");
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} Ending");
        }

        private class BankAccount
        {
            private Object _accountLock;
            public decimal Balance { get; set; }
            public BankAccount(decimal balance)
            {
                _accountLock = new Object();
                Balance = balance;
            }

            public decimal WithDraw(decimal amount) 
            {
                if ((Balance - amount) < 0)
                {
                    Console.WriteLine($"Sorry, not enough funds, balance is {Balance}");
                    return Balance;
                }

                lock (_accountLock)
                {
                    if ((Balance >= amount))
                    {
                        Balance -= amount;
                        Console.WriteLine("Removed {0}, balance is now {1}", amount, Balance);
                    }
                    return Balance;
                }

            }
            public void IssueWithDraw()
            {
                WithDraw(1);
            }

        }

    }

}
