//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace LearnCs
//{
//    class File_and_Directory_Info
//    {
//        public static void Main(string[] args)
//        {
//            FileInfo fi = new FileInfo("test.txt");
//            if (fi != null)
//                Console.WriteLine("Information about file: {0}, {1} bytes, last modified on {2} - Full path: {3}", fi.Name, fi.Length, fi.LastWriteTime, fi.FullName);

//            DirectoryInfo di = new DirectoryInfo("../..");
//            if (di != null)
//            {
//                DirectoryInfo[] subDirs = di.GetDirectories();
//                if (subDirs.Length > 0)
//                {
//                    Console.WriteLine("Directories:");
//                    foreach(DirectoryInfo subDir in subDirs)
//                        Console.WriteLine("  " + subDir.Name);
//                }

//                FileInfo[] subFiles = di.GetFiles();
//                if (subFiles.Length > 0)
//                {
//                    Console.WriteLine("Files:");
//                    foreach(FileInfo subFile in subFiles)
//                        Console.WriteLine("   " + subFile.Name + " (" + subFile.Length + " bytes)");
//                }

//                FileInfo[] exeFiles = di.GetFiles("*.exe", SearchOption.AllDirectories);
//                if (exeFiles.Length > 0)
//                {
//                    Console.WriteLine("Exe:");
//                    foreach(FileInfo exeFile in exeFiles)
//                        Console.WriteLine("  " + exeFile.Name + " (" + exeFile.Length + " bytes)");
//                }
//            }
//            Console.ReadKey();
//        }
//    }
//}
