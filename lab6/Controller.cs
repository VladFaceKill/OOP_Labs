using System;
using System.Collections.Generic;
using System.Text;
using LABwork5.GamePlace;
using LABwork5.MSWord;
using LABwork5.SoftwarePlace;

namespace LABwork5
{
    namespace Control
    {
        static class Controller
        {
            public static void FindGameForType(Game[] games)
            {
                Console.WriteLine("Enter type of game");
                string currentVersion = Console.ReadLine();

                foreach (var i in games)
                {
                    if (i.GetGameType == currentVersion) Console.WriteLine($"Game with {i.GetGameName} number");
                }
            }

            public static void FindRedactorForVersion(Word[] redactors)
            {
                Console.WriteLine("Enter version for searching");
                int currentVersion = Convert.ToInt32(Console.ReadLine());

                foreach (var i in redactors)
                {
                    if (i.Version == currentVersion) Console.WriteLine($"Object with {i.Row} row and {i.Col} columns");
                }
            }

            public static void ShowSoftAlphabetically(Software[] softs)
            {
                //softs.Sort();

                Console.WriteLine("Sorting\n");

                List<string> softName = new List<string>();

                for(int i = 0; i < softs.Length; i++)
                {
                    softName.Add(softs[i].Soft);
                }

                softName.Sort();

                string[] softss = softName.ToArray();
                
                for(int i = 0; i < softss.Length; i++)
                {
                    Console.WriteLine(softss[i]);
                }
            }

        }
    }
}
