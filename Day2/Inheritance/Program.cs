using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main()
        {
            Derived derived = new Derived();
            derived.i = 10; // set value of i from base class
            derived.j = 20; // set value of j from derived class
            derived.add(); // call add method from derived class
        }
    }

    public class Base
    {
        public int i;

    }

    public class Derived : Base
    {
        public int j;
        public void add()
        {
            Console.WriteLine(i + j); // get value of i from base class and j from derived class
        }
    }
}

//Access Specifiers in C#
// 1. Public: Accessible from anywhere in the program
// 2. Private: Accessible only within the class in which it is declared
// 3. Protected: Accessible within the class in which it is declared and in derived classes
// 4. Internal: Accessible only within the same assembly (project)
// 5. Protected Internal: Accessible within the same assembly and in derived classes
// 6. Private Protected: Accessible only within the same class and in derived classes within the same assembly
// 7. Public Protected: Accessible only within the same assembly and in derived classes


