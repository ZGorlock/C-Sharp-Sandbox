//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnCs
//{
//    class Lists
//    {
//        static void Main(string[] args)
//        {
//            List<int> numbers = new List<int>();
//            numbers.Add(1);
//            numbers.Add(2);
//            numbers.Add(3);

//            int[] array = new int[] { 4, 5, 6 };
//            numbers.AddRange(array);

//            Console.WriteLine(numbers[0] + " " + numbers[1] + " " + numbers[2] + " " + numbers[3] + " " + numbers[4] + " " + numbers[5]);


//            List<string> fruits = new List<string>();
//            fruits.Add("apple");
//            fruits.Add("banana");
//            fruits.Add("orange");

//            Console.WriteLine(fruits.Count);
//            fruits.Remove("banana");
//            Console.WriteLine(fruits.Count);

//            fruits.RemoveAt(0);
//            Console.WriteLine(fruits.Count);

//            List<string> food = new List<string>();
//            List<string> vegetables = new List<string>();
//            vegetables.Add("broccoli");
//            vegetables.Add("Beans");
//            vegetables.Add("Carrots");

//            food.AddRange(fruits);
//            food.AddRange(vegetables);
//            Console.WriteLine(food.Count);

//            List<int> primeNumbers = new List<int> { 1, 2, 3, 5, 7 };
//            Console.WriteLine(primeNumbers.Count);
//            Console.WriteLine(primeNumbers[0]);
//            Console.WriteLine(primeNumbers[1]);
//            Console.WriteLine(primeNumbers[2]);
//            Console.WriteLine(primeNumbers[3]);
//            Console.WriteLine(primeNumbers[4]);

//            Console.ReadKey();
//        }
//    }
//}
