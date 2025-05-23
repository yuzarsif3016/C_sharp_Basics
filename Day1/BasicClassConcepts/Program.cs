using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    public class Demo
    {
        static void Main1(string[] args)
        {
            Class1 class1; // reference variable
            class1 = new Class1(); //object
            class1.Display();
        }

        static void Main2(string[] args)
        {
            Class1 class1; // reference variable
            class1 = new Class1(); //object
            class1.Display(10,20);
        }


        static void Main3(string[] args)
        {
            Class1 class1; // reference variable
            class1 = new Class1(); //object


            class1.Add(10, 20); //calling default paramters method
            class1.Add();
        }

        static void Main4(string[] args)
        {
            Class1 class1; // reference variable
            class1 = new Class1(); //object


            class1.Add(10, 20); //calling default paramters method


            class1.Add(a:20); // named parameters
        }

        static void Main()
        {
            int a = 100;


            //local function
            LocalFunc();

            Console.WriteLine(a); //can change value of a

            void LocalFunc()
            {
                a++; //can access outer variable
                //Console.WriteLine(a);
            }
        }
    }
    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Hello display ");
        }

        public void Display(int a,int b)
        {
            Console.WriteLine("Hello display " + a);
        }

        public void Add(int a=0,int b = 0) //default parameters  -- should be last in the sequence
        {
            int c = a + b;
            Console.WriteLine("Hello display " +c);
        }
    }
}
