
using System.Collections.Generic;
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPrincipalRepaySchedulesRequest : BaseRequest<GetPrincipalRepaySchedulesResponse>
    {

        public GetPrincipalRepaySchedulesRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// GetPrincipalRepaySchedulesResponse
    /// </summary>
    public class GetPrincipalRepaySchedulesResponse : BaseResponse
    {
        public IList<GetPrincipalRepaySchedules> getPrincipalRepaySchedules { get; set; }
        public string x135A_LINE24_MESSAGE { get; set; }

    }

    /// <summary>
    /// GetPrincipalRepaySchedules
    /// </summary>
    public struct GetPrincipalRepaySchedules
    {
        /// <summary>
        /// Gets or sets the x135A_CHG_CODE_A.
        /// </summary>
        /// <value>
        /// The x135A_CHG_CODE_A.
        /// </value>
        public string x135A_CHG_CODE_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_FM_DT_A.
        /// </summary>
        /// <value>
        /// The x135A_FM_DT_A.
        /// </value>
        public string x135A_FM_DT_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_TO_DT_A.
        /// </summary>
        /// <value>
        /// The x135A_TO_DT_A.
        /// </value>

        public string x135A_TO_DT_A { get; set; }


        /// <summary>
        /// Gets or sets the x135A_DUE_DT_A.
        /// </summary>
        /// <value>
        /// The x135A_DUE_DT_A.
        /// </value>

        public string x135A_DUE_DT_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_BILL_FREQ_A.
        /// </summary>
        /// <value>
        /// The x135A_BILL_FREQ_A.
        /// </value>

        public string x135A_BILL_FREQ_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_LEAD_DAYS_A.
        /// </summary>
        /// <value>
        /// The x135A_LEAD_DAYS_A.
        /// </value>
        public string x135A_LEAD_DAYS_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_BILL_LMT_CD_A.
        /// </summary>
        /// <value>
        /// The x135A_BILL_LMT_CD_A.
        /// </value>
        public string x135A_BILL_LMT_CD_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_COLL_METH_A.
        /// </summary>
        /// <value>
        /// The x135A_COLL_METH_A.
        /// </value>
        public string x135A_COLL_METH_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_MAT_COLL_METH_A.
        /// </summary>
        /// <value>
        /// The x135A_MAT_COLL_METH_A.
        /// </value>
        public string x135A_MAT_COLL_METH_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_SPEC_MAIL_A.
        /// </summary>
        /// <value>
        /// The x135A_SPEC_MAIL_A.
        /// </value>
        public string x135A_SPEC_MAIL_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_REPAY_TYPE_A.
        /// </summary>
        /// <value>
        /// The x135A_REPAY_TYPE_A.
        /// </value>
        public string x135A_REPAY_TYPE_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_DDA_A.
        /// </summary>
        /// <value>
        /// The x135A_DDA_A.
        /// </value>
        public string x135A_DDA_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_TRANSIT_A.
        /// </summary>
        /// <value>
        /// The x135A_TRANSIT_A.
        /// </value>
        public string x135A_TRANSIT_A { get; set; }

        /// <summary>
        /// Gets or sets the x135A_AMT_DUE_A.
        /// </summary>
        /// <value>
        /// The x135A_AMT_DUE_A.
        /// </value>
        public decimal x135A_AMT_DUE_A { get; set; }
    }

}
