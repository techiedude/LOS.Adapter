using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Extensions;
using LOS.Adapter.Data.Services.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace LOS.Adapter.Data.Services.Tests
{
    [TestClass]
    public class GetPrincipalRepaymentSchedulesHandlerTest
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
        public void GetPrincipalRepaymentSchedulesTest()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "80";
            string ObligorNumber = "0006383502";
            string itemNumber = "";
            string luw = Constants.GET_PRN_RPAY_SCH_LUW_ID;
            string ObligationNumber = "0000000042";

            var reply = requestBus.ExecuteAsync(new GetPrincipalRepaySchedulesRequest(user, pass, bankId, ObligorNumber, "", ObligationNumber, "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();

            var respList = reply.Result.getPrincipalRepaySchedules as List<GetPrincipalRepaySchedules>;
            Assert.IsNotNull(respList);
            Assert.IsTrue(respList.Count > 0);
            respList.RemoveNullOrEmpty<GetPrincipalRepaySchedules>();
            Assert.IsTrue(respList.Count > 0 && respList.Count < 147);
            // Assert.IsNull(reply.Result.x131A_LINE24_MESSAGE);

        }
    }
}
