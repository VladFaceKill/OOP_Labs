using LABwork5.GamePlace;
using System;
using System.IO;

namespace LABwork5
{
    namespace TheSapper
    {
        partial class Sapper : Game
        {
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