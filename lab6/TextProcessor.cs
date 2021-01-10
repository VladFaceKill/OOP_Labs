using System;
using System.IO;

namespace LABwork5
{
    namespace Processor
    {
        abstract internal class TextProcessor : ITextComands
        {
            protected string[] workSpace;
            protected int workSpaceSize;
            int version;
            public TextProcessor(int size)
            {
                workSpace = new string[size];
                workSpaceSize = size;
            }

            public int Size
            {
                get
                {
                    return workSpaceSize;
                }
            }

            public string this[int index]
            {
                get
                {
                    if (IsAvailable(index))
                    {
                        return workSpace[index];
                    }
                    else
                    {
                        Console.WriteLine("Попытка получения элемента по недопустимому индексу");
                        return "";
                    }
                }
                set
                {
                    if (IsAvailable(index))
                    {
                        workSpace[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Попытка присваивания значения элементу по недопустимому индексу");
                        workSpace[index] = "";
                    }
                }
            }

            public virtual void EditText()
            {
                Console.WriteLine("EditText() method");

                Console.WriteLine("Please, enter a number of string for change => ");
                int indexForChange = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("So, now enter a new value => ");
                string newValue = Console.ReadLine();

                workSpace[indexForChange - 1] = newValue;
            }

            public virtual void PrintText()
            {
                Console.WriteLine("PrintText() method");

                Console.WriteLine("Your work space is");

                Console.WriteLine("------------------");
                foreach (var i in workSpace)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("------------------");
            }

            public virtual void SaveText()
            {
                string path = "E:\\study\\lab3sem\\OOP\\lab6\\TextProcessorWorkSpace.txt";
                FileStream file = new FileStream(path, FileMode.OpenOrCreate);

                StreamWriter writer = new StreamWriter(file);

                foreach (var i in workSpace)
                {
                    writer.WriteLine(i);
                }

                writer.Close();
            }

            public virtual void SetText()
            {
                Console.WriteLine("So, can you set your work place?? Please, your welcome! ");
                for (int i = 0; i < workSpaceSize; i++)
                {
                    Console.Write((i + 1) + " string => ");
                    workSpace[i] = Console.ReadLine();
                }
            }

            protected bool IsAvailable(int index)
            {
                return index >= 0 && index < workSpaceSize;
            }
            protected bool IsAvailable(int index1, int index2)
            {
                return (index1 > 0 && index1 < workSpaceSize) && (index2 > 0 && index2 < workSpaceSize);
            }

            public override string ToString()
            {
                string str = $"Work place consit of {workSpaceSize}";
                return str;
            }
        }
    }
}