using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Yield_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            YieldExample yieldEx = new YieldExample();
            int[] numbers = { 10, 20, 30, 40, 50 };
            int normalresult = yieldEx.Method1(numbers);   // Normal 
            Console.WriteLine("Normal output :{0}", normalresult);  // 150
            int Yieldresult = yieldEx.Method2(numbers);    // YIELD 
            Console.WriteLine("Yield output :{0}", Yieldresult);    //300
        }

        [TestMethod]
        public void TestMethod2()
        {
            YieldExample yieldEx1 = new YieldExample();
            var resultset = yieldEx1.GetYield();
            foreach (var item in resultset)
            {
                Console.WriteLine(item.City);
            }
        }
    }

    public class YieldExample
    {
        // YIELD keyword help as to do custom state-full  iteration over .NET collections 
        // There are two scenario where YIELD keyword is useful 
        //1. Customized iteration through a collection without creating a temporary collections
        //2. Stateful iteartion 
           // when use IEnumerable ,IQueryable  thoure browsing are stateless , 
           // It does not store  state ,
           // It just fast forward and moves when you use the YIELD keyword you have the option of saving the state as well 

        public int Method1(int[] numbers)
        {
            // Sum with simple statements.
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int Method2(int[] numbers)
        {
            // Use yield return to get multiplied numbers and then sum those.
            int sum = 0;
            foreach (int number in GetNumbers(numbers))
            {
                sum += number;
            }
            return sum;
        }

        static IEnumerable<int> GetNumbers(int[] numbers)
        {
            // Return all numbers multiplied.
            foreach (int number in numbers)
            {
                yield return number * 2;
            }
        }


        public IEnumerable<int> GetMultiplication(int[] numbers)
        {
            // Return all numbers multiplied.
            foreach (int number in numbers)
            {
                yield return number * 2;
            }
        }


        //Defining an Iterator with Yield
        public IEnumerable<int> Fibonacci(int x)
        {
            int prev = -1;
            int next = 1;
            for (int i = 0; i < x; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
                yield return sum;
            }
        }


        public IEnumerable<Zipcode> GetYield()
        {
            ZipcodeRepository obj = new ZipcodeRepository();
            var resultZipcode = obj.GetZipcodeRepository();
            foreach (var item in resultZipcode)
            {
                Console.WriteLine("Item Zipcode :{0}", item.zipcode);
                yield return item;
            }
        }




    }

    public class Zipcode
    {
        public int zipcode { get; set; }
        public string City { get; set; }
    }


    public class ZipcodeRepository
    {
        public ZipcodeRepository()
        {
            var ziplist = new List<Zipcode>()
            {
                new Zipcode () { zipcode =600018 , City="Teynampet" },
                new Zipcode () { zipcode =603306 , City="Maduranthagam" },
                new Zipcode () { zipcode =603202 , City="Guduvancherry" },

            };
        }


        public ICollection<Zipcode> GetZipcodeRepository()
        {
            var ziplist = new List<Zipcode>()
            {
                new Zipcode () { zipcode =600018 , City="Teynampet" },
                new Zipcode () { zipcode =603306 , City="Maduranthagam" },
                new Zipcode () { zipcode =603202 , City="Guduvancherry" },
                new Zipcode () { zipcode =600017 , City="T.Nagar" },
                new Zipcode () { zipcode =600015 , City="Saidapet" },
                new Zipcode () { zipcode =603202 , City="Egmore" },

            };
            return ziplist;
        }
    }
}
