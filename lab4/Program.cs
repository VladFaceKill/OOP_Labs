using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mass A = new Mass(1, 2, 3);
            Mass A1 = new Mass(1, 2, 3);
            Mass B = new Mass(3, 4, 5);
            Mass D = new Mass(1, 2, 3);
            Mass E = new Mass(-1,-2, 3);
            Mass C = A * B;
            foreach (int i in C.Arr)
            {
                Console.Write(i + " ");
            }
            if (D){Console.WriteLine("\nTrue");}
            else{Console.WriteLine("\nFalse");}
            Console.WriteLine(B < A1);
            Console.WriteLine(A == A1);
            int count;
            count = (int)B;
            Console.WriteLine(count);
            Console.WriteLine($"{StatisticOperation.Count(B)}");
            Mass.Owner Owner1 = new Mass.Owner(1, "Vlad", "BSTU");
            Mass.Date Date1 = new Mass.Date(2020, "October", 25);


        }
    }
}