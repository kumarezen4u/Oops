using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    //A abstract class is class that must be inherited and have the methods overridden 
    //An abstract class is essentially a blue print for a class without any implementation 
    //An abstract class can have abstract members as well as not abstract members 
    //An abstract class cannot be instantiated 


    //Rules applied to abstract classes
    //1. an abstract class cannot be a sealed class , an abstract class cannot be a static class

    //Ex 
    //abstract sealed class exsealedclass //Error --> 'exsealedclass' an abstract class cannot be sealed or static  
    // {

    // }

    // abstract static class exstaticclass //Error --> 'exsealedclass' an abstract class cannot be sealed or static  
    // {

    // }

    //2.An abstract method cannot be private 
    //Ex
    //private abstract int GetArea1(int sides, int length);  // Error --> virtual or abstract members cannot be private  
    //3.An abstract method canot have the modifier virtual because an abstract method is implicitly virtual 
    // public abstract virtual int GetArea2(int sides, int length); // Error --> cannot be marked virtual

    // But an interface all the member are implicitly abstract and all the members of the interface must override to its derived class

    [TestClass]
    public class Abstract_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            AbstractBase abstractBase = new AbstractBase();
            abstractBase.Display("Base Class ");
            abstractBase.Print("Base Class");
            Abstract1 abstract1 = new AbstractBase();
            abstract1.Display("Abstract Class");
            //  abstractBase = new Abstract1(); Error Cannot create an instance of the abstract class or interface 
        }

        [TestMethod]
        public void TestMethod2()
        {
            Triangle triangle = new Triangle(5);
             double res= triangle.GetArea();
            Assert.AreEqual(6.4951905283832891, res);           
        }
    }


    public abstract class Abstract1
    {
        public Abstract1()
        {

        }
        public abstract void Display(string msg);

        public void Print(string msg)
        {
            Console.WriteLine("Print Message {0}", msg);
        }
    }

    public abstract class Abstract2
    {
        public Abstract2()
        {

        }
        public abstract void Display(string msg);
    }


    //     public class AbstractBase :Abstract1 ,Abstract2 -->   'AbstractBase' cannot have multiple base classes: 'Abstract1' and 'Abstract2'	

    public class AbstractBase : Abstract1
    {
        public override void Display(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    //--------------------- Example 2   ----------------------

    //abstract
    // It means that we connot create an instance of the class because it has member that aren't implemented.
    //Instead , we must create a child class that implements those members
    public abstract class AbstractRegularPolygoncs
    {
        public int Numberofsides { get; set; }

        public int SideLength { get; set; }

        public AbstractRegularPolygoncs(int sides, int length)
        {
            Numberofsides = sides;
            SideLength = length;
        }

        public double GetParameter()
        {
            return Numberofsides * SideLength;
        }
        // private abstract int GetArea1(int sides, int length);  // Error --> virtual or abstract members cannot be private  

       // public abstract virtual int GetArea2(int sides, int length); // Error --> cannot be marked virtual

        //One or More Abstract Members
        //only the method declaration  not provide the method body
        public abstract double GetArea();

        // Abstract class can have Private as well as Protected  members 
        // An Interface can have only public member 
        private string display()
        {
            return "Display method of Abstract class private method";
        }

        protected string disp() 
        {
            return "Display method of Abstract class protected method";
        }

    }

    // Child class
    public class Triangle : AbstractRegularPolygoncs
    {
        public Triangle(int length) : base(3, length) { }        

        public override double GetArea()
        {
            return Numberofsides * SideLength * Math.Sqrt(3) / 4;
        }       
    }
}


// Class Type                Normal Class           Static Class          Sealed Class       Abstract Class
// can be instantiated           Yes                  No                      Yes               No
// can be inherited              Yes                  No                      No                Yes
// can inherited form other      Yes                  No                      Yes               Yes  