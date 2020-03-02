using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class CsharpBasic_UnitTest
    {
        [TestMethod]
        public void Split_TestMethod() 
        {
            string strValue = "Ram,suresh";
            string[] strArray = strValue.Split(',');

            foreach (var obj in strArray)
            {
                Console.WriteLine(obj);
            }
            /*   Ram
                 suresh  */
        }

        [TestMethod]
        public void Reverse_TestMethod() 
        {
            //Reverse
            string s = "test";
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];  //tset
            }
        }

        [TestMethod]
        public void Distinct_TestMethod() 
        {
            int[] a = { 1, 2, 3, 2, 5, 3 };
            var d = a.Distinct().ToArray();
            Console.WriteLine("distinct int array");
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }

            /*     distinct int array
            1
            2
            3
            5 */
        }

        [TestMethod]
        public void LinqDistinct_TestMethod() 
        {
            int[] a = { 1, 2, 3, 2, 5, 3 };
            var g = (from f in a select f).Distinct();
            Console.WriteLine("linq");
            foreach (var itemg in g)
            {
                Console.WriteLine(itemg);
            }

            /*   linq
                 1
                 2
                 3
                 5  */
        }

        [TestMethod]
        public void LinqDistinct_TestMethod1() 
        {
            string[] strData = { "one", "two", "one", "five" };
            var sd = strData.Distinct().ToArray();
            Console.WriteLine("distinct string array");
            foreach (var item in sd)
            {
                Console.WriteLine(item);
            }
            /* distinct string array
                 one
                 two
                 five */
        }

        [TestMethod]
        public void EvenNumbers_TestMethod1()
        {
            //How to List out Even Numbers from a List of Integers using LINQ in C#?
            List<int> LstACValues = new List<int> { 1, 7, 2, 5, 10, 16 };
            var result = (from m in LstACValues
                          where m % 2 == 0
                          select m).ToList();
            foreach (var item in result)
                Console.WriteLine(item); //2,10,16

            string csseven = string.Join(",", result);
            Console.Write(csseven);  //2,10,16
        }

        [TestMethod]
        public void PrimeNumbers_TestMethod()
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 20; i++)
            {
                for (int j = 2; j <= 20; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            /*  Prime Numbers :
              2       3       5       7       11      13      17      19  */
        }

        [TestMethod]
        public void EnterNumberReverse_TestMethod() 
        {
            //Get a Number and Display the Number with its Reverse
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);

            /*   
                   Enter a Number :
                   345982
                   Reverse of Entered Number is : 289543
            */
        }
        
        [TestMethod]
        public void DuplicateRecords_TestMethod() 
        {
            //Find Duplicate Records
            string[] arrayToCheck = new string[] { "First", "Second", "Third", "First" };
            var duplicates = arrayToCheck
                            .GroupBy(x => x)
                            .Where(x => x.Count() > 1)
                            .Select(x => x.Key);
            Console.WriteLine(duplicates.Count() > 0); //true : First
        }

        [TestMethod]
        public void DuplicateRecordsInArrayList_TestMethod()  
        {
            var list = new ArrayList { "Raj", "Raj", "Ravi", "Rahul", "Ravi", "Rohan", "Rajesh", "Rahul" };
            var clone = (from string item in list select item).GroupBy(x => x).Select(
                    group => new { Word = group.Key, Count = group.Count() }).Where(x => x.Count >= 2);

            foreach (var duplicate in clone)
            {
                Console.WriteLine(duplicate.Word); //  Raj    Ravi      Rahul
            }              
        }
      

        [TestMethod]
        public void RemoveDuplicateCharacterFromString_TestMethod() 
        {
            //remove duplicate character from string
            string key = "Google";
            string dresult = "";
            string table = "";
            foreach (char value in key)
            {
                // See if character is in the result already.
                if (dresult.IndexOf(value) == -1)
                {
                    // Append to the result.
                    table += value;
                    dresult += value;
                }
            }
            Console.WriteLine(dresult);   // Gogle
            string strInput = "Google";
            string strOutPut = new string(strInput.ToCharArray().Distinct().ToArray());
            Console.WriteLine(strOutPut);  // Gogle
        }


        [TestMethod]
        public void RemoveDuplicateCharacterFromString_TestMethod2()
        {
        }

    }
}
