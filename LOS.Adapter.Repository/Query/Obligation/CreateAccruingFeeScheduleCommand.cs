
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    public class CreateAccruingFeeScheduleCommand : BaseCommand
    {
        public CreateAccruingFeeScheduleCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, luw, restartRequestCode)
        {

        }


        public string x1150_ACCRUAL_SCHEDULES { get; set; }
        public string x1170_BILLING_SCHEDULES { get; set; }

    }
}
