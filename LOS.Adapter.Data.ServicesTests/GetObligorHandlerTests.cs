
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;


namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class GetObligorHandlerTests
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
        public void GetObligorHandlerTest()
        {

            string user = "UGRM175";
            string pass = "*";
            string bankId = "80";
            string ObligorNumber = "0000004740";
            string itemNumber = "00026";
            string luw = Constants.GET_OBLGR_LUW_ID;//"L019";

            var reply = requestBus.ExecuteAsync(new GetObligorRequest(user, pass, bankId, ObligorNumber, "", "", "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();
            Assert.IsNotNull(reply.Result.L101_NAME);
            Assert.IsTrue(reply.Result.L101_NAME.Length > 0);
        }
    }
}
