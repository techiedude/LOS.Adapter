using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class OpenBatchHandlerTests
    {
        LOSCommandBus commandBus;
        [TestInitialize]
        public void Init()
        {
            commandBus = new LOSCommandBus();
            commandBus.Register(Assembly.GetAssembly(typeof(OpenBatchHandler)));
        }



        [TestMethod()]
        public void OpenBatchTest()
        {
            string user = "UGRM175";
            string password = "*";

            var command = new OpenBatchCommand(user, password);
            command.Luw = Constants.OPN_BATCH_LUW_ID;//"L034";
            command.RestartRequestCode = "0970";
            command.BatchID = "L02";
            command.HeaderRestrictions = Constants.LUW_HEADER_REST_CALL_APPL;
            command.DataLength = "";
            command.BankId = "85";
            command.ObligorNumber = "";
            command.ObligationNumber = "";
            command.ItemNumber = "";
            command.Segment = "";
            command.x0970_ORIGIN_UNIT = "10001";
            command.x0970_ENTRY_DATE = "";
            command.x0970_DEBIT_TOTAL = "0.00";
            command.x0970_CREDIT_TOTAL = "0.00";
            command.x0970_NON_GL_TOTAL = "0.00";
            command.x0970_COLLATERAL_UNITS = "0.0000";
            command.x0970_NO_OF_TRANS = "";

            var task = commandBus.ExecuteAsync(command);
            task.GetAwaiter().GetResult();
            Assert.IsTrue(command.Errors.Length < 1, command.Errors);

        }
    }
}
