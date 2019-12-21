//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnCs
//{
//    class Classes
//    {
//        static void Main(string[] args)
//        {
//            Car car;

//            car = new Car("Red");
//            Console.WriteLine(car.Describe());

//            car = new Car("Green");
//            car.Color = "Purple"; 
//            Console.WriteLine(car.Describe());

//            Console.ReadKey();
//        }
//    }

//    class Car
//    {
//        private string color;

//        public Car(string color)
//        {
//            this.color = color;
//        }

//        public string Describe()
//        {
//            return "This car is " + Color;
//        }

//        public string Color
//        {
//            get { return color; }
//            set { color = value; }
//        }
//    }
//}
