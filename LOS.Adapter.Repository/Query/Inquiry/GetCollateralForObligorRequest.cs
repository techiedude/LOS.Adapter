
using System.Collections.Generic;
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// GetCollateralForObligorRequest
    /// </summary>
    public class GetCollateralForObligorRequest : BaseRequest<GetCollateralForObligorResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollateralForObligorRequest"/> class.
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
        public GetCollateralForObligorRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// GetCollateralForObligorResponse
    /// </summary>
    public class GetCollateralForObligorResponse : BaseResponse
    {
        //public CollateralDetail[] CollateralList { get; set; }
        public IList<CollateralDetail> CollateralList { get; set; }

    }

    /// <summary>
    /// CollateralDetail
    /// </summary>
    public struct CollateralDetail
    {
        /// <summary>
        /// Gets or sets the 189A_ description.
        /// </summary>
        /// <value>
        /// The 189A_ description.
        /// </value>
        public string x189A_DESC { get; set; }
        /// <summary>
        /// Gets or sets the 189A_model_desc.
        /// </summary>
        /// <value>
        /// The 189A_model_desc.
        /// </value>
        public string x189A_MODEL_DESC { get; set; }
        /// <summary>
        /// Gets or sets the 189a_obligation_item.
        /// </summary>
        /// <value>
        /// The 189a_obligation_item.
        /// </value>
        public string x189A_OBLN_ITEM { get; set; }
        /// <summary>
        /// Gets or sets the type of the 189a_type.
        /// </summary>
        /// <value>
        /// The type of the 189a_type.
        /// </value>
        public string x189A_TYPE { get; set; }
    }


}
