using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Extensions;
using LOS.Adapter.Data.Services.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class CreateAlternateNameAndAddressHandlerTests
    {
        LOSCommandBus commandBus;
        [TestInitialize]
        public void Init()
        {
            commandBus = new LOSCommandBus();
            commandBus.Register(Assembly.GetAssembly(typeof(CreateAlternateNameAndAddressHandler)));
        }



        /// <summary>
        /// NOTE :  Need to call OpenBatch to make sure batch with specific 
        /// </summary>
        [TestMethod()]
        public void CreateAlternateNameAndAddressTest()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "81";
            string ObligorNumber = "0011036821";
            string itemNumber = "";
            string luw = Constants.CREATE_ALT_NAME_ADD_LUW_ID;//"L002";
            string batchId = "L03";

            var altNameAddressCommand = new CreateAlternateNameAndAddressCommand(user, pass, bankId, ObligorNumber, batchId, "", "", "", "", itemNumber, luw, "");

            //input fields
            REQUEST_1091_FIELD_DESC altNameAddress = new REQUEST_1091_FIELD_DESC
            {
                x1091_ADDRESS1 = "3500 W ANDREW JOHNSON HWY",
                x1091_ADDRESS2 = "",
                x1091_ADDRESS3 = "",
                x1091_ADDRESS4 = "",
                x1091_ADDRESS5 = "",
                x1091_ADDRESS6 = "",
                x1091_CITY = "GREENVILLE",
                x1091_NAAD_RECORD_CODE = "",
                x1091_NAME = "*ROBERT CARL SHELTON LLC",
                x1091_NAME_CONTINUED = "",
                x1091_NAME_TITLE = "",
                x1091_SSN = "",
                x1091_STATE = "TN",
                x1091_TELEPHONE1 = "",
                x1091_TELEPHONE2 = "",
                x1091_TIN = "",
                x1091_ZIP_CODE = "377430000"
            };
            var altNameAddressFields = new List<REQUEST_1091_FIELD_DESC>(23);
            altNameAddressFields.Add(altNameAddress);
            altNameAddressFields.AddRepeatDefaultValues<REQUEST_1091_FIELD_DESC>(22);
            altNameAddressCommand.AlternateNameAndAddressFields = altNameAddressFields;
            var altNameAddressFieldsExtra = new List<REQUEST_1091_FIELD_DESC_EXTRA>(23);
            altNameAddressFieldsExtra.AddRepeatDefaultValues<REQUEST_1091_FIELD_DESC_EXTRA>(23);
            altNameAddressCommand.AlternateNameAndAddressExtraFields = altNameAddressFieldsExtra;

            var task = commandBus.ExecuteAsync(altNameAddressCommand);
            task.GetAwaiter().GetResult();
            Thread.Sleep(50000);
            if (altNameAddressCommand.Errors.Length < 1)
                Assert.IsTrue(altNameAddressCommand.Errors.Length < 1, altNameAddressCommand.Errors);

        }
    }
}
