using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    static class StatisticOperation
    {
        public static int Sum(Mass A)
        {
            int sum = 0;
            foreach (int a in A.Arr)
            {
                sum += a;
            }
            return sum;
        }
        static int Max(Mass A)
        {
            int max = A.Arr[0];
            foreach (int a in A.Arr)
            {
                if (a > max)
                {
                    max = a;
                }
            }
            return max;
        }
        static int Min(Mass A)
        {
            int min = A.Arr[0];
            foreach (int a in A.Arr)
            {
                if (a < min)
                {
                    min = a;
                }
            }
            return min;
        }
        public static int MaxDiffMin(Mass A)
        {
            return Max(A) - Min(A);
        }
        public static int Count(Mass A)
        {
            return A.Arr.Length;
        }

        public static string Find(this string str)
        {
            const string symbol = "aaaaaaaaaaaaee*eee";
            for (int i = 0; i < symbol.Length; i++)
            {
                if (symbol.IndexOf('*') != -1)
                {
                    return symbol;
                }
                else
                {
                    throw new Exception("Array don't contain * symbol");
                }
            }
            return str;
        }
        public static string Remove(this string str)
        {
            const string vowels = "AeYuO";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (str[i] == vowels[j])
                    {
                        str = str.Remove(i, 1);
                    }
                }
            }
            return str;
        }
        public static Mass FFRemove(this Mass A)
        {
            if (A.Arr.Length <= 5)
            {
                throw new Exception("Lenght of array is < 5");
            }
            Mass B = new Mass();
            for (int i = 4, j = 0; i < A.Arr.Length; i++, j++)
            {
                B.Arr[j] = A.Arr[i];
            }
            return B;
        }
    }
}
