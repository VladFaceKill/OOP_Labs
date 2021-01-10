using System;
using System.Collections.Generic;
using System.Text;
using LABwork5.Operations;

namespace LABwork5
{
    namespace GamePlace
    {
        internal class Game
        {
            public struct Update
            {
                public string currentVersion;
                public bool isReady;
                public Update(string version, bool isReady=false)
                {
                    currentVersion = version;
                    this.isReady = isReady;
                }

                public void ShowCurrentVersion() => Console.WriteLine($"Current version is {currentVersion}");
                public void CheckForUpdate()
                {
                    if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 20) { isReady = true; Console.WriteLine("update is ready"); }
                    else { isReady = false; Console.WriteLine("update is invalid"); }
                }
                public void InstallUpdate(bool isReady, string upd)
                {
                    if (isReady)
                    {
                        Console.WriteLine("Updating was successfull");
                        currentVersion = upd;
                    }
                    else
                    {
                        Console.WriteLine("Not now, sorry");
                    }
                }
            }

            protected bool isLose;
            protected string type;
            string name;
            public Game(string type, string name)
            {
                this.type = type;
                this.name = name;
            }

            public string GetGameType
            {
                get
                {
                    return type;
                }
                set
                {
                    type = value;
                }
            }

            public string GetGameName
            {
                get
                {
                    return name;
                }
            }

            public void Start() {
                Console.WriteLine("Game is starting!");
            }
            public void Save() {
                Console.WriteLine("Checkpoint :3");
            }
            public void Reset()
            {
                Console.WriteLine("Your current progrss is disappear, you'll be back to your last checkpoint");
            }

            public void ShowGameType()
            {
                Console.WriteLine("Game type is => " + type);
            }
            public virtual void PrintInfo(object obj)
            {
                Console.WriteLine($"Game type is {type}");
            }
            public override string ToString()
            {
                string forReturn = $"Game type is {type}";
                return forReturn;
            }
        }
    }
}
