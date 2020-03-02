using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Inheritance_Single_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChildClass child = new ChildClass();
            /* Parent Constructor. 
              Child Constructor. */
            child.print();   //I'm a Parent Class.
            child.print2();  //I'm a Child Class.

            ParentClass abc = new ChildClass();
            abc.print();
        /*    Parent Constructor. 
              Child Constructor.
              I'm a Parent Class.  */


        }
    }

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Constructor.");
        }

        public void print()
        {
            Console.WriteLine("I'm a Parent Class.");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Child Constructor.");
        }
        public void print2()
        {
            Console.WriteLine("I'm a Child Class.");
        }
    }
}
