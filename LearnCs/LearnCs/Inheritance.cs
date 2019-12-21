//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearnCs
//{
//    class Inheritance
//    {
//        public static void Main(string[] args)
//        {
//            Dog dog = new Dog();
//            dog.Name = "Spot";

//            dog.Describe();

//            Console.ReadKey();
//        }
//    }

//    class FourLeggedAnimal
//    {
//        protected string name;

//        public virtual void Describe()
//        {
//            Console.WriteLine("I am a four-legged animal.");
//        }
//    }

//    class Dog : FourLeggedAnimal
//    {
//        public override void Describe()
//        {
//            base.Describe();
//            Console.WriteLine("I am a dog. My name is " + this.Name);
//        }

//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//    }
//}
