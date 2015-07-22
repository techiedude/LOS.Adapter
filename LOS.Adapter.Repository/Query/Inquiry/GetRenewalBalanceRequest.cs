
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// L032 
    /// </summary>
    public class GetRenewalBalanceRequest : BaseRequest<GetRenewalBalanceResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRenewalBalanceRequest"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="pass">The pass.</param>
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
        public GetRenewalBalanceRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {


        }

        public string CPL_EFF_DATE { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class GetRenewalBalanceResponse : BaseResponse
    {
        public string CPL_REQUEST_DATA { get; set; }
        public decimal CPL_CURRENT_BALANCE { get; set; }
        public string CPL_OTHER_VALUES { get; set; }
        public string CPL_CHARGE_CODE_TABLE { get; set; }


    }
}
