﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorAndObjInitializers
{
     class Program
    {
        static void Main1(string[] args)
        {
            Class1 class1 = new Class1();
           
            Console.WriteLine(class1.X);

            Class1 class2 = new Class1(90);
            Console.WriteLine(class2.X); // 90
        }
        static void Main2()
        {
            Class2 class2 = new Class2() { X = 10, P1 = "abc", P2 = "xyz" }; // internally call setter for all the props
        }

        static void Main()
        {

        }
    }

    //constructor example 
    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("Default ctor called ");

            X = 10; // set value of X --> property
            x = 20;// set value of x --> field --> use incase of readonly property
        }

        //parameterized constructor example
        public Class1(int x)
        {
            Console.WriteLine("Parameterized ctor called ");
            this.X = x; // set value of X --> property
            this.x = x; // set value of x --> field --> use incase of readonly property
        }

        private int x;
        public int X
        {
            set
            {
                if (value < 100)
                    x = value; // set value of x --> small x
                else
                    Console.WriteLine("Invalid value of X ");
                // value is a keyword in C# that refers to the value being assigned to the property

            }

            get
            {

                return x; // get value of x --> small x

            }
        }

        
        private int X1 { get; set; }  
    }

    //object initializers example
    public class Class2
    {
        public int X { get; set; } // property
        public string P1 { get; set; } // property
        public string P2 { get; set; } // property
        public Class2()
        {
            Console.WriteLine("Default ctor called ");
        }
    }
}
