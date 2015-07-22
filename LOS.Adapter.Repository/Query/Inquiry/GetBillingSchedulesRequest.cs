
using System.Collections.Generic;
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// 
    /// </summary>
    public class GetBillingSchedulesRequest : BaseRequest<GetBillingSchedulesResponse>
    {

        public GetBillingSchedulesRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// GetBillingSchedulesResponse
    /// </summary>
    public class GetBillingSchedulesResponse : BaseResponse
    {
        public IList<BillingSchedulesDetails> billingSchedulesDetails { get; set; }
        public string x133A_LINE24_MESSAGE { get; set; }

    }

    /// <summary>
    /// BillingSchedulesDetails
    /// </summary>
    public struct BillingSchedulesDetails
    {
        /// <summary>
        /// Gets or sets the x133A_ chargeCode.
        /// </summary>
        /// <value>
        /// The x133A_ chargeCode.
        /// </value>
        public string x133A_CHG_CODE_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ accrualLimit.
        /// </summary>
        /// <value>
        /// The x133A_ accrualLimit.
        /// </value>
        public string x133A_ACCR_LMT_CD_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ billLimit.
        /// </summary>
        /// <value>
        /// The x133A_ billLimit.
        /// </value>
        public string x133A_BILL_LMT_CD_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ effectiveFromDate.
        /// </summary>
        /// <value>
        /// The x133A_ effectiveFromDate.
        /// </value>
        public string x133A_EFF_FROM_DATE_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ effectiveToDate.
        /// </summary>
        /// <value>
        /// The x133A_ effectiveToDate.
        /// </value>
        public string x133A_EFF_TO_DATE_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ specialMail.
        /// </summary>
        /// <value>
        /// The x133A_ specialMail.
        /// </value>
        public string x133A_SPEC_MAIL_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ accrualTo.
        /// </summary>
        /// <value>
        /// The x133A_ accrualTo.
        /// </value>
        public string x133A_ACCRU_TO_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ dueDate.
        /// </summary>
        /// <value>
        /// The x133A_ dueDate.
        /// </value>
        public string x133A_DUE_DATE_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ leadDays.
        /// </summary>
        /// <value>
        /// The x133A_ leadDays.
        /// </value>
        public string x133A_LEAD_DAYS_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ customerBill.
        /// </summary>
        /// <value>
        /// The x133A_ customerBill.
        /// </value>
        public string x133A_CUST_BILL_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ replyType.
        /// </summary>
        /// <value>
        /// The x133A_ replyType.
        /// </value>
        public string x133A_REPAY_TYPE_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ collMeth.
        /// </summary>
        /// <value>
        /// The x133A_ collMeth.
        /// </value>
        public string x133A_COLL_METH_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ dda.
        /// </summary>
        /// <value>
        /// The x133A_ dda.
        /// </value>
        public string x133A_DDA_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ billPer.
        /// </summary>
        /// <value>
        /// The x133A_ billPer.
        /// </value>
        public string x133A_BILL_PER_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ transaction.
        /// </summary>
        /// <value>
        /// The x133A_ transaction.
        /// </value>
        public string x133A_TRANSIT_A { get; set; }
        /// <summary>
        /// Gets or sets the x133A_ matCollMeth.
        /// </summary>
        /// <value>
        /// The x133A_ matCollMeth.
        /// </value>
        public string x133A_MAT_COLL_METH_A { get; set; }

    }

}
