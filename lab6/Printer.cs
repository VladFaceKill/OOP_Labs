using System;
using System.Collections.Generic;
using System.Text;
using LABwork5.Processor;
using LABwork5.GamePlace;
using LABwork5.Operations;
using LABwork5.SoftwarePlace;
using LABwork5.MSWord;

namespace LABwork5
{
    namespace ThePrinter
    {
        class Printer : Game
        {
            public Printer(string type, string name) : base(type, name)
            {

            }

            public override void PrintInfo(object obj)
            {
                Console.WriteLine(obj.GetType());
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
