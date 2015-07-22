
using System.Collections.Generic;
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// L032 - Get Copybook
    /// </summary>
    public class GetCollateralTiesRequest : BaseRequest<GetCollateralTiesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollateralTiesRequest"/> class.
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
        public GetCollateralTiesRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class GetCollateralTiesResponse : BaseResponse
    {
        public string x188A_OBLIGOR_SHORT_NAME { get; set; }
        public IList<CollateralSupportObligor> CollateralSupportObligors { get; set; }

    }

    public struct CollateralSupportObligor
    {
        public string x188A_SUPPORT_OBLIGOR { get; set; }
        public string x188A_SUPPORT_APP { get; set; }
        public string x188A_SUPPORT_OBLN { get; set; }
        public string x188A_SUPPORT_TYPE { get; set; }
        public string x188A_SUPPORT_PRIORITY { get; set; }
        public string x188A_SUPPORT_DATE { get; set; }
        public decimal x188A_SUPPORT_CURR_AMT { get; set; }
    }

}
