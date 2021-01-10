using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Лабораторная_работа___10
{

    class Program
    {

        interface IList
        {
            void InformationaboutCar();
        }

        class Car : IList
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public string Owner { get; set; }

            public Car(string Name, string Owner, int Year)
            {
                this.Name = Name;
                this.Owner = Owner;

            }


            public void InformationaboutCar()
            {
                Console.WriteLine($"Марка авто : {Name}, Владелец : {Owner}, Год выпуска : {Year}");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание  1:");
            Console.WriteLine("Реализация необобщённой коллекции:");
            Car merc = new Car("Mercedes-Benz", "Vlad", 2021);
            Car zil = new Car("Zil", "Vlad", 1958);
            Car gaz = new Car("Gaz", "Vlad", 1896);
            Dictionary<int, string> cars = new Dictionary<int, string>(3);          
            cars.Add(1, "Mercedes-Benz");
            cars.Add(2, "Zil");
            cars.Add(3, "Gaz");
            cars.Remove(3);
            Console.WriteLine($"Вывод в консоль всех элементов коллекции Dictionary:");
            foreach (KeyValuePair<int, string> keyValue in cars)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine();
            Console.Write($"Количество элементов в коллекции : {cars.Count}");
            Console.WriteLine();
            Console.WriteLine($"Содержит ли коллекция ключ с номером 2 ?  { cars.ContainsKey(2)}");
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Задание  2:");
            Console.WriteLine("Реализация обобщённых коллекций:");
            Dictionary<int, int> intc = new Dictionary<int, int>(3);
            Console.WriteLine($"Вывод в консоль всех элементов коллекции intc:");
            intc.Add(1, 2);
            intc.Add(4, 5);
            intc.Add(6, 7);
            foreach (KeyValuePair<int, int> keyValue in intc)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine($"Вывод в консоль всех элементов коллекции stringc:");
            Dictionary<string, string> stringc = new Dictionary<string, string>(3);
            stringc.Add("1", "vlad");
            stringc.Add("2", "pasha");
            stringc.Add("3", "grisha");

            foreach (KeyValuePair<string, string> keyValue in stringc)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            stringc.Remove("1"); stringc.Remove("2");

            Console.WriteLine($"Удаление 2 элементов коллекции stringc:");
            foreach (KeyValuePair<string, string> keyValue in stringc)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine();

            Stack<char> stack = new Stack<char>();
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Pop();
            stack.Push('D');
            stack.Push('e');
            stack.Push('f');
            stack.Push('g');
            stack.Pop();

            Console.WriteLine("Заполняем коллекцию  List<T> ! ");

            List<char> list = new List<char>();
            foreach (char c in stack)
            {

                list.Add(c);
                Console.WriteLine($"Новый элемент коллекции List<T>: {c}");
            }
            Console.WriteLine("Заполнение завершено!");
            Console.WriteLine("Проверка наличия элемента в коллекции List<T> ");
            Console.WriteLine("Содержит ли  List<T> элемент А ?");
            Console.WriteLine($"Ответ: { list.Contains('A')} ");

            Console.WriteLine("_________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Задание  3:");

            Car<int, string> car1 = new Car<int, string>(1, "Subaru");
            Car<int, string> car2 = new Car<int, string>(2, "Suzuki");
            Car<int, string> car3 = new Car<int, string>(3, "Lada");
            Car<int, string> car4 = new Car<int, string>(4, "Dachia");
            ObservableCollection<Car<int, string>> carss = new ObservableCollection<Car<int, string>> { car1, car2, car3};
            
            carss.CollectionChanged += Cars_CollectionChanged;

            foreach (Car<int, string> car in carss)
            {
                Console.WriteLine($"Авто: {car.Name}");
            }
            Console.WriteLine();
            carss.Add(car4);

            foreach (Car<int, string> car in carss)
            {
                Console.WriteLine($"Авто: {car.Name}");
            }
            Console.WriteLine();
            carss.Remove(car2);

            foreach (Car<int, string> car in carss)
            {
                Console.WriteLine($"Авто: {car.Name}");
            }
        }

        private static void Cars_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Console.WriteLine($"Добавлено новое авто");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Console.WriteLine($"Удалено авто");
                    break;
                default:
                    Console.WriteLine($"Коллекция была изменена");
                    break;
            }
        }
    }
}
