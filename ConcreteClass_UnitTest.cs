using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class ConcreteClass_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var square = new Square(5);
            square.GetArea();
        }
    }


    //Concrete class like a base class
    public class ConcreteRegularPolygon
    {
        public int Numberofsides { get; set; }

        public int SideLength { get; set; }

        public ConcreteRegularPolygon(int sides, int length)
        {
            Numberofsides = sides;
            SideLength = length;
        }

        public double GetParameter()
        {
            return Numberofsides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }

    public class Square : ConcreteRegularPolygon
    {
        //We created our own constructor
        // This calls the base class constructor with a value of 4 for the sides
        public Square(int length) : base(4, length)
        {

        }
        //  Overridden the GetArea method to provide an appropritae calculation
        public override double GetArea()
        {
            return SideLength * Numberofsides;
        }

    }

}
