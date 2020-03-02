using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Csharp
{
    [TestClass]
    public class JsonIntoModel_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            JsonIntoModel Jsonmodel = new JsonIntoModel();
            Jsonmodel.GetJsonIntoMode();
        }
    }

    public class JsonIntoModel
    {

        public void GetJsonIntoMode()
        {
            string json = "{\"People\":[{\"FirstName\":\"Hans\",\"LastName\":\"Olo\"},{\"FirstName\":\"Jimmy\",\"LastName\":\"Crackedcorn\"}]}";

            var result = JsonConvert.DeserializeObject<RootObject>(json);
            List<Person> lstpersion = result.People.ToList();
            var firstNames = result.People.Select(p => p.FirstName).ToList();
            var lastNames = result.People.Select(p => p.LastName).ToList();
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class RootObject
        {
            public List<Person> People { get; set; }
        }

    }
}
