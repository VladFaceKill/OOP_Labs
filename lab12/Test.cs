using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab12
{
    public class Test
    {
        public string LabName;

        public string LABName
        {
            get => LabName;
            set => LabName = value;
        }

        public Test() => LabName = "unknown";
        public Test(string str) => LabName = str;

        public void PrintLabName() => Console.WriteLine($"LabName: {LabName}");

        public void ChangeLabName(string name) => LABName = name;

        public void WriteSmth(string str) => Console.WriteLine(str + "\n");

    }
}
