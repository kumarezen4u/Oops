using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Inheritance_Multiple_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            C ObjC = new C();
            ObjC.fooA();
            // ObjC.fooB();
            ObjC.fooC();

        }
    }

    // Base Class
    public class A
    {
        public void fooA()
        {
            Console.WriteLine("A Class");
        }
    }

    //Base Class
    public class B
    {
        public void fooB()
        {
            Console.WriteLine(" B Class");
        }
    }

    //Derived Class
   // public class C : A, B  // cannot have multple base classes 'A' and 'B' 
    public class C : A
    {
        public void fooC()
        {
            Console.WriteLine("C Class");
        }
    }
}
