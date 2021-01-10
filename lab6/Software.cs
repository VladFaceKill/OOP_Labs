using System;
using System.Collections.Generic;
using System.Text;
using LABwork5.Operations;

namespace LABwork5
{
    namespace SoftwarePlace
    {
        internal class Software : OperationsSet
        {
            string currentSoft;

            public string Soft
            {
                get
                {
                    return currentSoft;
                }
            }

            public Software(string soft)
            {
                currentSoft = soft;
            }

            public void ShowCurrentSoft() => Console.WriteLine($"Current soft is {currentSoft}");

            public override string ToString()
            {
                string forReturn = $"Current soft is {currentSoft}";
                return forReturn;
            }
        }
    }
}
