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
    public class GetAccrualSchedulesHandlerTest
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
        public void GetAccrualSchedulesHandlerTests()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "80";
            string ObligorNumber = "0006383502";
            string itemNumber = "";
            string luw = Constants.GET_ACC_SCH_LUW_ID;
            string ObligationNumber = "0000000042";

            var reply = requestBus.ExecuteAsync(new GetAccrualSchedulesRequest(user, pass, bankId, ObligorNumber, "", ObligationNumber, "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();

            var respList = reply.Result.accrualSchedulesDetails as List<AccrualSchedulesDetails>;
            Assert.IsNotNull(respList);
            Assert.IsTrue(respList.Count > 0);
            respList.RemoveNullOrEmpty<AccrualSchedulesDetails>();
            Assert.IsTrue(respList.Count > 0 && respList.Count < 152);
            
        }
    }
}
