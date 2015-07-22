using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class GetParticipationsHandlerTest
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
        public void GetParticipationsHandlerTests()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "80";
            string ObligorNumber = "0000000482";
            string itemNumber = "";
            string luw = Constants.GET_PRTCPN_LUW_ID;
            string ObligationNumber = "0000000018";

            var reply = requestBus.ExecuteAsync(new GetParticipationsRequest(user, pass, bankId, ObligorNumber, "", ObligationNumber, "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();

            var obligor = reply.Result.x141A_OBGOR;
            var obligation = reply.Result.x141A_OBGAT;
            Assert.IsNotNull(obligor);
            Assert.IsNotNull(obligation);

        }
    }
}
