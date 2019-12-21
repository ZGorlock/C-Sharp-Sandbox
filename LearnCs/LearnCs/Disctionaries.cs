//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnCs
//{
//    class Disctionaries
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, long> phonebook = new Dictionary<string, long>();
//            phonebook.Add("Alex", 4154346543);
//            phonebook["Jessica"] = 4159484588;

//            if (phonebook.ContainsKey("Alex"))
//            {
//                Console.WriteLine("Alex's number is " + phonebook["Alex"]);
//            }

//            phonebook.Remove("Alex");
//            Console.WriteLine(phonebook.Count);


//            Dictionary<string, int> inventory = new Dictionary<string, int>();
//            inventory.Add("apple", 3);
//            inventory.Add("orange", 4);
//            inventory.Add("banana", 2);

//            Console.WriteLine(inventory["apple"]);
//            Console.WriteLine(inventory["orange"]);
//            Console.WriteLine(inventory["banana"]);

//            Console.ReadKey();
//        }
//    }
//}
