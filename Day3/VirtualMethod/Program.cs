using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    public class Program
    {
        static void Main()
        {
            
            Base b = new Base();
            b.M(); // Calls Base M()

            Derived d = new Derived();
            d.M(); // Calls Derived M()

            Base bd = new Derived();
            bd.M(); // Calls Derived M() due to polymorphism
            Console.ReadLine(); // Keep the console window open
        }
    }

    public class Base
    {
        public virtual void M() { 
        
            Console.WriteLine("Base M() called");
        }
    }

    public class Derived : Base
    {
        public override void M()
        {

            Console.WriteLine("Derived M() called");
        }
    }
    
        
    
}
