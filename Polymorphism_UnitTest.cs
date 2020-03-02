using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    /*   Types of Polymorphism 
         1 . Static Polymorphism /compile-time polymorphism /Early binding    -- >1. Method Overloading ,Function Overloading  2. Operator Overloading
         2 . Dynamic polymorphism/Run time polymorphism /Late binding   --> Method Overriding 

         Method Overloading   --->  add(int a, int b) ,add(float x, float y) , add(string s1, string s2)
                                         -->1) Method Name is going to be the same 
                                         -->2) Number ,Type and order of Parameter is different 
         Function Overloading in C# allows a class to have multiple methods with the same name but with a different signature
         C# functions or methods can be overloaded based on the number, type (int, float, etc), order and kind (Value, Ref or Out) of parameters

         Function Overloading
         Class1:  Public virtual void show(){} //virtual function (overridable)

         Class2: Class1      Public override void show(){} //overriding
         keyword virtual, then only the child classes get the permission for overriding that method.

        If the superclass method logic is not fulfilling the sub-class business requirements, 
        then the subclass needs to override that method with required business logic. 
        Usually, in most of the real-time applications, 
        the superclass methods are implemented with generic logic which is common for all the next level sub-classes.

     */


    //  More then one form. Ability to provide different implementation based on different number  or type of parameters 
    //   Method Overloading (compile time polymorphism)
    //   Same method name but with different operations
    //   Advantage : simple name can be used for same type of methods 
    [TestClass]
    public class Polymorphism_UnitTest
    {
        [TestMethod]
        public void Overloading_TestMethod() 
        {
            TestOverloading obj = new TestOverloading();
            string strRes =   obj.Add("Be ", "Happy"); // Be Happy
            object strInt = obj.Add(10,20,30); // 60
            strInt = obj.Add(10, 2.5f); //
        }

        [TestMethod]
        public void Overriding_TestMethod() 
        {
            Base objBase;
            objBase = new Base();
            objBase.Show();    //    Output ----> Show From Base Class.

            objBase = new Derived();
            objBase.Show();   //Output--> Show From Derived Class.

            Derived dd = new Derived();
            Console.WriteLine(dd.DataShow(3));  //DataShow
            dd.Display();   //Derived Class with additional method
            dd.Show();      //Show From Derived Class.

        }
    }

    // one or more method with Same name with same return type but different parameter
    public class TestOverloading
    {
        public string Add(string a1, string a2)
        {
           return ( a1 + a2);
        }

        public int Add(int a1, int a2)
        {
            return (a1 + a2);
        }
        public int Add(int a1, int a2, int a3)
        {
            return (a1 + a2+ a3);
        }
        public float Add(int a1, float a2) 
        {
            return (a1 + a2);
        }
        //public int Add(int a3, int a4)//already defines a member called 'Add' with the same parameter types	
        //{
        //    return 1;
        //}
        public void Add()
        {

        }
        public int Add(int num1)
        {
            return num1++;
        }
    }

    public class Base
    {
        public virtual string DataShow(int a)
        {
            return "DataShow";
        }
        public virtual void Show()
        {
            Console.WriteLine("Show From Base Class.");
        }
    }

    public class Derived : Base
    {
        public override void Show()
        {
            Console.WriteLine("Show From Derived Class.");
        }
        public void Display()
        {
            Console.WriteLine("Derived Class with additional method");
        }
        public string DataShow(int a)
        {
            return "DataShow";
        }
    }

}
