using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;

namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class CreateCollateralTiesHandlerTests
    {
        LOSCommandBus commandBus;
        [TestInitialize]
        public void Init()
        {
            commandBus = new LOSCommandBus();
            commandBus.Register(Assembly.GetAssembly(typeof(CreateCollateralTieHandler)));
        }



        /// <summary>
        /// NOTE :  Need to call OpenBatch to make sure batch with specific 
        /// </summary>
        [TestMethod()]
        public void CreateCollateralTiesTest()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "85";
            string ObligorNumber = "0051606471";
            string Obligation = "0000000042";
            string itemNumber = "";
            string luw = Constants.CREATE_COLL_TIE_LUW_ID;//"L012";
            string batchId = "L01";
            string restartcode = "1392";

            var collateralTiesCommand = new CreateCollateralTieCommand(user, pass, bankId, ObligorNumber, batchId, Obligation, "", "", "", itemNumber, luw, restartcode);

            //input fields
            REQUEST_1392_FIELDS current_specific = new REQUEST_1392_FIELDS
           {
               x1392_EFF_FROM_DATE = "012715",
               x1392_SUPPORT_ITEM = "00018",
               x1392_SUPPORT_OBLIGOR = "0051606471",
               x1392_SUPPORT_TYPE = "500"

           };
            var current_specific_fields = new List<REQUEST_1392_FIELDS>(10);
            current_specific_fields.Add(current_specific);
            current_specific_fields.AddRepeatDefaultValues<REQUEST_1392_FIELDS>(9);
            collateralTiesCommand.CURRENT_SPECIFIC_ITEMS = current_specific_fields;

            var future_specific_fields = new List<REQUEST_1192_FIELDS>(10);
            future_specific_fields.AddRepeatDefaultValues<REQUEST_1192_FIELDS>(10);
            collateralTiesCommand.FUTURE_SPECIFIC_ITEMS = future_specific_fields;

            var task = commandBus.ExecuteAsync(collateralTiesCommand);
            task.GetAwaiter().GetResult();
            Assert.IsTrue(collateralTiesCommand.Errors.Length < 1, collateralTiesCommand.Errors);


        }
    }
}
