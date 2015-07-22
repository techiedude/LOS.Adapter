
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
    public class GetObligationSummaryHandlerTests
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



        [TestMethod()]
        public void GetObligationSummaryHandlerTest()
        {

            string user = "UGRM175";
            string pass = "*";
            string bankId = "80";
            string ObligorNumber = "0006383502";
            string itemNumber = "00026";
            string luw = Constants.GET_OBLGN_SUMM_LUW_ID;//"L020";

            var reply = requestBus.ExecuteAsync(new GetObligationSummaryRequest(user, pass, bankId, ObligorNumber, "", "", "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();
            Assert.IsNotNull(reply.Result.ObligationSummaryList);
            var respList = reply.Result.ObligationSummaryList as List<ObligationSummary>;
            Assert.IsNotNull(respList);
            Assert.IsTrue(respList.Count > 0);
            respList.RemoveNullOrEmpty<ObligationSummary>();
            Assert.IsTrue(respList.Count > 0 && respList.Count < 269);
        }
    }
}
