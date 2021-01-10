using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace OOP_Lab13
{
    public static class BVAFileManager
    {
        public static void WriteInFile()
        {
            string[] NumOfFiles = new string[50];
            string[] NumOfDir = new string[50];
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            Directory.CreateDirectory(@"D:\учеба\ООП\lab13\BVAInspect");
            StreamWriter dirfile = new StreamWriter(@"D:\учеба\ООП\lab13\BVAInspect\BVAdirinfo.txt", true);
            dirfile.WriteLine("-----------Files-----------:");
            foreach (var x in dir.GetFiles())
            {
                dirfile.WriteLine($"{x}");
            }
            dirfile.WriteLine("\n-----------Directories-----------");
            foreach (var y in dir.GetDirectories())
            {
                dirfile.WriteLine($"{y}");
            }
            dirfile.Close();
            Console.WriteLine("File BVAdirinfo.txt is created");
            BVALog.OpenFile();

            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nCreating BVAdirinfo.txt\nPath: {dir.FullName}\n@");
        }

        public static void CopyAndRenameFile()
        {
            File.Copy(@"D:\учеба\ООП\lab13\BVAInspect\BVAdirinfo.txt", @"D:\учеба\ООП\lab13\BVAInspect\BVAdirinfoNew.txt");
            Console.WriteLine("File BVAdirinfo.txt is copied and renamed");

            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nCopying and renaming BVAdirinfo.txt\nPath: D:\\учеба\\ООП\\lab13\\BVAInspect\\BVAdirinfo.txt@");
        }

        public static void DeleteOldFile()
        {
            File.Delete(@"D:\учеба\ООП\lab13\BVAInspect\BVAdirinfo.txt");
            Console.WriteLine("File BVAdirinfo.txt is deleted");
            Console.WriteLine();

            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nDeleting old BVAdirinfo.txt\nPath: D:\\учеба\\ООП\\lab13\\BVAInspect\\BVAdirinfo.txt@");
        }

        public static void NewDir()
        {
            Directory.CreateDirectory(@"D:\учеба\ООП\lab13\BVAFiles");
            DirectoryInfo dir = new DirectoryInfo(@"D:\учеба\ООП\lab13\OOP_Lab13");
            foreach (var x in dir.GetFiles())
            {
                if (Equals(x.Extension, ".sln"))
                {
                    File.Copy(@"D:\учеба\ООП\lab13\OOP_Lab13\" + x.Name, @"D:\учеба\ООП\lab13\BVAFiles\" + x.Name);
                }
            }
            Console.WriteLine("New directory BVAFiles is created");

            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nCreating directory BVAFiles\nPath: {dir.FullName}\n@");
        }

        public static void MoveNewDir()
        {
            Directory.Move(@"D:\учеба\ООП\lab13\BVAFiles", @"D:\учеба\ООП\lab13\BVAInspect\BVAFilesNEW");
            Console.WriteLine("New directory BVAFiles is moved");

            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nMoving directory BVAFiles\nPath: D:\\учеба\\ООП\\lab13\\BVAInspect\\BVAFiles");
        }

        public static void Zip()
        {
            ZipFile.CreateFromDirectory(@"D:\учеба\ООП\lab13\BVAInspect\BVAFilesNEW", @"D:\учеба\ООП\lab13\BVAInspect\Archive.rar");
            Console.WriteLine("Zip Archive.rar is created");

            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nCreating Zip Archive.rar\nPath: D:\\учеба\\ООП\\lab13\\BVAInspect\\BVAFiles\n@");
        }
        public static void Unzip()
        {
            ZipFile.ExtractToDirectory(@"D:\учеба\ООП\lab13\BVAInspect\Archive.rar", @"D:\учеба\ООП\lab13");
            Console.WriteLine("Unzipping is successful");

            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nUnzipping Archive.rar\nPath:  D:\\учеба\\ООП\\lab13\\BVAInspect\n@");
        }

        public static void PrintFileManager()
        {
            WriteInFile();
            CopyAndRenameFile();
            DeleteOldFile();
            NewDir();
            MoveNewDir();
            Zip();
            Unzip();
        }
    }
}
