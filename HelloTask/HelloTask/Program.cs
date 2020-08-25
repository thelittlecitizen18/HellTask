using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Threading;

namespace HelloTask
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            Stopwatch watch1 = new Stopwatch();
            Stopwatch watch2 = new Stopwatch();

            //watch.Start();
            //PrintNumbers();
            //watch.Stop();
            //var time1 = watch.ElapsedMilliseconds;

            //watch1.Start();
            //for (int i = 0; i <= 10000; i++)
            //{
            //    var number = i;
            //    Thread numbers = new Thread(() =>  Console.WriteLine(number));
            //    numbers.Start();
            //}
            //watch1.Stop();
            //var time2 = watch1.ElapsedMilliseconds;

            watch2.Start();
            for (int i = 0; i <= 1000000; i++)
            {
                var num = i;
                ThreadPool.QueueUserWorkItem((a) => PrintNumbers1(num));
        
            }
            watch2.Stop();
            var time3 = watch2.ElapsedMilliseconds;

            Console.ReadLine();
            Console.WriteLine("time {0}", time3);
            //Console.WriteLine(" sync: {0}, thread per number :{1} , thread pool :{2}", time1, time2, time3);

        }

        static void PrintNumbers1(int num)
        {
            Console.WriteLine(num);
        }
        //static void PrintNumbers()
        //{
        //    for (int i = 0; i <= 10000; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //static void ThreadPrintNumber(int num)
        //{
        //    for (int i = 0; i <= 1000; i++)
        //    {
        //        num = i
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
