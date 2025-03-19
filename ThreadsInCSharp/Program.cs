using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ThreadsInCSharp
{
    class Program
    {
        //Threads in C# can be created using:

        //Thread Class(System.Threading.Thread)
        //Task Class(System.Threading.Tasks.Task)
        //ThreadPool
        //Async/Await (for asynchronous programming)

        static void ExecuteChildThread()
        {
            try
            {
                for(int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(i);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thread execution over");
            }
        }

        static void Task1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Task1 - {i}");
                Thread.Sleep(500);
            }
        }

        static void Task2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Task2 - {i}");
                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            NormalThreads();
            MultiThreading();
            ThreadJoin();
            ThreadsUsingTask();
        }

        static void NormalThreads()
        {
            ThreadStart chiildThread = new ThreadStart(ExecuteChildThread);
            Thread thread = new Thread(chiildThread);
            thread.Start();

            Thread.Sleep(3000);
            thread.Abort();
            Console.WriteLine("Thread aborted.");
        }

        static void MultiThreading()
        {
            //Multi-Threading
            Thread thread1 = new Thread(Task1);
            Thread thread2 = new Thread(Task2);

            thread1.Start();
            thread2.Start();
        }

        static void ThreadJoin()
        {
            //Join Thread - One will finish executing then next will start
            Thread thread1 = new Thread(Task1);
            Thread thread2 = new Thread(Task2);

            thread1.Start();
            thread1.Join();

            thread2.Start();
        }

        static void ThreadsUsingTask()
        {
            Task task1 = Task.Run(() =>
            {
                Console.WriteLine("Task 1 started.");
                Task.Delay(2000).Wait();
                Console.WriteLine("Task 1 finished.");
            });

            Task task2 = task1.ContinueWith((t) =>
            {
                Console.WriteLine("Task 2 started.");
                Task.Delay(2000).Wait();
                Console.WriteLine("Task 2 finished.");
            });

            task2.Wait(); // Ensures task2 completes before Main continues
            Console.WriteLine("Both tasks completed. Main thread resumes.");
        }
    }
}
