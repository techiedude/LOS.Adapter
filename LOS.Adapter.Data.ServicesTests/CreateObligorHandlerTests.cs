using LOS.Adapter.CQS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class CreateObligorHandlerTests
    {
        LOSCommandBus commandBus;
        [TestInitialize]
        public void Init()
        {
            commandBus = new LOSCommandBus();
            commandBus.Register(Assembly.GetAssembly(typeof(CreateObligorHandler)));
        }



        /// <summary>
        /// NOTE :  Need to call OpenBatch to make sure batch with specific 
        /// </summary>
        [TestMethod()]
        public void CreateObligorTest()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "84";
            string ObligorNumber = "";
            string itemNumber = "";
            string luw = Constants.CREATE_OBLGR_LUW_ID;//"L001";
            string batchId = "L01";

            var obligorCommand = new CreateObligorCommand(user, pass, bankId, ObligorNumber, batchId, "", "", "", "", itemNumber, luw, "");

            //input fields

            obligorCommand.X1001_CUSTOMER_NAME = "*TESTING ANOTHER LLC";
            obligorCommand.X1001_CUSTOMER_GREETING = "";
            obligorCommand.X1001_CUSTOMER_NAME_CONT = "";
            obligorCommand.X1001_TAXID = "261998044";
            obligorCommand.X1001_ADDRESS_LINE_ONE = "3500 W ANDERE JOHNSON HWY";
            obligorCommand.X1001_SOCIAL_SECURITY = "";
            obligorCommand.X1001_ADDRESS_LINE_TWO = "";
            obligorCommand.X1001_CONTACT_DATE = "020215";
            obligorCommand.X1001_ADDRESS_LINE_THREE = "";
            obligorCommand.X1001_RESIDENT_AREA_CODE = "423";
            obligorCommand.X1001_RESIDENT_PHONE_NUMBER = "4704049";
            obligorCommand.X1001_ADDRESS_LINE_FOUR = "";
            obligorCommand.X1001_RESIDENT_EXTENSION = "";
            obligorCommand.X1001_ADDRESS_LINE_FIVE = "";
            obligorCommand.X1001_BUSINESS_AREA_CODE = "";
            obligorCommand.X1001_BUSINESS_PHONE_NUMBER = "";
            obligorCommand.X1001_ADDRESS_LINE_SIX = "";
            obligorCommand.X1001_BUSINESS_EXTENSION = "";
            obligorCommand.X1001_CITY = "GREENVILLE";
            obligorCommand.X1001_STATE_PROVINCE = "TN";
            obligorCommand.X1001_BIRTH_INC_DATE = "";
            obligorCommand.X1001_ZIP_CODE = "377430000";
            obligorCommand.X1001_TIME_ZONE = "";
            obligorCommand.X1001_FOUND_ON_CRF = "1";
            obligorCommand.X1040_ASSIGNMENT_UNIT = "1000508";
            obligorCommand.X1040_CONTACT_OFFICER = "011667";
            obligorCommand.X1040_SERVICE_UNIT = "82950";
            obligorCommand.X1040_SIC_CODE = "";
            obligorCommand.X1035_NAICS_CODE = "238990";
            obligorCommand.X1043_TYPE_TIN_IND = "T";
            obligorCommand.X1043_TYPE_ID = "";
            obligorCommand.X1043_ID_NUMBER_1 = "";
            obligorCommand.X1043_STATE_OF_ISSUE = "";
            obligorCommand.X1043_COUNTRY_OF_ISSUE = "";
            obligorCommand.X1043_ISSUANCE_DATE = "";
            obligorCommand.X1043_EXPIRATION_DATE = "";
            obligorCommand.X1043_ID_NUMBER_2 = "";
            obligorCommand.X1043_ID_NUMBER_3 = "";

            var task = commandBus.ExecuteAsync(obligorCommand);
            task.GetAwaiter().GetResult();
            Assert.IsTrue(obligorCommand.Errors.Length < 1, obligorCommand.Errors);
            Assert.IsTrue(obligorCommand.ObligorNumber.Length > 1);

        }
    }
}
