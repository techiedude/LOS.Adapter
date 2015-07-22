using LOS.Adapter.CQS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class CreateCollateralHandlerTests
    {
        LOSCommandBus commandBus;
        [TestInitialize]
        public void Init()
        {
            commandBus = new LOSCommandBus();
            commandBus.Register(Assembly.GetAssembly(typeof(CreateCollateralHandler)));
        }



        /// <summary>
        /// NOTE :  Need to call OpenBatch to make sure batch with specific 
        /// </summary>
        [TestMethod()]
        public void CreateCollateralTest()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "84";
            string ObligorNumber = "0040776246";
            string itemNumber = "";
            string luw = Constants.CREATE_COLL_LUW_ID;//"L010";
            string batchId = "L01";

            var collateralCommand = new CreateCollateralCommand(user, pass, bankId, ObligorNumber, batchId, "", "", "", "", itemNumber, luw, "");

            //input fields
            collateralCommand.x1501_FUNCTION_TYPE = "001";
            collateralCommand.x1501_CUSIP_NBR = "";
            collateralCommand.x1501_COLL_TYPE = "610";
            collateralCommand.x1501_ADVANCE_PCT = "0.00";
            collateralCommand.x1501_REG_U_ADV_PCT = "";
            collateralCommand.x1501_NBR_UNITS = "1";
            collateralCommand.x1501_UNIT_PRICE = "9578.26";
            collateralCommand.x1501_NBR_PIECES = "1";
            collateralCommand.x1501_DESCRIPTION1 = "2015 BIG TEX 16VDX1621F3079153";
            collateralCommand.x1501_DESCRIPTION2 = "VIN";
            collateralCommand.x1501_LOCATION_RCVD = "82950";
            collateralCommand.x1501_LOCATION_HELD = "82950";
            collateralCommand.x1501_EFF_DATE = "040115";
            collateralCommand.x1501_DATE_RCVD = "040115";
            collateralCommand.x1501_EXPIRE_DATE = "";
            collateralCommand.x1501_SAFEKEEPING_CD = "0";
            collateralCommand.x1501_MAX_LEND_VALUE = "0.00";
            collateralCommand.x1501_DDA_1 = "";
            collateralCommand.x1508_COUPON_FREQ = "";
            collateralCommand.x1508_NEXT_COUPON_DATE = "";
            collateralCommand.x1508_FIRST_COUPON_AMT = "";
            collateralCommand.x1508_REGULAR_COUPON_AMT = "";
            collateralCommand.x1508_GEOTRAC_NBR = "000000000000000";
            collateralCommand.x1508_GEOTRAC_IND = "N";

            var task = commandBus.ExecuteAsync(collateralCommand);
            task.GetAwaiter().GetResult();
            Assert.IsTrue(collateralCommand.Errors.Length < 1, collateralCommand.Errors);
            Assert.IsTrue(collateralCommand.ItemNumber.Length > 1);

        }
    }
}
