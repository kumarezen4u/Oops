using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Const_readonly_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double expected = 78.74;
            //Act
            double actual = 2 * ConstantClass.const_inchesPerMeter;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTestInitializeValue()
        {
           string strYear =   ConstantClass.static_year;  // this variable only initialized ,value assigned on constructor 
            Assert.AreEqual(null, strYear);               // so variable is null
            string strmon = ConstantClass.static_month;
            Assert.AreEqual("March", strmon);
            ConstantClass constantClass = new ConstantClass();  // One the instance created for the class the constructor call and assign value 
            strYear = ConstantClass.static_year;  // so variable have value 
            Assert.AreEqual("2020", strYear);
        }


        [TestMethod]
        public void ReadonlyTestInitializeValue()
        {
           
            //Arrange
            double expected = 1.60934;
            //Act
            ConstantClass cc = new ConstantClass();
            double actual = cc.kilometer;
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ReadonlyTestConstructorValue()
        {
            //Arrange
            double expected = 1.60934;
            double tenKm = 10 * expected;
            //Act
            ConstantClass cc = new ConstantClass(tenKm);

            double actual = cc.tenmiles;
            //Assert

            Assert.AreEqual(tenKm, actual);
        }


        [TestMethod]
        public void ReadonlyInitializeValueAndChangedValue()
        {
            //Arrange
            string defaultexpected = "91";
            //Act
            ConstantClass cc = new ConstantClass();
            string defaultactual = cc.IndianCode;

            string Changedexpected = "+91";
            ConstantClass c2 = new ConstantClass("+91");

            string changedActual = c2.IndianCode;
            //Assert

            Assert.AreEqual(defaultexpected, defaultactual);
            Assert.AreEqual(Changedexpected, changedActual);
        }
    }

    //Constants
    //A constant represents information that is hard-coded into the application
    //A constant defined in a class and holds a hard-coded value that is expected to never change
    //Constant variable has to be initialize at the time of declaration.
    //A constant must be initialized to a value
    //Ex : public const double Pi = 3.14;
    //public const int Red = 0xFF0000;


    public class ConstantClass
    {

       // const variable can be declare and assign same time , not reinitialize 
        public const double const_inchesPerMeter = 39.37; 

       // public const double Pi;//  Error --> A const field requires a value to be provided  

        public readonly double kilometer = 1.60934;

        public readonly string IndianCode = "91";

        public static string static_year;

        public static string static_month = "March";

        public static readonly string CompanyName = "RRD";      //  static readonly  declaration itself initialize the value




        public static readonly string Pincode;


        public readonly double tenmiles;

        public ConstantClass()
        {
            static_year = "2020";
            //Pincode = "603202";   //Error  We cont change/ assign the  static readonly while constructor
        }

        public ConstantClass(double value)
        {
            this.tenmiles = value;
        }

        public ConstantClass(string changedCode)
        {
            this.IndianCode = changedCode;
        }

        public string disp()
        {
            static_year = "2021";
            return static_year;
        }


    }

    //Readonly variable can be assigned value only once.
    //Readonly never changed for the lifetime of the object
    //Must be initialized
    //In the declaration
    //Ex : public readonly decimal MinimumCharge = 25.00;
    //Or in the constructor
    //Ex : public readonly decimal MaximumCharge;
   
    //Think of a read-only field as "runtime" constant value

    public class ReadonlyClass 
    {
        public readonly decimal MinimumCharge = 25.00m;  //Must be initialized  -- In the declaration 
        public readonly decimal MaximumCharge;    //declare variable 

        ReadonlyClass()
        {
          MaximumCharge = 5.00m;   // must be assign value ---  in the constructor 
        }

        public void ChangeValue()
        {
          //  MaximumCharge = 10.00m;  Error  -- 
        }
    }
   }
