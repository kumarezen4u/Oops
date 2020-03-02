using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Static_UnitTest
    {
        [TestMethod]
        public void NormalInstanceClass_Unitest()
        {
            //NO matter whetheryou create one circle or thousand circles pi value is always same(constant)
            // also pi object create per object basis 
            // it's not going to change on a pair object that you are creating so that's going to be static it does not change on a pair object basis 

            Circle c1 = new Circle(5);
            float res = c1.CalculateArea();
            Assert.AreEqual(125, res);
            // c1---> create instance for _PI and _Radius
            Circle c2 = new Circle(6);
            float res2 = c2.CalculateArea();
            // c2---> create instance for _PI and _Radius
            Assert.AreEqual(216, res2);
            // Static Pi only one copy of that PI which will be shared by all the object
            Circle c3 = new Circle(5);
            // c3---> create instance for only _Radius (copy of static _PI2  will shared)
            float res3 = c3.CalculateAreawithStaticField();
            Assert.AreEqual(216, res3);
            Circle c4 = new Circle(6);
            // c4---> create instance for only _Radius ( static _PI2  will shared)
            float res4 = c3.CalculateAreawithStaticField();
            Assert.AreEqual(216, res4);
        }
        [TestMethod]
        public void AccessStaticMethod_UnitTest()
        {
            // keep in mind that is ever going to be only one copy of a static member             
            string res4 = Circle.Print();
            Assert.AreEqual("This is Static Print Method", res4);
        }

        [TestMethod]
        public void ReadonlyConstStaticTestReadonly()
        {
            Variables defaultConstractor = new Variables();
            Variables parameterConstractor = new Variables(55);
            double inlineReadonly = parameterConstractor.PI;
            double ReAssign_PI = defaultConstractor.ReAssign_PI;
            int defaultCtor = defaultConstractor.znumber;
            int parameterCtor = parameterConstractor.ynumber;
            int staticvariable  = Variables.GetConstValue(); //directly assess static method using Class Name
            Assert.AreEqual(inlineReadonly, 3.14);
            Assert.AreEqual(ReAssign_PI, 3.14159);
            Assert.AreEqual(parameterCtor, 55);
            Assert.AreEqual(defaultCtor, 50);
            //
            
            StarPrinting.MyStaticProperty = 100;  //public static property can access outside of the class 
            StarPrinting.myStaticVariable = 500;  //public static variable can access outside of the class 
           // StarPrinting.n1 // Error cannot access outsite class
        }

        [TestMethod]
        public void TestStaticVariable()
        {
            Variables staticVariable = new Variables();
            //staticVariable.static_direct //  Reference object not able to access   


            Assert.AreEqual(Variables.public_static_direct, "PublicStaticString");
            Assert.AreEqual(Variables.Reassign_Ctor_static_direct1, "inConstractor");
            staticVariable.SetStaticVariable();
            Assert.AreEqual(Variables.Reassign_instanceMethod_static_direct1, "InInstanceMember");
            int res = Variables.GetstaticValue();
            Assert.AreEqual(res, 100);
        }

        [TestMethod]
        public void TestMethod1()
        {
            MyStaticVariable stVar = new MyStaticVariable(); 
            int i = stVar.test();
            int j = stVar.test2(25);
            Assert.AreEqual(i, 10);
            Assert.AreEqual(j, 25);
        }
    }


    public class MyStaticVariable
    {
        public static int i = 5;

        public static int j;
        public int test()
        {
            i = i + 5;
            return i;
        }
        public int test2(int x)
        {
            j = x;
            return j;
        }
    }

    public class Circle
    {
        float _PI = 3.14F;  // this field is instance field or non-static field
        static float _PI2 = 3.14F; //  static field then in memory there will be only one copy of that PI
                                   //   which will be shared by all the object that you create
        int _Radius;

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            return this._PI * this._Radius * this._Radius;
        }

        public float CalculateAreawithStaticField()
        {
            // return this._PI2 * this._Radius * this._Radius; 
            // Error this._PI2 -->	Member 'Circle._PI2' cannot be accessed with an instance reference
            return Circle._PI2 * this._Radius * this._Radius;
        }
        //Difference b/w instance member and static member 
        //static member are invoked using the name of the class
        //instance member are invoke using instance of the class
        // Because a static member doesn't change in the pair object basis
        public static string Print()
        {
            return "This is Static Print Method";
        }

    }
    //It is not possible to create instance of a static class  using the new keyword
    //static class can not inherit them 
    //Static class can have static member only 
    //Static class can have static method only 
    //Static class can not contain constructor , but possible to declare (one) static constructor to assign initial values 
    public static class StarPrinting
    {
        static int n1;
        static int n2;
        static int n3;
        static int n4;
        static int n5;
        public static int myStaticVariable = 0; 
        public static int MyStaticProperty { get; set; }
        //int total;//Error  -> Cannot declare instance members in a static class 

        ///   public StarPrinting() { } // Error ->  Static class cannot have instance constructor 

        static StarPrinting() {
            n4 = 100;    // A static constructor is used to initialize any static data
        }      

            public static int FindBiggest(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3)
                return n1;
            else if (n2 > n3)
                return n2;
            else
                return n3;
        }


        public static string method1()
        {
            return "Call Method1";
        }

         // public void Display()  { }   //Error -> Cannot declare instance members in a static class

    }


    //Readonly Const Static
    public class Variables
    {
        const string const_string = "Constant";  //   Correct
        //const string const_string1 = string.Empty;  //Error  The expression being assigned to 'Variables.const_string1' must be constant
        const string const_stringnull = null;      // Correct
        const string const_assignstring = null;   // Correct
        const int const_X = 10, const_Y = 50;    //Correct //Local Variable 
        const int const_Z = const_X + const_Y;  //Correct 
                                                // const int const_assignfromMethod = GetConstValue();   //Error

        public readonly double PI = 3.14;             //inline intialization
        public readonly double ReAssign_PI = 3.14;
        public readonly int ynumber;
        public readonly int znumber;
        public readonly int xnumber;


        public static string public_static_direct = "PublicStaticString";
        public static string Reassign_Ctor_static_direct1;
        public static string Reassign_instanceMethod_static_direct1;

        public Variables()
        {
            ReAssign_PI = 3.14159; // Re-assign readonly field on Constractor 
            znumber = 50;    //Constructor initialization           
            //const_assignstring = "Hello";   // Error
            Reassign_Ctor_static_direct1 = "inConstractor";
        }
        public Variables(int x)
        {
            ynumber = x;
        }

        public void GetReassignMethod()
        {
            //xnumber = 100;  // Error A readonly field cannot be assigned to (except in a constructor or a variable initializer)
        }

        public static int GetConstValue()
        {
            return 100;
        }

        public void SetStaticVariable()
        {
            Reassign_instanceMethod_static_direct1 = "InInstanceMember";
        }

        public static int GetstaticValue()
        {
            return 100;
        }


    }
}
