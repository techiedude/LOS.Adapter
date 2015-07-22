
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;


namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class GetCollateralIndicativeHandlerTests
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
        public void GetCollateralIndicativeHandlerTest()
        {

            string user = "UGRM175";
            string pass = "*";
            string bankId = "80";
            string ObligorNumber = "0006383512";
            string itemNumber = "00026";
            string luw = Constants.GET_COLL_IND_LUW_ID;//"L031";

            var reply = requestBus.ExecuteAsync(new GetCollateralIndicativeRequest(user, pass, bankId, ObligorNumber, "", "", "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();
            if (reply.Result.Errors.Length < 1)
            {
                Assert.IsNotNull(reply.Result.x186A_COLL_VALUE);
                Assert.IsTrue(reply.Result.x186A_COLL_VALUE > 0);
            }
        }
    }
}
