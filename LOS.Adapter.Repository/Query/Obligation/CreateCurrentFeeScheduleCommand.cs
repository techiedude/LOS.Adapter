
using LOS.Adapter.Data.Services.Query.Base;
using System.Collections.Generic;

namespace LOS.Adapter.Data.Services
{
    /// <summary>
    /// CreateCurrentFeeScheduleCommand
    /// </summary>
    public class CreateCurrentFeeScheduleCommand : BaseCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCurrentFeeScheduleCommand"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="password">The password.</param>
        /// <param name="bankId">The bank identifier.</param>
        /// <param name="obligorNumber">The obligor number.</param>
        /// <param name="batchid">The batchid.</param>
        /// <param name="obligationNumber">The obligation number.</param>
        /// <param name="segment">The segment.</param>
        /// <param name="restriction">The restriction.</param>
        /// <param name="dataLength">Length of the data.</param>
        /// <param name="itemNumber">The item number.</param>
        /// <param name="luw">The luw.</param>
        /// <param name="restartRequestCode">The restart request code.</param>
        public CreateCurrentFeeScheduleCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

        /// <summary>
        /// Gets or sets the accural fee bill schedules.
        /// NOTE: Has to have only 20 times
        /// </summary>
        /// <value>
        /// The accural fee bill schedules.
        /// </value>
        public List<REQUEST_1375_FEE_SCHEDULE> AccuralFeeBillSchedules { get; set; }

    }



    /// <summary>
    /// AccuralFeeBillSchedules
    /// </summary>
    public struct REQUEST_1375_FEE_SCHEDULE
    {

        public string x1375_ACCRUAL_SCHD_CHARGE_CODE { get; set; }

        public string x1375_ACCRUAL_SCHD_EFFECT_FROM { get; set; }

        public string x1375_ACCRUAL_SCHD_EFFECT_TO_DT { get; set; }

        public string x1375_ACCRUAL_SCHD_BASIS { get; set; }

        public string x1375_ACCRUAL_SCHD_MEMO_ITEM { get; set; }

        public string x1375_ACCRUAL_SCHD_EARN_TYPE { get; set; }

        public string x1375_ACCRUAL_SCHD_FM_TIER_AMT { get; set; }

        public string x1375_ACCRUAL_SCHD_IMA_IND { get; set; }

        public string x1375_BILLING_SCHD_BILL_PERIOD { get; set; }

        public string x1375_BILLING_SCHD_BILL_DATE { get; set; }

        public string x1375_BILLING_SCHD_LEAD_DAYS { get; set; }

        public string x1375_BILLING_SCHD_DUE_DATE { get; set; }

        public string x1375_BILLING_SCHD_METHOD_COLL { get; set; }

        public string x1375_BILLING_SCHD_CHARGE_ACCT { get; set; }

        public string x1375_BILLING_SCHD_SPECIAL_MAIL { get; set; }

        public string x1375_BILLING_SCHD_TRANSIT_NR { get; set; }

        public string x1375_BILLING_SCHD_MATURITY_MOC { get; set; }
    }
}
