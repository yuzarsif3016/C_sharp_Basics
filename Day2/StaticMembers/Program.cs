using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Class1.i = 100; // set value of static field i  
            Console.WriteLine(Class1.i); // get value of static field i
        }

        static void Main2() 
        { 
        
            Class1.X = 50; // set value of static property X
            Console.WriteLine(Class1.X); // get value of static property X
        }

        static void Main()
        {
            //Console.BackgroundColor = ConsoleColor.Cyan;


            Console.WriteLine("Hello there");
        }
    }
    public class Class1
    {
        public int K { get; set; }

        public static int i; // static field

        //how to declare the static property

        private static int x;
        public static int X
        {
            set
            {
                if (value < 100)
                    x = value; // set value of x --> small x
                else
                    Console.WriteLine("Invalid value of X ");
                // value is a keyword in C# that refers to the value being assigned to the property
            }
            get { return x; } // get value of x --> small x
        }

        public void add()
        {
            Console.WriteLine(i); // get value of static field i in non -static method
        }

        public static void add1()
        {
           // Console.WriteLine(K); // cannot access non-static field K in static method
        }
    }


    //static ctor example
    public class Class2
    {
        //when the class is loaded into memory?
        //when the first object of the class is created
        //when the static member of the class is accessed first time 
        //static ctor is implicitly private and cannot be called directly
        //doesnot take any parameters , so cannot be overloaded
        static Class2()
        {
            Console.WriteLine("Static ctor called "); // static constructor is called only once when the class is loaded into memory
        }
        public Class2()
        {
            Console.WriteLine("Default ctor called "); // default constructor is called every time an object is created
        }
    }
}
