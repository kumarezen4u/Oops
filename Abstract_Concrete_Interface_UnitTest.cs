using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Abstract_Concrete_Interface_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            Console.WriteLine("Abstract Using Inheritance");
            Tri_Angle obj1 = new Tri_Angle(12);
            Console.WriteLine("Triangle Area Calculation  : " + obj1.GetArea());
            Console.WriteLine("Triangle Calculation : " + obj1.GetCalc());


            Console.WriteLine("Concrete Using Inheritance");
            SquareArea obj2 = new SquareArea(12);
            Console.WriteLine("Square Area Calculation : " + obj2.GetArea());
            Console.WriteLine("Square Calculation : " + obj2.GetCalc()); // Accessing Base class Method GetParameter

            Console.WriteLine("Interface Using Inheritance");
            Octagon_ obj3 = new Octagon_(12); 
            Console.WriteLine("Octagon Area Calculation : " + obj3.GetArea());
            Console.WriteLine("Octagon Calculation : " + obj3.GetCalc());


        /*  Abstract Using Inheritance
            Triangle Area Calculation  : 15.5884572681199
            Triangle Calculation : 36

            Concrete Using Inheritance
            Square Area Calculation : 48
            Square Calculation : 48

            Interface Using Inheritance
            Octagon Area Calculation : 695.293505963451
            Octagon Calculation : 96  */
        }
    }

    /* Abstract
    It means that we cannot create an instance of the class because it has member that aren't implemented.
    Instead , we must create a child class that implements those members
    The class can inherit only one Abstract Class */
    public abstract class AbstractPolygoncs
    {
        public int Numberofsides { get; set; }

        public int SideLength { get; set; }

        public AbstractPolygoncs(int sides, int length)
        {
            Numberofsides = sides;
            SideLength = length;
        }

        public double GetParameter()
        {
            return Numberofsides * SideLength;
        }

        //One or More Abstract Methods
        //only the method declaration  Abstract methods cannot have body.
        public abstract double GetArea();

        // Possible to add Virtual method 
        public virtual double GetCalc()
        {
            throw new NotImplementedException();
        }
    }

    // Child class
    public class Tri_Angle : AbstractPolygoncs
    {
        //this calls the base class constructor with a value of 3 for the sides
        public Tri_Angle(int length) : base(3, length) { } 

        public override double GetArea()
        {
            return Numberofsides * SideLength * Math.Sqrt(3) / 4;
        }

        public override double GetCalc()
        {
            return Numberofsides * SideLength;
        }
    }


    //Concrete class like a base class
    public class ConcretePolygon 
    {
        public int Numberofsides { get; set; }

        public int SideLength { get; set; }

        public ConcretePolygon(int sides, int length) 
        {
            Numberofsides = sides;
            SideLength = length;
        }

        public double GetCalc()
        {
            return Numberofsides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }

        //public abstract double GetParimeter(); //Error  you can't have an abstract method in a concrete class.
    }

    public class SquareArea : ConcretePolygon
    {
        //We created our own constructor
        // This calls the base class constructor with a value of 4 for the sides
        public SquareArea(int length) : base(4, length) 
        {

        }
        //  Overridden the GetArea method to provide an appropriate calculation
        public override double GetArea()
        {
            return SideLength * Numberofsides;
        }

    }

    //Interface Just a Contract NO Implementation (just declaration)
    //Interface is similar to purely Abstract Class
    //Interfaces can extend other interfaces ( one or more ) but not classes ( abstract or not ). A Class can implement multiple interfaces
    //The interface does not have access modifiers.Everything defined inside the interface is assumed public modifier.
    public interface InterfacePloygon
    {
        int Numberofsides { get; set; }
        int SideLength { get; set; }
        double GetCalc();
        double GetArea();
    }

    public class Octagon_ : InterfacePloygon 
    {
        public int Numberofsides { get; set; }
        public int SideLength { get; set; }
        public Octagon_(int length) 
        {
            Numberofsides = 8;
            SideLength = length;
        }
        public double GetCalc()
        {
            return Numberofsides * SideLength;
        }
        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
