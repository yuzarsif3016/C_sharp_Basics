using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Program
    {
        static void Main()
        {
            Child child = new Child();
            child.M(); // Calls Child M()
            child.M(10); // Calls Parent M(int)
        }
    }

    public class Parent
    {
        public void M(int x)
        {
            Console.WriteLine("Parent M(int) called with " + x);
        }
       
    }
    public class  Child:Parent
    {
        public void M()
        {
            Console.WriteLine("Child M() called");
        }
    }
}
