
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;


namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class GetObligationHandlerTests
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
        public void GetObligationHandlerTest()
        {

            string user = "UGRM175";
            string pass = "*";
            string bankId = "85";
            string ObligorNumber = "0051571974";
            string ObligationNumber = "0000000026";
            string itemNumber = "00026";
            string luw = Constants.GET_OBLGN_LUW_ID;//"L022";

            var reply = requestBus.ExecuteAsync(new GetObligationRequest(user, pass, bankId, ObligorNumber, "", ObligationNumber, "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();
            Assert.IsNotNull(reply.Result.x103A_TKDOWN_OBLN);
            Assert.IsNotNull(reply.Result.x103A_TKDOWN_OBLR);
        }
    }
}
