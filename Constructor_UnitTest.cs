using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Constructor_UnitTest
    {
        [TestMethod]
        public void Constructors_TestMethod()
        {
            Constructors con = new Constructors();
        }

        [TestMethod]
        public void DefaultConstructor_TestMethod()
        {
            DefaultConstructor defaultcort = new DefaultConstructor();
            string result = defaultcort.name;
            Assert.AreEqual("Default Constructor Invoked", result);
            //A default constructor has every instance of the class to be initialized to the same values
            //The default constructor initializes all numeric fields to zero and all string and object fields to null inside a class.
            Assert.AreEqual(defaultcort.num, 0);
            Assert.AreEqual(defaultcort.str, null);
            Assert.AreEqual(defaultcort.obj, null);
            Assert.AreEqual(defaultcort.MyObject, null);
        }

        [TestMethod]
        public void ParameterizedConstructor_TestMethod()
        {
            ParameterizedConstructor parameterizedConstructor = new ParameterizedConstructor();
            Assert.AreEqual("Default Constructor Invoked", parameterizedConstructor.name);
            Assert.AreEqual(0, parameterizedConstructor._Id);
            // This will invoke parameterized  constructor.
            parameterizedConstructor = new ParameterizedConstructor(10);
            // This time default constructor not invoked 
            Assert.AreEqual(1, ParameterizedConstructor.count);
            // This time  Parameterized  constructor only invoked 
            Assert.AreEqual(1, ParameterizedConstructor.parameterizedCount);
            Assert.AreEqual(10, parameterizedConstructor._Id);
        }

        [TestMethod]
        public void CopyConstructor_TestMethod()
        {     // Create a new CopyConstructor object. 
            CopyConstructor copyConstructor = new CopyConstructor("Aug", 1982);
            Assert.AreEqual(1, CopyConstructor.parameterizedCount);
            // here is copyConstructor details is copied to copyConstructor1. 
            CopyConstructor copyConstructor1 = new CopyConstructor(copyConstructor);
            Assert.AreEqual(1, CopyConstructor.copyctor_count);
        }

        [TestMethod]
        public void PrivateConstructor_TestMethod()
        {
            // PrivateConstructor privateConstructor = new PrivateConstructor(); //Error 'PrivateConstructor.PrivateConstructor()' is inaccessible due to its protection level  

            Assert.AreEqual(PrivateConstructor.Calc_Count(), 1);
            Assert.AreEqual(PrivateConstructor.pvt_count, 0);
            PrivateConstructor.pvt_count = 100;
            PrivateConstructor.count = 100;
            Assert.AreEqual(PrivateConstructor.Calc_Count(), 101);
            Assert.AreEqual(PrivateConstructor.pvt_count, 100);
        }
    }


    class Constructor
    {
    }
    //constructor is a special method which is invoked automatically at the time of object creation
    //Constructor of a class must have the same name as the class name in which it resides.
    //A constructor can not be abstract, final, static and Synchronized.
    //Within a class, you can create only one static constructor.

    //A constructor doesn’t have any return type, not even void.
    //A static constructor cannot be a parameterized constructor.
    //A class can have any number of constructors.
    //Access modifiers can be used in constructor declaration to control its access i.e which other class can call the constructor.


    //Types of Constructor

    //Default Constructor
    //Parametrized Constructor
    //Copy Constructor
    //Private Constructor
    //Static Constructor

    public class DefaultConstructor
    {
        public int num;
        public object obj;
        public string str;
        public string name;
        public object MyObject { get; set; }

        // this would be invoked while the object of that class created. 
        //A constructor with no parameters is called a default constructor

        public DefaultConstructor()
        {
            name = "Default Constructor Invoked";
        }
    }

    public class ParameterizedConstructor
    {
        public static int count = 0;
        public static int parameterizedCount = 0;
        public int _Id { get; private set; }
        public string name;
        public ParameterizedConstructor()
        {
            name = "Default Constructor Invoked";
            count++;
        }
        //A constructor have at least one parameter is called a parametrized constructor.
        // It can initialize each instance of the class to different values.
        public ParameterizedConstructor(int id)
        {
            _Id = id;
            parameterizedCount++;
        }
    }

    // A copy constructor is a special constructor used to create a new object as a copy of an existing  object.

    public class CopyConstructor
    {
        private string month;
        private int year;
        public static int copyctor_count = 0;
        public static int parameterizedCount = 0;
        public CopyConstructor(CopyConstructor cpy)
        {
            copyctor_count++;
            month = cpy.month;
            year = cpy.year;
        }

        public CopyConstructor(string month, int year)
        {
            parameterizedCount++;
            this.month = month;
            this.year = year;
        }

    }

    public class PrivateConstructor
    {

        // declare static variable field 
        public static int count = 0;
        public static int pvt_count = 0;
        // declare private Constructor 
        private PrivateConstructor()
        {
            pvt_count++;
        }

        // declare static method 
        public static int Calc_Count()
        {
            return ++count;
        }
    }



    public class Constructors
    {
        public Constructors()
        {
            var team = new string[4];
            team[0] = "IDC";
            team[1] = "Elleyment";
            team[2] = "Dynamail";
            team[3] = "Quantom";
            Console.WriteLine(team);

            string[] elleyment = new string[6] { "Srinivasan", "Alager", "Sathish", "Kumaresan", "Balaji", "Badhal" };
            Console.WriteLine(elleyment);

            string[] Quantom = { "Balaji S", "Kiran", "Saravanan", "Vaasavi", "Sunitha" };
            //  Array.Sort(Quantom);
            var valindex = Array.IndexOf(Quantom, "Saravanan");
            Console.WriteLine(Quantom[valindex]);
            // foreach tabtab
            foreach (var item in Quantom)
            {
                Console.WriteLine(item);
            }
        }
    }
    }
