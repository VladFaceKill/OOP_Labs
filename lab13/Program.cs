using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //очистка возможно созданных прежде файлов и директориев
                Directory.Delete(@"D:\учеба\ООП\lab13\BVAInspect", true);
                File.Delete(@"D:\учеба\ООП\lab13\OOP_Lab13.sln");
                File.Delete(@"D:\учеба\ООП\lab13\BVAlogfile.txt");
            }
            catch 
            { }

            BVADiskInfo.PrintDiskInfo();
            BVAFileInfo.PrintFileInfo(@"D:\учеба\ООП\lab13\OOP_Lab13\ReadMe.txt");
            BVADirInfo.PrintDirInfo(new DirectoryInfo(@"D:\учеба\ООП"));
            BVAFileManager.PrintFileManager();
            BVALog.CloseFile();

            //для 6(шестого) задания
            BVALog.BVAWrite();
            BVALog.BVADeletePartOfFile(20);
        }
    }
}

