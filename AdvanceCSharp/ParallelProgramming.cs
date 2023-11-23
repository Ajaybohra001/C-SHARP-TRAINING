using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace TaskParallelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            //Normal Loop

            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine($"Value :{i},Thread : {Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(1000);
            //}

            //Parallel.For(1, 11, num =>
            //{

            //    Console.WriteLine($"Value :{num},Thread : {Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(1000);
            //});

            //Degreee of paralllelsim

            //    var options = new ParallelOptions()
            //    {
            //        MaxDegreeOfParallelism = 2
            //};

            //    Parallel.For(1, 10, options,num =>
            //    {

            //        Console.WriteLine($"Value :{num},Thread : {Thread.CurrentThread.ManagedThreadId}");
            //       // Thread.Sleep(1000);
            //    });


            //Stoping and breaking the Parallel.For loop

            //var BreakSource = Enumerable.Range(0, 1000).ToList();
            //int BreakData = 0;
            //Console.WriteLine("Using loopstate Break Method");
            //Parallel.For(0, BreakSource.Count, (i, BreakLoopState) =>
            //{
            //    BreakData += i;
            //    if (BreakData > 100)
            //    {
            //        BreakLoopState.Break();
            //        Console.WriteLine("Break called iteration {0}. data = {1} ", i, BreakData);
            //    }
            //});
            //Console.WriteLine("Break called data = {0} ", BreakData);


            //  var StopSource = Enumerable.Range(0, 1000).ToList();
            //int StopData = 0;
            //Console.WriteLine("Using loopstate Stop Method");
            //Parallel.For(0, StopSource.Count, (i, StopLoopState) =>
            //{
            //    StopData += i;
            //    if (StopData > 100)
            //    {
            //        StopLoopState.Stop();
            //        Console.WriteLine("Stop called iteration {0}. data = {1} ", i, StopData);
            //    }
            //});

            //For.Invoke

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //Calling Three methods Parallely
            Parallel.Invoke(
                 Method1, Method2, Method3
            );
            stopWatch.Stop();
            Console.WriteLine($"Parallel Execution Took {stopWatch.ElapsedMilliseconds} Milliseconds");

            Console.ReadKey();
        }
        static void Method1()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 1 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        }
        static void Method2()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 2 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        }
        static void Method3()
        {
            Thread.Sleep(200);
            Console.WriteLine($"Method 3 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
        }

    }
}
