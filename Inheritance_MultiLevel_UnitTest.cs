using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Inheritance_MultiLevel_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Derived2 ObjC = new Derived2();
            ObjC.DisplayA();
            ObjC.DisplayB();
            ObjC.DisplayC();

            Derived1 ObjF = new Derived1();
            ObjF.DisplayA();
            ObjF.DisplayB();
        }
    }
    //Base Class
    public class Base1
    {
        public void DisplayA()
        {
            Console.WriteLine("Base Class");
        }
    }

    //Derived Class
    public class Derived1 : Base1
    {
        public void DisplayB()
        {
            Console.WriteLine("Derived1 Class");
        }
    }

    //Derived Class
    public class Derived2 : Derived1
    {
        public void DisplayC()
        {
            Console.WriteLine("Derived2 Class");
        }
    }
}
