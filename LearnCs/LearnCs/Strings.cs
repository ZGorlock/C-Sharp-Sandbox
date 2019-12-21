//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnCs
//{
//    class Strings
//    {
//        static void Main(string[] args)
//        {
//            string myString = "A string.";
//            string emptyString = String.Empty;
//            string anotherEmptyString = "";

//            string firstName = "Eric";
//            string lastName = "Smith";
//            string fullName = firstName + " " + lastName;
//            Console.WriteLine(fullName);

//            string sentence = "I like to play ";
//            sentence += "chess.";
//            Console.WriteLine(sentence);

//            int x = 1, y = 2;
//            int sum = x + y;
//            string sumCalc = String.Format("{0} + {1} = {2}", x, y, sum);
//            Console.WriteLine(sumCalc);

//            string fullstring = "full string";
//            string partOfString = fullstring.Substring(5);
//            string shorterPart = fullstring.Substring(5, 3);
//            Console.WriteLine(partOfString);
//            Console.WriteLine(shorterPart);

//            string name = "John Doe";
//            string newName = name.Replace("John", "Eric");
//            Console.WriteLine(newName);

//            string fruit = "apple,orange,banana";
//            Console.WriteLine("Found orange in position: " + fruit.IndexOf("orange"));
//            Console.WriteLine("Found lemon in position: " + fruit.IndexOf("lemon"));

//            string first = "John";
//            string last = "Doe";
//            int age = 27;

//            string s = String.Format("{0} {1} is {2} years old.", first, last, age);
//            Console.WriteLine(s);

//            Console.ReadKey();
//        }
//    }
//}
