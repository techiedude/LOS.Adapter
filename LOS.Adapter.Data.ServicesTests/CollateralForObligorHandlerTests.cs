
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
    public class CollateralForObligorHandlerTests
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
        public void GetCollateralForObligorHandlerTest()
        {

            string user = "UGRM175";
            string pass = "*";
            string bankId = "82";
            string ObligorNumber = "0006383502";//"0021388716";
            string itemNumber = "00026";
            string luw = Constants.GET_COLL_OBLGR_LUW_ID;//"L033";
            var reply = requestBus.ExecuteAsync(new GetCollateralForObligorRequest(user, pass, bankId, ObligorNumber, "", "", "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();
            var respList = reply.Result.CollateralList as List<CollateralDetail>;
            if (reply.Result.Errors.Length < 1)
            {
                Assert.IsNotNull(respList);
                Assert.IsTrue(respList.Count > 0);
                respList.RemoveNullOrEmpty<CollateralDetail>();
                Assert.IsTrue(respList.Count > 0 && respList.Count < 800);
            }

        }
    }
}
