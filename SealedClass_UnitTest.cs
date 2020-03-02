using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class SealedClass_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            SealedClass sealedCls = new SealedClass();
            int total = sealedCls.Add(4, 5);
            Assert.AreEqual(9, total);
        }

        [TestMethod]
        public void SealedClassTestCase()
        {
            long card = 123134667889;
            string name = "MaduraiMuthu";
            // We can create object of sealed class.
            CreditCardInfo creditCardInfo = new CreditCardInfo(card, name);
            ArrayList creditCardInfo1 = creditCardInfo.GetCreditCardInfo();
            Assert.AreEqual(creditCardInfo1[0], card);
            Assert.AreEqual(creditCardInfo1[1], name);
        }

        [TestMethod]
        public void SealedClassInheritInterface()
        {
            long card = 123134667889;
            string name = "MaduraiMuthu";
            ICreditCardInfo IcreditCardInfo = new CreditCardInfo(card, name);
            ArrayList creditCardInfo1 = IcreditCardInfo.GetCreditCardInfo();
            Assert.AreEqual(creditCardInfo1[0], card);
            Assert.AreEqual(creditCardInfo1[1], name);
        }
    }


    // Sealed classes are used to restrict the inheritance feature of object oriented programming.
    // Once a class is defined as a sealed class, this class cannot be inherited.
    // Sealed classes are the opposite of abstract classes
    //-- Abstract classes force you to derive a subclass in order to use them
    //-- Sealed classes prevent further subclasses from being derived
    // Sealed class

   public sealed class SealedClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }


    //public class DirivedClass : SealedClass    // Error  --> cannot derive from sealed type 'SealedClass'  
    //{
    //}


                                         //Sealed class can be a derived class but can't be a base class.
    public sealed class CreditCardInfo : ICreditCardInfo
    {
        public long CreditCardNumber { get; set; }
        public string CardHolderName { get; set; }

        public CreditCardInfo(long creditCardNo, string cardHolderName)
        {
            CreditCardNumber = creditCardNo;
            CardHolderName = cardHolderName;
        }

        public ArrayList GetCreditCardInfo()
        {
            ArrayList result = new ArrayList();
            result.Add(CreditCardNumber);
            result.Add(CardHolderName);
            return result;
        }
    }

    public interface ICreditCardInfo
    {
        ArrayList GetCreditCardInfo();
    }
    //public class AccountInfo : CreditCardInfo cannot derive from sealed type CreditCardInfo
    public class AccountInfo
    {
        public string BankName { get; set; }
        public long AccountNumber { get; set; }

        public AccountInfo GetAccountInfo(string bankName, long accountNumber)
        {
            AccountInfo accountInfo = new AccountInfo();
            accountInfo.BankName = bankName;
            accountInfo.AccountNumber = accountNumber;
            return accountInfo;
        }


        //public override sealed void Test()
        //{
        //    Console.WriteLine("My class Program");
        //}
    }


    //Difference b/w private class vs sealed class with example.

        //Private Class
        //Private classes cannot be declared directly inside the namespace.
        //We cannot create an instance of a private class.
        //Private Class members are only accessible within a declared class.

        //Sealed Class
        //Sealed classes can be declared directly inside the namespace.
        //We can create the instance of sealed class.
        //Sealed class members are accessible outside the class through object.

    //private class ABC // Error --> Private classes cannot be declared directly inside the namespace.
    //{
    //    void abc()
    //    {
    //    }
    //    public void show()
    //    {
    //        string abc = "";
    //    }
    //}
}
