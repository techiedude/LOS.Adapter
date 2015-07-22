using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Extensions;
using LOS.Adapter.Data.Services.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class GetPrimeSchedulesHandlerTest
    {

        LOSRequestReplyBus requestBus;
        [TestInitialize]
        public void Init()
        {
            requestBus = new LOSRequestReplyBus();
            var assemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
            var assembly = Array.Find(assemblies, a => a.Name.Contains("LOS.Adapter.Data.Services"));
            requestBus.Register(Assembly.Load(assembly));
        }


        [TestMethod]
        public void GetPrimeSchedulesHandlerTests()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "80";
            string ObligorNumber = "0006383502";
            string itemNumber = "";
            string luw = Constants.GET_PRM_SCH_LUW_ID;
            string ObligationNumber = "0000000042";

            var reply = requestBus.ExecuteAsync(new GetPrimeSchedulesRequest(user, pass, bankId, ObligorNumber, "", ObligationNumber, "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();

            var respList = reply.Result.primeSchedulesDetails as List<PrimeSchedulesDetails>;
            Assert.IsNotNull(respList);
            Assert.IsTrue(respList.Count > 0);
            respList.RemoveNullOrEmpty<PrimeSchedulesDetails>();
            Assert.IsTrue(respList.Count > 0 && respList.Count < 162);

        }
    }
}
