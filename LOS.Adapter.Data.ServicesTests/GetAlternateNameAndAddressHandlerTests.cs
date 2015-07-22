
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
    public class GetAlternateNameAndAddressHandlerTests
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
        public void GetAlternateNameAndAddressHandlerTest()
        {

            string user = "UGRM175";
            string pass = "*";
            string bankId = "80";
            string ObligorNumber = "0000004773";
            string itemNumber = "";
            string luw = Constants.GET_ALT_NAME_ADD_LUW_ID;//"L021";

            var reply = requestBus.ExecuteAsync(new GetAlternateNameAndAddressRequest(user, pass, bankId, ObligorNumber, "", "", "", "", "", itemNumber, luw, ""));
            reply.GetAwaiter().GetResult();
            var respList = reply.Result.AlternateNameAndAddressList as List<AlternateAddressFields>;
            Assert.IsNotNull(respList);
            Assert.IsTrue(respList.Count > 0);
            respList.RemoveNullOrEmpty<AlternateAddressFields>();
            Assert.IsTrue(respList.Count > 0 && respList.Count < 23);
            var respAddList = reply.Result.AlternateNameAndAddressAddList as List<AlternateAddressAddFields>;
            Assert.IsNotNull(respAddList);
            respAddList.RemoveNullOrEmpty<AlternateAddressAddFields>();
            Assert.IsTrue(respAddList.Count > 0);
        }
    }
}
