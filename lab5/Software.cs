using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LABwork5.Operations;

namespace LABwork5
{
    namespace SoftwarePlace
    {
        internal class Software : OperationsSet
        {
            public void Windows()
            {
                SetOperationList("Windows.txt");
                ShowOperationList();
            }

            public void Linux()
            {
                SetOperationList("Linux.txt");
                ShowOperationList();
            }

            public void MacOS()
            {
                SetOperationList("MacOS.txt");
                ShowOperationList();
            }

            public override string ToString()
            {
                string forReturn = "There are three OS - Linux, Windows, MacOS";
                return forReturn;
            }

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
        }
    }
}
