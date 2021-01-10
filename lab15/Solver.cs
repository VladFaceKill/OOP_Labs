using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Threads.Research;

namespace Threads.TasksSolver
{
    static class Solver
    {
        private static int[] nums;
        static Solver()
        {
            FillNumsWithRandom();
            CheckArray();
        }
        private static void FillNumsWithRandom()
        {
            Random rand = new Random();

            nums = new int[rand.Next(6, 12)];

            for (int i = 0; i < nums.Length; i++) nums[i] = rand.Next(10, 70);
        }
        private static void CheckArray()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
        }
        public static void GetPrimeNumber()
        {
            Console.WriteLine("Enter range: ");
            int range = int.Parse(Console.ReadLine());

            for(int i = 0; i < range; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine($"[{i}]");
                    Researcher.GetThreadStatus();
                }
            }
 
        }
        public static void GetEvenNums()
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (IsEven(nums[i])) Console.WriteLine($"{nums[i]}^even");

                Thread.Sleep(100);
            }

        }
        public static void GetOddNums()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (IsOdd(nums[i])) Console.WriteLine($"{nums[i]}^odd");

                Thread.Sleep(100);
            }
        }

        private static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        private static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }

        private static bool IsPrimeNumber(int range)
        {
            var isPrime = true;

            if(range > 1)
            {
                for(int i = 2; i < range; i++)
                {
                    if(range % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }

            return isPrime;
        }

    }
}
