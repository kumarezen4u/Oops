using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Inheritance_Hierarchical_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DerivedC ObjD = new DerivedC();
            ObjD.fooA();
            ObjD.fooC();
        }
    }

    //Base Class
    public class BaseA
    {
        public void fooA()
        {
            Console.WriteLine("BaseA Class");
        }
    }

    //Derived Class
    public class DerivedB : BaseA
    {
        public void fooB()
        {
            Console.WriteLine("DerivedB Class");
        }
    }

    //Derived Class
    public class DerivedC : BaseA
    {
        public void fooC()
        {
            Console.WriteLine("DerivedC Class");
        }
    }
}
