#define TASK_I
#define TASK_II
#define TASK_III
#define TASK_IV
#define TASK_V

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Threads.Research;
using Threads.TasksSolver;
using System.Threading;




namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {

#if TASK_I

            Researcher.ListAllRunnigProcesses();

            Console.Write("-> PID ");
            string pID = Console.ReadLine();
            int theProcId = int.Parse(pID);

            Researcher.EnumThreadsForPid(theProcId);
            Researcher.EnumModsForPid(theProcId); 
                                                  //Threads.exe и в диспетчере задач найти ID
                                                  //которое нужно вводить в консоль

            Console.ReadLine();
#endif

#if TASK_II

            Console.WriteLine("Name: {0}", AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("Configuration: {0}", AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            Console.WriteLine("Assemblies: ");

            foreach (var i in AppDomain.CurrentDomain.GetAssemblies()) Console.WriteLine(" - {0}", i);

#endif

#if TASK_III

            Thread thread = new Thread(Solver.GetPrimeNumber)
            {
                Name = "Prime numbers thread"
            };

            thread.Start();
            thread.Join();
            Researcher.GetThreadStatus();
#endif


#if TASK_IV

            Thread evenThread = new Thread(Solver.GetEvenNums);
            Thread oddThread = new Thread(Solver.GetOddNums);

            evenThread.Start();
            //evenThread.Sleep(500);
            //evenThread.Priority=ThreadPriority.Highest;
            oddThread.Start();
            //oddThread.Priority = ThreadPriority.Lowest;

            evenThread.Join();
            oddThread.Join();

            Console.WriteLine();

            Console.ReadLine();


#endif

#if TASK_V

            TimerCallback timeCB = new TimerCallback(PrintTime);

            Timer time = new Timer(timeCB, null, 0, 1000);

            Console.ReadLine();

#endif
        }

        static void PrintTime(object state)
        {
            Console.Clear();
            Console.WriteLine("Текущее время:  " +
                DateTime.Now.ToLongTimeString());
        }
    }
}
