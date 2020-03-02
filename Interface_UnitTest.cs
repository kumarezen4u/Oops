using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Interface_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //IF have two Interface both have same Display Method
            SampleInterface sampleInterface = new SampleInterface();  // Create instance for class (SampleInterface)
            sampleInterface.Display("Base class Display ");
            Interface1 interface1 = new SampleInterface();    // Create instance for interface (Interface1)
            interface1.Display("Interface1 Display");
            Interface2 interface2 = new SampleInterface();   // Create instance for interface (Interface1)
            interface2.Display("Interface2 Display");
        }

        [TestMethod]
        public void ExplictInterface_TestMethod()
        {
            //Explicit Interface 
          
            Catelog catelog = new Catelog();
            catelog.save();             //o/p  :  Saved from Catelog Save 
            //catelog.save();            // if Comment  public void save() method on Catelog class
            //*** Compiler Error
            ISaveable saveable = new Catelog();
            saveable.save();             //o/p  : save from ISaveable save
            ((IDbSaver)catelog).save();  //o/p  :  save from IDbSaver save 

            IDbSaver dbSaver = new Catelog();
            dbSaver.save();                   //save from IDbSaver save
            ((ISaveable)catelog).save();      //save from ISaveable save
        }

    }
    // An Interface is a way to achive runtime polymorphism 
    // An Interface is a collection of properties and method declaration , does not implementation 
    // interface member should be implemented by class / structure   
    public interface Interface1
    {
        void Display(string msg);

        //string Disp() // Error  --> Interface members cannot have a declaration.  
        //{
        //    return "does not implement members";
        //}
    }

    public interface Interface2
    {
        void Display(string msg);
    }

    public class SampleInterface : Interface1, Interface2
    {
        public SampleInterface()
        {

        }
        public void Display(string msg)
        {
            Console.WriteLine(msg);
        }

    }
   

    public interface ISaveable
    {
        void save();
    }

    public interface IDbSaver
    {
        void save();
    }

    public class Catelog : ISaveable, IDbSaver
    {

        public void save()
        {
            Console.WriteLine("Saved from Catelog Save");
        }

        void IDbSaver.save()  // explicit implementation means that the save() method explicitly associated with the interface
        {                     //To notice that this method does not have as access modifier (Automatically public)      
            Console.WriteLine("save from IDbSaver save");
        }

        void ISaveable.save()
        {
            Console.WriteLine("save from ISaveable save");
        }

    }

    //What are the advantages of using interfaces
    //Interfaces are very powerful.If properly used, interfaces provide all the advantages as listed below. 

    //1. Interfaces allow us to implement polymorphic behaviour.Ofcourse, abstract classes can also be used to implement polymorphic behaviour.

    //2. Interfaces allow us to develop very loosely coupled systems.
    //3. Interfaces enable mocking for better unit testing.

    //4. Interfaces enables us to implement multiple class inheritance in C#.

    //5. Interfaces are great for implementing Inversion of Control or Dependence Injection.

    //6. Interfaces enable parallel application development.

}
