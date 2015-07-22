
using System.Collections.Generic;
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// GetObligationSummaryRequest
    /// </summary>
    public class GetObligationSummaryRequest : BaseRequest<GetObligationSummaryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetObligationSummaryRequest"/> class.
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
        public GetObligationSummaryRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// GetObligationSummaryResponse - Expected max 269 count
    /// </summary>
    public class GetObligationSummaryResponse : BaseResponse
    {
        public IList<ObligationSummary> ObligationSummaryList { get; set; }
    }


    /// <summary>
    ///  ObligationSummary
    /// </summary>
    public struct ObligationSummary
    {
        public string LUWA_OBLN_NUMB { get; set; }
        public string LUWA_PROC_TYPE { get; set; }
        public string LUWA_TAKEDOWN_OBLR { get; set; }
        public string LUWA_TAKEDOWN_OBLN { get; set; }
    }

}
