using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadOne = new Thread(new ThreadStart(Counting));
            Thread threadTwo = new Thread(new ThreadStart(Counting));
            threadOne.Start();
            threadTwo.Start();
            threadOne.Join();
            threadTwo.Join();
            Console.ReadKey();
        }

        static void Counting()
        {
            for(int i=1; i<=10 ; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}
