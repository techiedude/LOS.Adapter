
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    public class CreateFutureFeeScheduleCommand : BaseCommand
    {
        public CreateFutureFeeScheduleCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, luw, restartRequestCode)
        {

        }


        public x1175_FEES[] x1175_FEES { get; set; }
    }
    public struct x1175_FEES
    {

        public short x1175_ACCRUAL_SCHD_CHARGE_CODE;

        public int x1175_ACCRUAL_SCHD_EFFECT_FROM;

        public int x1175_ACCRUAL_SCHD_EFFECT_TO_DT;

        public short x1175_ACCRUAL_SCHD_BASIS;

        public short x1175_ACCRUAL_SCHD_MEMO_ITEM;

        public short x1175_ACCRUAL_SCHD_EARN_TYPE;

        public string x1175_ACCRUAL_SCHD_FM_TIER_AMT;

        public short x1175_ACCRUAL_SCHD_IMA_IND;

        public short x1175_BILLING_SCHD_BILL_PERIOD;

        public int x1175_BILLING_SCHD_BILL_DATE;

        public short x1175_BILLING_SCHD_LEAD_DAYS;

        public int x1175_BILLING_SCHD_DUE_DATE;

        public short x1175_BILLING_SCHD_METHOD_COLL;

        public string x1175_BILLING_SCHD_CHARGE_ACCT;

        public short x1175_BILLING_SCHD_SPECIAL_MAIL;

        public int x1175_BILLING_SCHD_TRANSIT_NR;

        public short x1175_BILLING_SCHD_MATURITY_MOC;
    }
}
