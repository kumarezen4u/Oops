using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class Indexers_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            //An indexer allows an instance of a class or struct to be indexed as an array.
            QueueSystem queueSystem = new QueueSystem();
            //This Indexer takes systemId as parameter
            string result1 = queueSystem[1];  // integer Indexer
            Assert.AreEqual(result1, "Content Download Queue");
            string result2 = queueSystem["Content Download Queue"]; // string Indexer
            Assert.AreEqual(result2, "usp_MAL_UpdDownloadQueueStatus");
            //Set the new Value 
            queueSystem[1] = "Image Download Queue";
            result1 = queueSystem[1];  // integer Indexer
            Assert.AreEqual(result1, "Image Download Queue");
        }
    }


    public class MALSystems
    {
        public int MALSystemID { get; set; }

        public string SystemDesc { get; set; }

        public string SPCheckName { get; set; }
    }

    public class QueueSystem
    {
        public List<MALSystems> listMALSystem = new List<MALSystems>();

        public QueueSystem()
        {
            listMALSystem = new List<MALSystems>();
            listMALSystem.Add(new MALSystems() { MALSystemID = 1, SystemDesc = "Content Download Queue", SPCheckName = "usp_MAL_UpdDownloadQueueStatus" });
            listMALSystem.Add(new MALSystems() { MALSystemID = 2, SystemDesc = "Press XML Queue", SPCheckName = "usp_MAL_UpdPressXMLQueueStatus" });
            listMALSystem.Add(new MALSystems() { MALSystemID = 3, SystemDesc = "Ship Notice Queue", SPCheckName = "usp_MAL_UpdShipNoticeQueueStatus" });
            listMALSystem.Add(new MALSystems() { MALSystemID = 4, SystemDesc = "Cancel Notice Queue", SPCheckName = "usp_MAL_UpdCancelNoticeQueueStatus" });
            listMALSystem.Add(new MALSystems() { MALSystemID = 5, SystemDesc = "Auto Ship Queue", SPCheckName = "usp_MAL_UpdAutoShipQueueStatus" });
            listMALSystem.Add(new MALSystems() { MALSystemID = 6, SystemDesc = "LRConvert Queue", SPCheckName = "usp_MAL_UpdLRQueueStatus" });
            listMALSystem.Add(new MALSystems() { MALSystemID = 7, SystemDesc = "JPEGConvert Queue", SPCheckName = "usp_MAL_UpdJPEGQueueStatus" });
            listMALSystem.Add(new MALSystems() { MALSystemID = 8, SystemDesc = "LRFTP Queue", SPCheckName = "usp_MAL_UpdLrFtpQueueStatus" });
        }

        //use this keyword to create an indexers

        //syntax :  [access_modifier] [return_type] this [argument_list]
        public string this[int systmId]
        {
            //Just like properties indexers have get and set accessors
            get
            {
                return listMALSystem.FirstOrDefault(x => x.MALSystemID == systmId).SystemDesc;
            }
            set
            {
                listMALSystem.FirstOrDefault(x => x.MALSystemID == systmId).SystemDesc = value;
            }
        }

        public string this[string systmDesc]
        {
            get
            {
                return listMALSystem.FirstOrDefault(x => x.SystemDesc == systmDesc).SPCheckName;
            }
            set
            {
                listMALSystem.FirstOrDefault(x => x.SystemDesc == systmDesc).SPCheckName = value;
            }
        }


    }
}
