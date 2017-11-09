using System;
using NetStandard20;
using System.Threading;
using ThreadPoolDemo;
using System.Threading.Tasks;

namespace ConsoleAppNetStandard
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                CancellationTokenSource cts = new CancellationTokenSource();
                CancellationToken ct = cts.Token;
                ParallelOptions po = new ParallelOptions { CancellationToken = ct, MaxDegreeOfParallelism = System.Environment.ProcessorCount };
                Example example = new Example();
                Parallel.Invoke(po,
                        new Action(() => example.DoWork(1, ct)),
                        new Action(() => example.DoWork(2, ct)),
                        new Action(() => example.DoWork(3, ct)),
                        new Action(() => example.DoWork(4, ct)),
                        new Action(() => example.DoWork(5, ct)),
                        new Action(() => example.DoWork(6, ct)),
                        new Action(() => { cts.Cancel(); }),
                        new Action(() => example.DoWork(7, ct)),
                        new Action(() => example.DoWork(8, ct))
                    );
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

            //  NetStandard20.Class1 powerBagCollections = new Class1();

            //  foreach (var item in powerBagCollections.CreatOneTwoThree())
            //  {
            //      Console.WriteLine(item);

            //  }
            ////  Console.ReadLine();
            //  Example example = new Example();
            //  Console.ReadLine();
            //  // Program.ThreadPoolFunc();
        }

       
        //public static void ThreadPoolFunc()
        //{
        //    const int FibonacciCalculations = 10;

        //    // One event is used for each Fibonacci object.
        //    ManualResetEvent[] doneEvents = new ManualResetEvent[FibonacciCalculations];
        //    Fibonacci[] fibArray = new Fibonacci[FibonacciCalculations];
        //    Random r = new Random();

        //    // Configure and start threads using ThreadPool.
        //    Console.WriteLine("launching {0} tasks...", FibonacciCalculations);
        //    for (int i = 0; i < FibonacciCalculations; i++)
        //    {
        //        doneEvents[i] = new ManualResetEvent(false);
        //        Fibonacci f = new Fibonacci(r.Next(20, 40), doneEvents[i]);
        //        fibArray[i] = f;
        //        ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback, i);
        //    }

        //    // Wait for all threads in pool to calculate.
        //    WaitHandle.WaitAll(doneEvents);
        //    Console.WriteLine("All calculations are complete.");

        //    // Display the results.
        //    for (int i = 0; i < FibonacciCalculations; i++)
        //    {
        //        Fibonacci f = fibArray[i];
        //        Console.WriteLine("Fibonacci({0}) = {1}", f.N, f.FibOfN);
        //    }

        //}
    }
}
