using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Threads.Research
{
    static class Researcher
    {
        public static void ListAllRunnigProcesses()
        {
            var runningProcs = from proc in Process.GetProcesses() orderby proc.Id select proc;

            foreach (var i in runningProcs)
            {
                Console.Write("-> PID: {0}", i.Id);
                Console.WriteLine("\tName: {0}", i.ProcessName);
                Console.WriteLine("Base priority: {0}", i.BasePriority);

                try
                {
                    Console.WriteLine("Start time: {0}", i.StartTime);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine();
            }

            Console.WriteLine("**********************************************");

        }
        public static void EnumThreadsForPid(int pID)
        {
            Process proc = null;
            try
            {
                proc = Process.GetProcessById(pID);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("Here are the threads used by: {0}", proc.ProcessName);
            ProcessThreadCollection threads = proc.Threads;

            foreach (ProcessThread pt in threads)
            {
                string info = string.Format("-> Threads ID: {0}\tStart Time: {1}\tPriority: {2}", pt.Id, pt.StartTime.ToShortTimeString(), pt.PriorityLevel);
                Console.WriteLine(info);
            }

            Console.WriteLine("****************************************************");
        }
        public static void EnumModsForPid(int pID)
        {
            Process proc = null;

            try
            {
                proc = Process.GetProcessById(pID);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("Here are the loaded modules for: {0}", proc.ProcessName);

            ProcessModuleCollection mods = proc.Modules;

            foreach(ProcessModule pm in mods)
            {
                string info = string.Format("-> Mod Namee: {0}", pm.ModuleName);
                Console.WriteLine(info);
            }
            Console.WriteLine("********************************************************");
            //Console.ReadLine();
        }
        internal static void GetThreadStatus()
        {
            Console.WriteLine("-------------------Thread Status-------------------");
            Console.WriteLine("Name: " + Thread.CurrentThread.Name);
            Console.WriteLine("Id: " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Priority: " + Thread.CurrentThread.Priority);
            Console.WriteLine("Status: " + Thread.CurrentThread.ThreadState);
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
