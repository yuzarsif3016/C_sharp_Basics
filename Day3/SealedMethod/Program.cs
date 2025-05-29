using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Base
    {
        public virtual void M()
        {

            Console.WriteLine("Base M() called");
        }
    }

    public class Derived : Base
    {
        public sealed void M()
        {

            Console.WriteLine("Derived M() called");
        }
    }

    public class GrandDerived : Derived
    {
        public override void M() // This will cause a compile-time error because M() is sealed in Derived
        {
            Console.WriteLine("GrandDerived M() called");
        }
    }

}
