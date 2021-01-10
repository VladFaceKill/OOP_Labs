using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using LABwork5.MSWord;
using LABwork5.Processor;

namespace LABwork5
{
    namespace Operations
    {
        internal class OperationsSet : TextProcessor
        {
            protected string[] operationList;
            protected int operationListSize;
            public OperationsSet(int size = 5) : base(size)
            {
                operationList = new string[size];
                operationListSize = size;
            }
            //public string this[int index]
            //{
            //    get
            //    {
            //        if (IsAvailable(index))
            //        {
            //            return operationList[index];
            //        }
            //        else
            //        {
            //            throw new Exception("Not availabe index");
            //        }
            //    }
            //    set
            //    {
            //        if (IsAvailable(index))
            //        {
            //            operationList[index] = value;
            //        }
            //        else
            //        {
            //            throw new Exception("Not available to set a new value");
            //        }
            //    }
            //}
            public void SetOperationList(string fileName = "commands.txt")
            {
                string path = $"E:\\study\\lab3sem\\OOP\\lab5\\{fileName}";
                FileStream file = new FileStream(path, FileMode.OpenOrCreate);
                StreamReader reader = new StreamReader(file);

                List<string> commandList = new List<string>();

                for (int i = 0; !reader.EndOfStream; i++)
                {
                    commandList.Add(reader.ReadLine());
                    operationListSize = i + 1;
                }

                operationList = commandList.ToArray();
            }
            public void ShowOperationList()
            {
                Console.WriteLine(operationListSize);

                for (int i = 0; i < operationListSize; i++)
                {
                    Console.WriteLine(operationList[i]);
                }
            }

            public override string ToString()
            {
                string str = $"Command list consits of {operationListSize}";
                return str;
            }
        }
    }
}
