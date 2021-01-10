using System;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-----First task-----");
            //a
            bool a = true;
            Console.WriteLine("bool=" + a);
            byte a1 = 1;
            Console.WriteLine("byte=" + a1);
            sbyte a2 = -2;
            Console.WriteLine("sbyte=" + a2);
            short a3 = 2;
            Console.WriteLine("short=" + a3);
            ushort a4 = 3;
            Console.WriteLine("ushort=" + a4);
            int a5 = 5;
            Console.WriteLine("int=" + a5);
            long a6 = -10;
            Console.WriteLine("long=" + a6);
            ulong a7 = 6;
            Console.WriteLine("ulong=" + a7);
            float a8 =1.5f;
            Console.WriteLine("float=" + a8);
            double a9 = 15.4;
            Console.WriteLine("double=" + a9);
            decimal a10 = 121.1m;
            Console.WriteLine("decimal=" + a10);
            char a11 = 'v';
            Console.WriteLine("char=" + a11);
            string a12 = "vlad";
            Console.WriteLine("string=" + a12);
            object a13 = 13;
            Console.WriteLine("object=" + a13);
            uint a14 = 9;
            Console.WriteLine("uint=" + a14);
            //b
            a5 = a1 + 25;
            a5 = a5 - 'v';
            a9 = a9 - a8;
            a6 = a3 + a5;
            a3 = 'v' - 3;

            a5 = (int)(3 + 12.5f);
            a11 = (char)(17 + 30);
            a3 = (short)(a4 + a11);
            a10 = (decimal)(a8);
            a6 = (long)(a5);
            
            double b = 1.6;
            int b1 = Convert.ToInt32(b);
            char b2 = Convert.ToChar(23);
            bool b3 = Convert.ToBoolean(1.3);
            //c
            int c = 10;
            Object box = c;//упаковка
            int c1 = (int)box;//распаковка
            //d
            var varint = 80;
            var varbool = false;
            //e
            Nullable<int> nint = 4;
            int? nint2 = null;
            //f
            var varint2 = 3;
            //varint2 = true;

            Console.WriteLine("-----Second task-----");
            //2a
            string str5 = "my string";
            string str1 = "first";
            string str2 = "second";
            Console.WriteLine(String.Compare(str1, str2));//сравнение
            //2b
            string str3 = "third";
            string str4 = str1 + str2 + ' ' + str3;
            Console.WriteLine(str4);
            str1 = String.Concat(str1, "!!!");//конкатенация
            Console.WriteLine(str1);
            string substring = "paste";
            substring = substring.Substring(3);
            Console.WriteLine(substring);
            char[] buff = new char[10];
            str2.CopyTo(0, buff, 0, 6);//копирование
            Console.WriteLine(buff);
            string[] split = str5.Split(' ');//разделение
            foreach (string str in split)
            {
                Console.WriteLine(str + ' ');
            }
            str1 = str1.Insert(3, "hi");//вставка
            Console.WriteLine(str1);
            str5 = str5.Remove(3, 4);//удаление
            Console.WriteLine(str5);
            string str6 = "world";
            Console.WriteLine($"hello {str6}");
            Console.WriteLine($"интерполяция: {3} - {2} = {1}");
            //2c
            string nullstr = null, emptystr = "";
            Console.WriteLine($"cтроки пустые или null: {String.IsNullOrEmpty(nullstr)}, {String.IsNullOrEmpty(emptystr)}");
            emptystr = emptystr.Insert(0, "Not Empty Anymore");
            Console.WriteLine(emptystr);
            //2d
            StringBuilder strBuild = new StringBuilder("New string", 50);
            strBuild.Replace(' ', '|');
            strBuild.Insert(0, '!');
            strBuild.Insert(strBuild.Length, '!');
            Console.WriteLine(strBuild);
            Console.WriteLine("-----Third task-----");
            //3a
            int[,] intArr = new int[,]
            {
            {1, 2, 3, 4, 5 },
            {6, 7, 8, 9, 10 },
            {11, 12, 13, 14, 15 },
            {16, 17, 18, 19, 20 },
            {21, 22, 23, 24, 25 }
            };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{intArr[i, j],-5}");
                }
                Console.WriteLine();
            }
            //3b
            string[] strArr = new string[]
            { "This", "first", "work", "on", "C!" };
            foreach (string str in strArr)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine($"\nlength = {strArr.Length}");
            strArr[4] = strArr[4].Remove(0);
            strArr[4] = strArr[4].Insert(0, "C#!");
            foreach (string str in strArr)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();
            //3c
            float[][] jaggedArr = new float[3][];
            jaggedArr[0] = new float[2];
            jaggedArr[1] = new float[3];
            jaggedArr[2] = new float[4];
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j] = float.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                int j = 0;
                foreach (int tmp in jaggedArr[i])
                {
                    Console.Write(" " + jaggedArr[i][j]);
                    j++;
                }
                Console.WriteLine();
            }
            //3d
            var nontypearr = jaggedArr;
            var nontypestr = str1;
            Console.WriteLine("-----Fourth task-----");
            //4a
            (int age, string name, char firstL, string surname, ulong weight) mytuple = (18, "Vlad", 'V', "Berinchik", 76);
            //4b
            Console.WriteLine(mytuple);
            Console.WriteLine($"{mytuple.age}, {mytuple.firstL}, {mytuple.surname}");
            //4c
            var (one, two, three, four, five) = mytuple;
            var tup2 = (3, 9);
            var tup3 = mytuple.Item3;
            var tup4 = mytuple.Item4;
            //4d
            var cmptuple = mytuple; 
            Console.WriteLine(cmptuple == mytuple);
            cmptuple.Item1 = 19;
            Console.WriteLine(cmptuple == mytuple);
            Console.WriteLine("-----Fifth task-----");
            (int maxValue, int minValue, int sum, char firstl) LocalFunction(int[] arr, string str)
            {
                int max = arr[0];
                int min = arr[0];
                char firstl = str[0];
                int sum = 0;

                foreach (int el in arr)
                {
                    if (min > el) min = el;
                    if (max < el) max = el;
                    sum += el;
                }

                return (max, min, sum, firstl);
            }
            int[] arr = { 1, 6, -5, 3, 7, 20, 99, -24 };
            var result = LocalFunction(arr, "Vlad");
            Console.WriteLine(result);
            Console.WriteLine("-----Sixth task-----");
            void func1()
            {
                unchecked
                {
                    int maxint = 2147483647;
                    maxint += 1;
                    Console.WriteLine(maxint);
                }
                return;
            }
            void func2()
            {
                checked
                {
                    int maxint = 2147483647;
                    maxint += 1;
                    Console.WriteLine(maxint);
                }
                return;
            }
            func1();func2();
        }
    }
}
//8,9,26
