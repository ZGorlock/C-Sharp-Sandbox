//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnCs
//{
//    class Methods
//    {
//        public static void Main(string[] args)
//        {
//            int a = 55;
//            int b = 10;

//            Console.WriteLine(Multiply(a, b));

//            int c = 0;
//            Multiply2(a, b, ref c);
//            Console.WriteLine(c);

//            int d;
//            Multiply3(a, b, out d);
//            Console.WriteLine(d);

//            Console.WriteLine(Multiply4(10, 3, 2, 4, 5));

//            Console.ReadKey();
//        }

//        public static int Multiply(int a, int b)
//        {
//            return a * b;
//        }

//        public static void Multiply2(int a, int b, ref int c)
//        {
//            c = a * b;
//        }

//        public static void Multiply3(int a, int b, out int c)
//        {
//            c = a * b;
//        }

//        public static int Multiply4(params int[] nums)
//        {
//            int product = 1;
//            foreach (int i in nums)
//                product *= i;
//            return product;
//        }
//    }
//}
