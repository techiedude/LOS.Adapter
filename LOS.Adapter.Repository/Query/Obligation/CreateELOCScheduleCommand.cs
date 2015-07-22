
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    public class CreateELOCScheduleCommand : BaseCommand
    {
        public CreateELOCScheduleCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, luw, restartRequestCode)
        {

        }

        public x1350_INTEREST_SCHEDULES[] x1350_INTEREST_SCHEDULES { get; set; }
        public x1370_BILLING_SCHEDULES[] x1370_BILLING_SCHEDULES { get; set; }
        public x1360_PRIME_SCHEDULES[] x1360_PRIME_SCHEDULES { get; set; }

    }

    public struct x1350_INTEREST_SCHEDULES
    {

        public short x1350_ACCRUAL_SCHD_CHARGE_CODE;

        public int x1350_ACCRUAL_SCHD_EFFECT_FROM;

        public int x1350_ACCRUAL_SCHD_EFFECT_TO_DT;

        public short x1350_ACCRUAL_SCHD_BASIS;

        public string x1350_ACCRUAL_SCHD_RATE;

        public short x1350_ACCRUAL_SCHD_MEMO_ITEM;
    }
    public struct x1370_BILLING_SCHEDULES
    {

        public string x1370_BILLING_SCHD_CHARGE_CODE;

        public int x1370_BILLING_SCHD_EFFECT_FROM;

        public int x1370_BILLING_SCHD_EFFECT_TO_DT;

        public short x1370_BILLING_SCHD_BILL_PERIOD;

        public short x1370_BILLING_SCHD_LEAD_DAYS;

        public int x1370_BILLING_SCHD_DUE_DATE;

        public string x1370_BILLING_SCHD_ACCRUE_TO;

        public short x1370_BILLING_SCHD_METHOD_COLL;

        public short x1370_BILLING_SCHD_SPECIAL_MAIL;

        public short x1370_BILLING_SCH_D_BILL_LMT;

        public short x1370_BILLING_SCH_D_ACCR_LMT;

        public short x1370_BILLING_SCHD_MATURITY_MOC;

        public string x1370_BILLING_SCHD_AMOUNT_DUE;

        public string x1370_BILLING_SCHD_REPAY_TYPE;

        public short x1370_AMORTIZATIO_N_PRIORITY_C;

        public string x1370_BILLING_SCHD_CHARGE_ACCT;

        public int x1370_BILLING_SCHD_TRANSIT_NR;
    }
    public struct x1360_PRIME_SCHEDULES
    {

        public short x1360_PRIME_SCHD_CHARGE_CODE;

        public int x1360_PRIME_SCHD_EFFECT_FROM;

        public int x1360_PRIME_SCHD_EFFECT_TO_DT;

        public int x1360_PRIME_SCHD_PRIME_NUMBER;

        public short x1360_PRIME_SCHD_CHANGE_DAY;

        public short x1360_PRIME_SCHD_VR_NO_OF_MOS;

        public string x1360_PRIME_SCHD_FLOOR;

        public string x1360_PRIME_SCHD_CEILING;

        public short x1360_PRIME_SCHD_FACTOR_ONE;

        public string x1360_PRIME_SCHD_RELATION_ONE;

        public short x1360_PRIME_SCHD_FACTOR_TWO;

        public string x1360_PRIME_SCHD_RELATION_TWO;

        public int x1360_PRIME_SCHD_ANNIV_DATE;
    }
}
