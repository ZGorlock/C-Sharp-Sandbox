//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace LearnCs
//{
//    class File_Manipulation
//    {
//        public static void Main(string[] args)
//        {
//            if (File.Exists("test.txt"))
//            {
//                File.Delete("test.txt");
//                if (File.Exists("test.txt") == false)
//                    Console.WriteLine("File deleted...");
//            }
//            else
//                Console.WriteLine("File does not exist");

//            if (Directory.Exists("a"))
//            {
//                Directory.Delete("a");
//                if (Directory.Exists("a") == false)
//                    Console.WriteLine("Directory deleted...");
//            }
//            else
//                Console.WriteLine("Directory does not exist");

//            if (File.Exists("test2.txt"))
//            {
//                File.Move("test2.txt", "test3.txt");
//                if (File.Exists("test3.txt"))
//                    Console.WriteLine("The file was renamed");
//            }

//            if (Directory.Exists("b"))
//            {
//                Directory.Move("b", "a");
//                if (Directory.Exists("a"))
//                    Console.WriteLine("The directory was renamed");
//            }

//            Directory.CreateDirectory("b");
//            if (Directory.Exists("b"))
//                Console.WriteLine("The directory was created");

//            Console.ReadKey();
//        }
//    }
//}
