using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABwork7.UserExceptions;

namespace LABwork7
{
    namespace Project
    {
        class DevProject
        {
            
            public void LoadProject(string path)
            {
                if (!(File.Exists(path))) throw new ReaderException("Path is empty or invalid", 400);
            }
        }
    }
}
