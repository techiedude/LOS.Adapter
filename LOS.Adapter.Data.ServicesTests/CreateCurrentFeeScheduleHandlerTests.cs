using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;

namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class CreateCurrentFeeScheduleHandlerTests
    {
        LOSCommandBus commandBus;
        [TestInitialize]
        public void Init()
        {
            commandBus = new LOSCommandBus();
            commandBus.Register(Assembly.GetAssembly(typeof(CreateCurrentFeeScheduleHandler)));
        }



        /// <summary>
        /// NOTE :  Need to call OpenBatch to make sure batch with specific 
        /// </summary>
        [TestMethod()]
        public void CreateCurrentFeeScheduleTest()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "85";
            string ObligorNumber = "0051606471";
            string ObligationNumber = "0000000042";
            string itemNumber = "";
            string luw = Constants.CREATE_ALT_NAME_ADD_LUW_ID;//"L002";
            string batchId = "L02";

            var currentFeeScheduleCommand = new CreateCurrentFeeScheduleCommand(user, pass, bankId, ObligorNumber, batchId, ObligationNumber, "", "", "", itemNumber, luw, "");

            //input fields
            REQUEST_1375_FEE_SCHEDULE currFeeSchedule = new REQUEST_1375_FEE_SCHEDULE
            {
                x1375_ACCRUAL_SCHD_CHARGE_CODE = "540",
                x1375_ACCRUAL_SCHD_EFFECT_FROM = "012715",
                x1375_ACCRUAL_SCHD_EFFECT_TO_DT = "032715",
                x1375_ACCRUAL_SCHD_BASIS = "4",
                x1375_ACCRUAL_SCHD_MEMO_ITEM = "0",
                x1375_ACCRUAL_SCHD_EARN_TYPE = "3",
                x1375_ACCRUAL_SCHD_FM_TIER_AMT = "125.00",
                x1375_ACCRUAL_SCHD_IMA_IND = string.Empty,
                x1375_BILLING_SCHD_BILL_PERIOD = "4",
                x1375_BILLING_SCHD_BILL_DATE = string.Empty,
                x1375_BILLING_SCHD_LEAD_DAYS = "015",
                x1375_BILLING_SCHD_DUE_DATE = "032715",
                x1375_BILLING_SCHD_METHOD_COLL = "11",
                x1375_BILLING_SCHD_CHARGE_ACCT = string.Empty,
                x1375_BILLING_SCHD_SPECIAL_MAIL = string.Empty,
                x1375_BILLING_SCHD_TRANSIT_NR = string.Empty,
                x1375_BILLING_SCHD_MATURITY_MOC = string.Empty
            };
            var currentFeeScheduleFields = new List<REQUEST_1375_FEE_SCHEDULE>(20);
            currentFeeScheduleFields.Add(currFeeSchedule);
            currentFeeScheduleFields.AddRepeatDefaultValues<REQUEST_1375_FEE_SCHEDULE>(19);
            currentFeeScheduleCommand.AccuralFeeBillSchedules = currentFeeScheduleFields;

            var task = commandBus.ExecuteAsync(currentFeeScheduleCommand);
            task.GetAwaiter().GetResult();

            if (currentFeeScheduleCommand.Errors.Length < 1)
                Assert.IsTrue(currentFeeScheduleCommand.Errors.Length < 1, currentFeeScheduleCommand.Errors);

        }
    }
}
