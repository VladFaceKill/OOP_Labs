using LABwork5.GamePlace;
using System;
using System.IO;

namespace LABwork5
{
    namespace TheSapper
    {
        internal class Sapper : Game
        {
            int gameSize;
            public Sapper(int gameSize, string type) : base(type)
            {
                this.gameSize = gameSize;
            }

            public int GameSize
            {
                set
                {
                    if (value > 0) gameSize = value;
                    else gameSize = 10;
                }
            }
        }
    }
}