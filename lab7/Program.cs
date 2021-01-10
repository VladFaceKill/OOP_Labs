using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABwork7.Dev;
using LABwork7.UserExceptions;
using LABwork7.Project;
using System.Diagnostics;

namespace LABwork7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try {Developer vlad = new Developer(-19); }
                catch(AgeException ex){Console.WriteLine("Error: " + ex.Message);}//IvalidValue exception

                try { Developer egor = new Developer(-20); }
                catch (AgeException ex) { Console.WriteLine("Error: " + ex.Message); }

                try { Developer mark = new Developer(-3-9); }
                catch (AgeException ex) { Console.WriteLine("Error: " + ex.Message); }

                try {DevProject project = new DevProject();project.LoadProject(""); }
                catch(ReaderException ex){Console.WriteLine("Error: " + ex.Message);}//EmptyFile exception

                try {DevTasks list = new DevTasks(5);string str = list[6];}
                catch(OutOfRangeException ex){Console.WriteLine("Error: " + ex.Message);}//IndexOutOfRange exception
                try
                {
                    int x = 5;
                    int y = x / 0;
                    Console.WriteLine($"Результат: {y}");
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.Source);
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            try {int x = 5; int y = x / 0; Console.WriteLine($"Result: {y}");}//DivideByZero exception
            catch{Console.WriteLine("An unexpected error occurred");}
            
            finally
            {
                Console.WriteLine("\nEnd of exception");
                Q(5);
            }
           

            void Q(int num)
            {
                Debug.Assert(num  >= 10, "Value less than 10");
                Console.WriteLine(num);
            }

        }

    }
}
