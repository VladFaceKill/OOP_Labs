using System;
using LABwork5.Processor;
using LABwork5.MSWord;
using LABwork5.Operations;
using LABwork5.SoftwarePlace;
using LABwork5.TheSapper;
using LABwork5.GamePlace;
using LABwork5.ThePrinter;

namespace LABwork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();

            Game firstGame = new Game("RPG");

            OperationsSet operationList = new OperationsSet();

            Sapper game = new Sapper(10, "Logic");

            Software soft = new Software();

            Virus covid = new Virus();

            Word msword = new Word();


            if(dev is Game)
            {
                Console.WriteLine("dev is Game");
            }
            else
            {
                Console.WriteLine("dev is not Game");
            }

            if(operationList is TextProcessor)
            {
                Console.WriteLine("operationList is TextProcessor");
            }
            else
            {
                Console.WriteLine("operationList is not TextProcessor");
            }

            if(covid is OperationsSet)
            {
                Console.WriteLine("covid is OperationsSet");
            }
            else
            {
                Console.WriteLine("covid is not OperationsSet");
            }

            Printer printer = new Printer("");

            object[] maObjects = new object[] { soft, msword, operationList };

            Console.WriteLine("----------------------");

            foreach(var i in maObjects){
                printer.PrintInfo(i);
            }
        }
    }
}