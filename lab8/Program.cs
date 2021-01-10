using System;
using Lb8;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 5, 1, 3, 7, 9 };

            Set<int> intSet = new Set<int>(intArray);

            intSet.Show();

            intSet.Delete(2);

            intSet.Show();

            intSet.Add(10);
            
            intSet.Show();

            Console.WriteLine();
            float[] floatArray = new float[] { 2.5f, 3.46f, 3.8f, 4.4f, 5.96f };

            Set<float> floatSet = new Set<float>(floatArray);

            floatSet.Show();

            floatSet.Delete(2.5f);

            floatSet.Show();

            floatSet.Add(10);

            floatSet.Show();

            Console.WriteLine();

        }
    }
}
