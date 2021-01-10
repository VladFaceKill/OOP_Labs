using LABwork5.Operations;
using System;
using System.Collections.Generic;
using System.IO;
using LABwork5.MSWord;
using LABwork5.Processor;

namespace LABwork5
{
    internal class Virus : OperationsSet
    {
        bool worm;

        public Virus(bool worm = true)
        {
            this.worm = worm;
        }

        public void StartBullying()
        {
            
            for(int i = 0; i < operationListSize; i++)
            {
                switch (operationList[i])
                {
                    case "FillConsole":
                        Random random = new Random();

                        for (int k = 0; k < 100; k++)
                        {
                            for (int j = 0; j < 100; j++)
                            {
                                Console.Write(random.Next(0, 2));
                            }
                        }
                        break;
                    case "ChangeConsoleColor":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "BrakeProgram":
                        throw new Exception();

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }


            
        }

        public void GetOperations()
        {
            string path = "E:\\study\\lab3sem\\OOP\\lab5\\commands.txt";
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);

            StreamReader reader = new StreamReader(file);

            List<string> commandList = new List<string>();

            while (!reader.EndOfStream)
            {
                commandList.Add(reader.ReadLine());
            }

            string[] commands = commandList.ToArray();
            operationList = commands;
            operationListSize = commands.Length;
        }

        public void ShowOpeartions()
        {
            foreach(var i in operationList)
            {
                Console.WriteLine(i);
            }
        }
    }
}