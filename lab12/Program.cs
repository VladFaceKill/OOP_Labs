using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace OOP_Lab12
{
    
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"MyFile.txt", string.Empty);
            string className = "OOP_Lab12.Test";
            Reflector.AssemblyName();
            Reflector.PublicConstructors(className);
            Reflector.PublicMethods(className);
            Reflector.FieldAndProps(className);
            Reflector.ImplementedInterfaces(className);
            Reflector.MethodsWithPar(className);
            Console.WriteLine();

            Reflector.Invoke("OOP_Lab12.Test", "WriteSmth", "ArgPath.txt");

            Test obj = (Test)Reflector.CreateType("OOP_Lab12.Test");
            obj.LABName = "Lab12";
            obj.PrintLabName();
        }
    }
}

