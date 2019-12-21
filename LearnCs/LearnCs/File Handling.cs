//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace LearnCs
//{
//    class File_Handling
//    {
//        static void Main(string[] args)
//        {
//            if (File.Exists("test.txt"))
//            {
//                string content = File.ReadAllText("test.txt");
//                Console.WriteLine("Current content of file: ");
//                Console.WriteLine(content);
//            }
//            Console.WriteLine("Please enter new content for the file: ");
//            string newContent = Console.ReadLine();
//            while (newContent != "exit")
//            {
//                File.AppendAllText("test.txt", newContent + Environment.NewLine);
//                newContent = Console.ReadLine();
//            }

//            StreamWriter sw = new StreamWriter("test2.txt");
//            string nc = Console.ReadLine();
//            while (nc != "exit")
//            {
//                sw.Write(nc + Environment.NewLine);
//                nc = Console.ReadLine();
//            }
//            sw.Close();

//            Console.ReadKey();
//        }
//    }
//}
