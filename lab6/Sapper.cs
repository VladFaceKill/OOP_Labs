using LABwork5.GamePlace;
using System;
using System.IO;

namespace LABwork5
{
    namespace TheSapper
    {
        partial class Sapper : Game
        {
            int gameSize;
            public Sapper(int gameSize, string type, string name) : base(type, name)
            {
                this.gameSize = gameSize;
            }
        }
    }
}