using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Program
    {
        static void Main()
        {
            Derived d = new Derived();
            d.M(); // Calls Derived M()
        }
    }
    public class Base
    {
        public void M()
        {

            Console.WriteLine("Base M() called");
        }
    }

    public class Derived : Base
    {
        public new void M()
        {

            Console.WriteLine("Derived M() called");
        }
    }

}
