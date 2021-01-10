using System;

namespace lab3
{
    public partial class Vector // Определили класс Вектор типа partial  
    {
        public string name;  // Определение полей для индексатора : массив , длина массива
        int[] arr;
        public int Length { get; set; }  // Число элементов в массивe
        public Vector(int Size)
        {
            arr = new int[Size];
            Length = Size;
        }
        public int this[int index]  //Индексатор 
        {
            set
            {
                arr[index] = value;
            }
            get
            {
                return arr[index];
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return (" Имя :" + name + " Идентификатор : " + number);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this == obj;
        }
    }
    public partial class Vector
    {
        public int number { get; set; }
        public int _value=5;
        public int Value   // Переменная состояния 
        {
            get
            {
                return _value;
            }
            set
            {
                if ((value < 0) && (value > -10))
                {
                    Console.WriteLine("Ошибка!");
                }
                else
                {
                    _value = value;

                }
            }
        }
        public static ulong RefCount { get; private set; } // Количество созданных объектов
        public int _x { get; set; }  //координаты вектора 
        public int _y { get; set; }
        public int _z { get; set; }
        public Vector() // Конструктор для ведения подсчёта  объектов
        {
            RefCount++;
        }
        public const double pi = 3.14; // Поле-константа 
        static Vector()
        {
            Console.WriteLine("Это статический конструктор");
        }
        public Vector(int num, int v)  // Конструктор
        {
            num = number;
            v = _value;
        }
        public Vector(int vall, string n, int num = 12)  // Конструктор , принимающий параметры (в том числе , заданные по умолчанию )
        {
            num = number;
            vall = _value;
            n = name;
        }
        public Vector(int x, int y, int z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public void OutputTitle()
        {
            Console.WriteLine($"Вектор : ( {_x},{_y},{_z}) ");
        }
        public void Functionforzero()
        {
            if (_x == 0 && _y == 0 && _z == 0)
            {
                Console.WriteLine($"Вектор А , имеющий  координаты , равные 0 !  А = ( {_x},{_y},{_z}) ");
            }
        }


        public double[] maw = new double[3];
        public void FunctionforModul() // Метод для вычисления модуля для  каждого вектора 
        {
            double sector;
            sector = (Math.Sqrt(Math.Pow(2, _x) + Math.Pow(2, _y) + Math.Pow(2, _z)));
            for (int r = 1; r < maw.Length; r++)
            {
                maw[r] = sector;
            }
            Func(maw);
        }
        private void Func(double[] ser)  // Вывод значений модулей 
        {
            double max = Max(maw);
            Console.WriteLine(max);
        }
        private double Max(double[] ser)   //Нахождение максимального элемента в массиве из модулей
        {

            double max = ser[0];        // присваиваем переменной max значение первого элемента массива  
            for (int i = 0; i < ser.Length; i++) // делам цикл перебора всех элементов массива
            {
                if (max < ser[i])    // если текущий элемент больше переменной max
                {
                    max = ser[i];  // присваиваем переменной max значение текущего элемента
                }
            }
            return max;    // возвращаем значение max

        }
    }
    //закрытый конструктор
    class MyClass
    {
        public int X { get; }

        private MyClass(int a)
        {
            X = a;
        }

        public void Show()
        {
            Console.WriteLine($"Object value = {X}");
        }

        public static MyClass Contructor(int a)
        {
            return new MyClass(a);
        }
    }

    class Program
    {


        static void Main()
        {
            Vector vall = new Vector();                  // Проверка работы переменной состояния 
            vall.Value = -2;
            Console.WriteLine(vall.Value);
            Vector arr1 = new Vector(Size: 5);                    //  Работа индексатора 
            Random ran = new Random();
            Console.WriteLine("Массив:");

            // Инициализируем каждый индекс экземпляра класса arr1
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = ran.Next(1, 100);
                Console.Write("{0}\t", arr1[i]);
            }

            FunctionSumm(arr1);
            FunctionDom(arr1);

            Vector[] massiv = new Vector[3];
            massiv[0] = new Vector(1, 2, 3);
            massiv[1] = new Vector(0, 0, 0);
            massiv[2] = new Vector(40, 15, 55);
            Console.WriteLine();
            Console.WriteLine("Задаём массив объектов");

            for (int g = 0; g < massiv.Length; g++)  // Формирование и инициализация массива объектов 
            {
                massiv[g].OutputTitle();
            }
            Console.WriteLine();
            Console.WriteLine("Массив объектов создан");

            for (int g = 0; g < massiv.Length; g++) //Нахождение векторов с нулевыми координатами 
            {
                massiv[g].Functionforzero();
            }

            for (int g = 0; g < massiv.Length; g++)  //Нахождение модулей векторов 
            {
                massiv[g].FunctionforModul();
            }
        }

        private static void FunctionDom(Vector arr1)
        {
            int point = 10;
            Console.WriteLine();
            Console.WriteLine($"Массив после увеличения каждого элемента на число {point}:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0}\t", arr1[i] + point);
            }

        }

        private static void FunctionSumm(Vector arr1)
        {
            int point = 10;
            Console.WriteLine();
            Console.WriteLine($"Массив после домножения каждого элемента на число {point}:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0}\t", arr1[i] * point);
            }
        }
    }
}
//1 7 16


