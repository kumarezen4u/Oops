using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Inheritance_Hybrid_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Subclass3 ObjE = new Subclass3();
            ObjE.ShowA();   //SuperClass - ShowA
            ObjE.ShowB();   //Subclass1 - ShowB         
            ObjE.ShowD();   //Subclass3 - ShowD

            Subclass2 ObjF = new Subclass2();
            ObjF.ShowA();   //SuperClass - ShowA
            ObjF.ShowB();   //Subclass1 - ShowB 
            ObjF.ShowC();   //Subclass2 - ShowC

            Subclass4 ObjH = new Subclass4();         
            ObjH.ShowA();   //SuperClass - ShowA
            ObjH.ShowB();   //Subclass1 - ShowB         
            ObjH.ShowD();   //Subclass3 - ShowD
            ObjH.ShowG();   //Subclass4 - ShowG
        }
    }

    //Base Class
    public class SuperClass
    {
        public void ShowA()
        {
            Console.WriteLine("SuperClass - ShowA");
        }
    }

    //Derived Class
    public class Subclass1 : SuperClass
    {
        public void ShowB()
        {
            Console.WriteLine("Subclass1 - ShowB");
        }
    }

    //Derived Class
    public class Subclass2 : Subclass1
    {
        public void ShowC()
        {
            Console.WriteLine("Subclass2 - ShowC");
        }
    }

    //Derived Class
    public class Subclass3 : Subclass1
    {
        public void ShowD()
        {
            Console.WriteLine("Subclass3 - ShowD");
        }
    }

    //Derived Class
    public class Subclass4 : Subclass3
    {
        public void ShowG() 
        {
            Console.WriteLine("Subclass4 - ShowG");
        }
    }
}
