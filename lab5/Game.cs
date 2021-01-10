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
            protected bool isLose;
            protected string type;
            public Game(string type)
            {
                this.type = type;
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
