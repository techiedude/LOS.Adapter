using LOS.Adapter.Data.Services.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace LOS.Adapter.Data.Services.Tests
{
    [TestClass()]
    public class ListExtensionTests
    {

        List<int> testList;

        [TestInitialize]
        public void Init()
        {
            testList = new List<int>
            {
                1,2,3,4,5,6,7 
           };
        }

        [TestMethod()]
        public void AddOrTrimExcessTest()
        {
            //Add excess
            int count = 10;
            testList.AddOrTrimExcess<int>(count);
            Assert.IsTrue(testList.Count == 10);

            //Trim excess
            count = 3;
            testList.AddOrTrimExcess<int>(count);
            Assert.IsTrue(testList.Count == 3);
        }
    }
}
