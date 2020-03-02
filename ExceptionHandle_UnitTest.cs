using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class ExceptionHandle_UnitTest
    {
        [TestMethod]
        public void DivideByZeroException_TestMethod() 
        {
            int number = 4;
            int divisor = 0;
            int arraySize = 0;
            SampleException sampleException = new SampleException();
            string actualExp  =   sampleException.GetException(number, divisor, arraySize,null);
            Assert.AreEqual("Attempted to divide by zero.", actualExp);  // Exception DivideByZeroException
        }
        [TestMethod]
        public void IndexOutOfRangeException_TestMethod() 
        {
            int number = 4;
            int divisor = 2;
            int arraySize = 2;
            SampleException sampleException = new SampleException();
            string actualExp = sampleException.GetException(number, divisor, arraySize,null);
            Assert.AreEqual("Index was outside the bounds of the array.", actualExp);  // Exception IndexOutOfRangeException
        }

        [TestMethod]
        public void NullReferenceException_TestMethod() 
        {
            int number = 4;
            int divisor = 2;
            int arraySize = 3;
            SampleException sampleException = new SampleException();
            string actualExp = sampleException.GetException(number, divisor, arraySize,null);
            Assert.AreEqual("Object reference not set to an instance of an object.", actualExp);  // Exception NullReferenceException
        }

        [TestMethod]
        public void ArgumentException_TestMethod()   
        {
            int number = 4;
            int divisor = 2;
            int arraySize = 3;
            SampleException sampleException = new SampleException();
            string actualExp = sampleException.GetException(number, divisor, arraySize, "erere");
            Assert.AreEqual("Empty path name is not legal.", actualExp);  // Exception ArgumentException
        }

    }


    public class SampleException
    {
        public string GetException(int number ,int divisor, int arraySize, string val =null)   
        {
            string exceptionMsg = string.Empty; 
            try
            {
                //DivideByZeroException
                int output = number / divisor;

                //IndexOutOfRangeException
                int[] numbers = new int[arraySize];
                numbers[0] = 23;
                numbers[1] = 32;
                numbers[2] = 42;

                foreach (int i in numbers)
                    Console.WriteLine(i);

                //NullReferenceException 
                string value = val;
                if (value.Length == 0)
                {
                    Console.WriteLine(value);
                }

                //ArgumentException 
                string fileName = "";
                TextReader reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg= e.Message;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg= e.Message;
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg= e.Message;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg= e.Message;
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg= e.Message;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg= e.Message;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg= e.Message;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg= e.Message;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg= e.Message;
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg= e.Message;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                exceptionMsg = e.Message;
            }
            catch
            {
                throw ;                
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            return exceptionMsg;
        }
    }
}
