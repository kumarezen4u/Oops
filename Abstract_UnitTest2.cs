using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Abstract_UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            iPhone5s iphone5s = new iPhone5s();
            //  iPhone phone = new iPhone(); //Error Cannot create an instance of the abstract class or interface 
            iphone5s.Call();
            iphone5s.Model();
            iphone5s.LaunchDate();
            iPhone.Company();    //Use abstract class name use to access static methods 

 /*oupput     Abstract class constructor
              Call Method: This method provides Calling features
              Model: The model of this iPhone is iPhone5s
              Launch Date: This iPhone was launched on 20- September-2013
             Abstract class Company(): executed - Apple
  */

    }
    }

    //  An interface only allows you to define functionality, not implement it
    abstract class iPhone
    {
        public iPhone()  //It can contains constructors or destructors
        {
            Console.WriteLine("Abstract class constructor");
        }

        //It can implement functions with non-Abstract methods.
        public void Call()
        {
            Console.WriteLine("Call Method: This method provides Calling features");
        }

        //Abstract Method   
        public abstract void Model();

        // Abstract 

        //abstract void OSVersion();   Error virtual or abstract members cannot be private 

        // public abstract void Price(); // Created new abstract method Price() 
        //Error Drived class must implementation inherited abstract method Price()

        //  public abstract void Color(string color);  
        // { Console.WriteLine("Abstract Method Color(): executed - color: {0}", color); }  //Error - Cannot declare a body because it is marked abstract 

        public static void Company()  //new Static method define and implemented  
        {
            Console.WriteLine("Abstract class Company(): executed - Apple");
        }
    }

    abstract class IOS   //  Another abstract class 
    {
        public abstract void IOSVersion();
    }

    // class iPhone5s : iPhone, IOS    Error - cannot inherit more then one abstract class (inherit from one base abstract class only.)
    class iPhone5s : iPhone
    {
        //Abstract Method Implementation   
        public override void Model()
        {
            Console.WriteLine("Model: The model of this iPhone is iPhone5s");
        }

        //Derived Class Local Method   
        public void LaunchDate()
        {
            Console.WriteLine("Launch Date: This iPhone was launched on 20- September-2013");
        }
    }
}
