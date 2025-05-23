using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
     class Program
    {
        static void Main1(string[] args)
        {
            Class1 class1 = new Class1();
            //class1.i = 100;
           // Console.WriteLine(class1.i); // 100

            class1.SetX(50);
            Console.WriteLine(class1.GetX()); // 50
        }

        static void Main2()
        {
            Class2 class2 = new Class2();
            class2.X = 10; // set value of X
            Console.WriteLine(++class2.X); // get value of X
        }

        static void Main3()
        {
            
            Class3 class3 = new Class3();
            class3.P2 = "xyz"; // set value of P2
            Console.WriteLine(class3.P2); // get value of P2
        }

        static void Main()
        {


        }
    }

    public class Class1
    {
        public int i; // field

        private int x;

        public void SetX(int VALUE)
        {
            if (VALUE < 100)
            {
                x = VALUE;
            }
            else
            {
                Console.WriteLine("Invalid value of X ");
            }
        }

        public int GetX()
        {
            return x;
        }
    }

    public class Class2
    {
        private int x;
        public int X
        {
            set {
                if (value < 100)
                    x = value; // set value of x --> small x
                else
                    Console.WriteLine("Invalid value of X ");
                // value is a keyword in C# that refers to the value being assigned to the property

            }

            get {

                return x; // get value of x --> small x

            }
        }
    }

    public class Class3
    {
        private string x;
        
        public string X
        {
            set {   
            
                if(value == null)
                    Console.WriteLine("Invalid value of x");
                else
                    x = value; // set value of x --> small x
            }
        }



        //read-only property 
        private string p1 = "abc";
        public string P1
        {


            get
            {
                return p1; // get value of p1 --> small p1
            }
        }

        
        public string P2 { get; set; } // auto-implemented property

        //internally auto-implemented property does the same thing as below
        //private string p2;
        //public string P2
        //{
        //    get { return p2; } // get value of p2 --> small p2
        //    set { p2 = value; } // set value of p2 --> small p2
        //}

    }

    public class Class4 
    { 

    }


}
