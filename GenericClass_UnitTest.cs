using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class GenericClass_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new GenericClass<bool>(true, "Generic class pass <bool>");
            var resultdecimal = new GenericClass<decimal>(55, "Generic class pass <decimal>");
            resultdecimal.RetrieveValue<double>("decimal value to double", 67.00);
            resultdecimal.RetrieveValue<string>("decimal value to string", "Sixty Seven");
            resultdecimal.RetrieveValue<int>("decimal value to string", 67);

            var modelres = new GenericClass<Language>(new Language() { Id = 1, Name = "English" }, "Generic class pass <model>");
            modelres.RetrieveValue<Language>("model value for Language", new Language() { Id = 2, Name = "Tamil" });
        }
    }

    //We defined a generic class by adding T and angle brackets.
    //This T is a type parameter and it represents our desired data type
    //We need to define what type that the T type parameter represents.
    //We  specify the actual type when we create an instance of the class
    //Ex var genericClass =new GenericClass<bool>(success,orderTest); 
    //we create of the instance of the class and  define the generic type parameter to be Boolean.
    //Ex var genericClass =new GenericClass<decimal>(success,orderTest);


    //Generic class
    public class GenericClass<T>
    {
        public GenericClass()
        {

        }
        public GenericClass(T result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        //Generic property 
        public T Result { get; set; }
        public string Message { get; set; }



        //Generic Methods
        public int RetrieveValue(string sql, int defaultValue)
        { return 0; }

        // public T RetrieveValue(string sql, int defaultValu)

        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;
            return value;
        }


    }

    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; } 
    }
}
