
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;


namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class GetObligationHeaderHandlerTests
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
        public void GetObligationHeaderHandlerTest()
        {

            string user = "UGRM175";
            string pass = "*";
            string bankId = "85";
            string ObligorNumber = "0051571974";
            string ObligationNumber = "0000000026";
            string itemNumber = "00026";
            string luw = Constants.GET_OBLGN_HEADERS_LUW_ID;//"L044";

            var reply = requestBus.ExecuteAsync(new GetObligationHeadersRequest(user, pass, bankId, ObligorNumber, "", ObligationNumber, "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();
            Assert.IsTrue(reply.Result.X121A_ENTRIES_IN_USE > 0);
            Assert.IsNotNull(reply.Result.X121A_TITLE_CURR_DATE);
        }
    }
}
