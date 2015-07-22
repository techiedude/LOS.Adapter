using LOS.Adapter.CQS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace LOS.Adapter.Data.Services.Handler.Tests
{
    [TestClass()]
    public class AssignObligationNumberHandlerTests
    {
        LOSCommandBus commandBus;
        [TestInitialize]
        public void Init()
        {
            commandBus = new LOSCommandBus();
            commandBus.Register(Assembly.GetAssembly(typeof(AssignObligationNumberHandler)));
        }



        /// <summary>
        /// NOTE :  Need to call OpenBatch to make sure batch with specific 
        /// </summary>
        [TestMethod()]
        public void AssignObligationNumberTest()
        {
            string user = "UGRM175";
            string pass = "*";
            string bankId = "84";
            string ObligorNumber = "0040776204";
            string itemNumber = "";
            string luw = Constants.ASSIGN_OBLGN_NUM_LUW_ID; //"L003";
            string batchId = "L01";

            var obligationCommand = new AssignObligationNumberCommand(user, pass, bankId, ObligorNumber, batchId, "", "", "", "", itemNumber, luw, "");


            var task = commandBus.ExecuteAsync(obligationCommand);
            task.GetAwaiter().GetResult();
            Assert.IsTrue(obligationCommand.Errors.Length < 1);
            Assert.IsTrue(obligationCommand.ObligationNumber.Length > 1);

        }
    }
}
