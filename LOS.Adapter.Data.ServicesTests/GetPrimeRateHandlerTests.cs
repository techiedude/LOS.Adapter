using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class GetPrimeRateHandlerTests
    {

        LOSRequestReplyBus requestBus;
        [TestInitialize]
        public void Init()
        {
            requestBus = new LOSRequestReplyBus();
            //requestBus.Register(Assembly.GetAssembly(typeof(GetCollateralForObligorHandler)));
            var assemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
            var assembly = Array.Find(assemblies, a => a.Name.Contains("LOS.Adapter.Data.Services"));
            requestBus.Register(Assembly.Load(assembly));
        }

        [TestMethod()]
        public void GetPrimeRateTest()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "80";
            string ObligorNumber = "0006383502";
            string itemNumber = "00026";
            string luw = Constants.GET_PRM_RATE_LUW_ID;//"L037";
            string rateNumber = "00001";
            string effectiveDate = "20150211";

            var reply = requestBus.ExecuteAsync(new GetPrimeRateRequest(user, pass, bankId, ObligorNumber, "", "", "", "", "", itemNumber, luw, "", rateNumber, effectiveDate));
            reply.GetAwaiter().GetResult();
            Assert.IsNotNull(reply.Result.LUW_RATE);
            Assert.IsTrue(reply.Result.LUW_RATE > 0);
        }
    }
}
