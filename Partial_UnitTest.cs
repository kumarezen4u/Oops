using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Partial_UnitTest
    {
        [TestMethod]
        public void GradeATest()
        {
            PartialSample particalSample = new PartialSample(90, 90, 90, 95);
            particalSample.CalculateTotal();
            char actual = particalSample.CalculateGrade();
            Assert.AreEqual('A', actual);
        }

        [TestMethod]
        public void PartialClassPartialMethodcanaccessOutsidePartialClass()
        {
            PartialSample particalSample = new PartialSample(90, 90, 90, 95);
            // particalSample.CheckTopper('A');   //Error We cannot call partial method in the Main because it is private and we have to call it in another method of the same class
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GradeBTest()
        {
            PartialSample particalSample = new PartialSample(80, 75, 80, 70);
            particalSample.CalculateTotal();
            char actual = particalSample.CalculateGrade();
            Assert.AreEqual('B', actual);
        }

        [TestMethod]
        public void InstanceInterfaceWithAccessMember()
        {
            IPartialAverage partialAverage = new PartialSample(75, 60, 60, 60);
            IPartialMark partialMark = new PartialSample(75, 60, 60, 60);
            int actualtotal = partialMark.CalculateTotal();
            char actualGrade = partialMark.CalculateGrade();
            char actualGrade1 = partialMark.GetGrade(350);
            double actualRes = partialAverage.CalculateAverage();
            Assert.AreEqual(255, actualtotal);
            Assert.AreEqual('C', actualGrade);
            Assert.AreEqual('B', actualGrade1);
            Assert.AreEqual(63, actualRes);
        }
    }



    public interface IPartialMark
    {
        int CalculateTotal();
        char GetGrade(int total);
        char CalculateGrade();
    }


    public interface IPartialAverage
    {
        double CalculateAverage();
        void CheckIsTopper(char grade);
    }

    public interface IPartialMainSubject
    {
        int MainSubjectTotal();
        decimal MainSubjectAverage();
    }
    //Partial classes allow us to split a class into 2 or more files. All these parts are then combined into a single class, 
    // when the application is complied. 
    //When working on large projects spreading a class over separate files allows multiple programmers to work on it simultaneously 

    public partial class PartialSample : IPartialMark
    {
        public PartialSample(int T, int E, int S, int M)
        {
            Tamil = T;
            English = E;
            Science = S;
            Math = M;
        }
        public int Tamil { get; set; }
        public int English { get; set; }

        public int CalculateTotal()
        {
            return Tamil + English + Science + Math;
        }
        // Partial method   -- A partial method must be declared within a partial class or partial struct
        partial void CheckTopper(char grade);
        //  public partial void CheckTopper1(char grade); 
        // Error A partial method cannot have access modifiers or the virtual, abstract, override,new, sealed, or extern 
        string res = string.Empty;
        // partial void CheckTopper1(char grade, out res); // Error A partial method cannot have out parameters

        public int MainSubjectTotal()
        {
            return Science + Math;
        }

    }

    public partial class PartialSample : IPartialAverage
    {
        public int Science { get; set; }
        public int Math { get; set; }

        public char CalculateGrade()
        {
            int total = Tamil + English + Science + Math;
            return GetGrade(total);
        }

        public char GetGrade(int total)
        {
            total = total / 4;

            char Grade;
            if (total >= 90)
                Grade = 'A';
            else if (total <= 89 && total >= 75)
                Grade = 'B';
            else if (total <= 74 && total >= 60)
                Grade = 'C';
            else
                Grade = 'D';
            return Grade;
        }

        public double CalculateAverage()
        {
            return (Tamil + English + Science + Math) / 4;
        }

        //---------------------------- partial method ---------------------------

        //A partial method must be declared within a partial class or partial struct
        //A partial method cannot have access modifiers or the virtual, abstract, override, new, sealed, or extern modifiers
        //Partial methods must have a void return type

        //Ex  partial bool IsTopper(char grade) {  return true; } //Error  Partial methods must have a void return type

        //A partial method cannot have out parameters

        //Partial method must be private.

        partial void CheckTopper(char grade)
        {
            // Partial Method is Implemented
            bool isTopper = false;
            if (grade == 'A')
            {
                isTopper = true;
                Console.WriteLine($"Topper");
            }
            Console.WriteLine($"Not Topper");
        }

        //We cannot call partial method in the Main because it is private and we have to call it in another method of the same class.
        public void CheckIsTopper(char grade)
        {
            //partial method is called.
            CheckTopper(grade);
        }
    }

    public partial class PartialSample : IPartialMainSubject
    {
        decimal mainSubjectTotal = 0.0m;
        private void Display()
        {

        }
        public decimal MainSubjectAverage()
        {
            mainSubjectTotal = (Science + Math) / 2;

            return mainSubjectTotal;
        }




    }

    //Creating Partial classes
    // 1.All the parts spread across different files,must use the partial keyword
    // 2.All the parts spread across different files,must have the same access modifier.
    //If any of the parts are declare abstract, then the entire type is considered abstract.
    //If any of the parts are declare sealed, then the entire type is considered sealed.
    //If any of the parts inherits a class, then the entire inherits that class.
    //C# does not Support multiple class inheritance.Different parts of the partial class must not specify different base classes.
    //Any member that are declared in a partial definition are available to all of the other parts of the partial class  


    // In Normal class we have inheritance any Interface and immediately implement all the methods in that class
    // the same scenario any one part of partial class must implement inheritance method 
    public class NormalClass : IPartialMark
    {
        public char CalculateGrade()
        {
            throw new NotImplementedException();
        }

        public int CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public char GetGrade(int total)
        {
            throw new NotImplementedException();
        }
    }

}
