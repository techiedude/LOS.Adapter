
using System.Collections.Generic;
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// 
    /// </summary>
    public class GetAccrualSchedulesRequest : BaseRequest<GetAccrualSchedulesResponse>
    {

        public GetAccrualSchedulesRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class GetAccrualSchedulesResponse : BaseResponse
    {
        public IList<AccrualSchedulesDetails> accrualSchedulesDetails { get; set; }
        public string x131A_LINE24_MESSAGE { get; set; }

    }


    /// <summary>
    /// AccrualSchedulesDetails
    /// </summary>
    public struct AccrualSchedulesDetails
    {
        /// <summary>
        /// Gets or sets the x131A_CHARGE_CODE_A.
        /// </summary>
        /// <value>
        /// The x131A_CHARGE_CODE_A.
        /// </value>
        public string x131A_CHARGE_CODE_A { get; set; }

        /// <summary>
        /// Gets or sets the x131A_EFF_FM_DT_A.
        /// </summary>
        /// <value>
        /// The x131A_EFF_FM_DT_A.
        /// </value>
        public string x131A_EFF_FM_DT_A { get; set; }
        /// <summary>
        /// Gets or sets the x131A_EFF_TO_DT_A.
        /// </summary>
        /// <value>
        /// The x131A_EFF_TO_DT_A.
        /// </value>
        public string x131A_EFF_TO_DT_A { get; set; }
        /// <summary>
        /// Gets or sets the x131A_MEMO_ITEM_A.
        /// </summary>
        /// <value>
        /// The x131A_MEMO_ITEM_A.
        /// </value>
        public string x131A_MEMO_ITEM_A { get; set; }
        /// <summary>
        /// Gets or sets the x131A_RATE_A.
        /// </summary>
        /// <value>
        /// The x131A_RATE_A.
        /// </value>
        public string x131A_RATE_A { get; set; }
        /// <summary>
        /// Gets or sets the x131A_BAL_TYPE_A.
        /// </summary>
        /// <value>
        /// The x131A_BAL_TYPE_A.
        /// </value>
        public string x131A_BAL_TYPE_A { get; set; }
        /// <summary>
        /// Gets or sets the x131A_FM_TIER_AMT_PCT_A.
        /// </summary>
        /// <value>
        /// The x131A_FM_TIER_AMT_PCT_A.
        /// </value>
        public string x131A_FM_TIER_AMT_PCT_A { get; set; }
        /// <summary>
        /// Gets or sets the x131A_EARN_TYPE_A.
        /// </summary>
        /// <value>
        /// The x131A_EARN_TYPE_A.
        /// </value>
        public string x131A_EARN_TYPE_A { get; set; }
        /// <summary>
        /// Gets or sets the x131A_TO_TIER_AMT_A.
        /// </summary>
        /// <value>
        /// The x131A_TO_TIER_AMT_A.
        /// </value>
        public string x131A_TO_TIER_AMT_A { get; set; }
        /// <summary>
        /// Gets or sets the x131A_BASIS_A.
        /// </summary>
        /// <value>
        /// The x131A_BASIS_A.
        /// </value>
        public string x131A_BASIS_A { get; set; }
        /// <summary>
        /// Gets or sets the x131A_TAX_CODE_A.
        /// </summary>
        /// <value>
        /// The x131A_TAX_CODE_A.
        /// </value>
        public string x131A_TAX_CODE_A { get; set; }
    }

}
