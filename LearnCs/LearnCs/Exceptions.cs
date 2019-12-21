//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnCs
//{
//    class Exceptions
//    {
//        public static void Main(string[] args)
//        {
//            try
//            {
//                int[] nums = new int[2];
//                nums[0] = 1;
//                nums[1] = 2;
//                nums[2] = 3;

//                foreach (int i in nums)
//                    Console.WriteLine(i);
//            }
//            catch (IndexOutOfRangeException ex)
//            {
//                Console.WriteLine("An index was out of range!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("An error has occured: (" + ex.GetType().ToString() + ") " + ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("It's the end of our try block. Time to clean up!");
//            }

//            Console.ReadKey();
//        }
//    }
//}
