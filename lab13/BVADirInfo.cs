using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab13
{
    public static class BVADirInfo
    {
        public static void Files(DirectoryInfo dir)
        {
            int num = 0;
            foreach (var x in dir.GetFiles())
            {
                num++;
            }
            Console.WriteLine($"Number of files: {num}");
            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nChecking number if files in directory\nPath: {dir.FullName}\n@");
            Console.WriteLine();
        }
        public static void Time(DirectoryInfo dir)
        {
            Console.WriteLine($"Creation time: {dir.CreationTime}");
            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nChecking directory creation time\nPath: {dir.FullName}\n@");
            Console.WriteLine();
        }
        public static void SubDir(DirectoryInfo dir)
        {
            int num = 0;
            foreach (var x in dir.GetDirectories())
            {
                num++;
            }
            Console.WriteLine($"Number of subdirectories: {num}");
            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nChecking number of subdirectories\nPath: {dir.FullName}\n@");
            Console.WriteLine();
        }
        public static void ParentDir(DirectoryInfo dir)
        {
            Console.WriteLine($"Parent directory: {dir.Parent}");
            BVALog.OpenFile().WriteLine($"{DateTime.Now}\nChecking parent directory\nPath: {dir.FullName}\n@");
            Console.WriteLine();
        }

        public static void PrintDirInfo(DirectoryInfo dir)
        {
            Files(dir);
            Time(dir);
            SubDir(dir);
            ParentDir(dir);
        }
    }
}
