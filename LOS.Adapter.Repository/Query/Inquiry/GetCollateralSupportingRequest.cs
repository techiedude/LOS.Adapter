
using LOS.Adapter.Data.Services.Query.Base;
using System.Collections.Generic;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// L030 - Get Collateral Supporting Obligor Request
    /// </summary>
    public class GetCollateralSupportingRequest : BaseRequest<GetCollateralSupportingResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollateralSupportingRequest"/> class.
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
        public GetCollateralSupportingRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// L030 - Get Collateral Supporting Obligor Response
    /// </summary>
    public class GetCollateralSupportingResponse : BaseResponse
    {
        public string LUW_184A_OBLIGOR_SHORT_NAME { get; set; }
        public IList<CollateralSupportingObigation> CollateralSupportingObligations { get; set; }

    }

    public struct CollateralSupportingObigation
    {
        public string LUW_184A_COLL_CURR_AMT { get; set; }
        public string LUW_184A_DESCRIPTION { get; set; }
        public string LUW_184A_DT_RECV_EFF { get; set; }
        public string LUW_184A_DT_RELS_EFF { get; set; }
        public string LUW_184A_ITEM { get; set; }
        public string LUW_184A_MAKE_PIECES { get; set; }
        public string LUW_184A_MODEL_UNITS { get; set; }
        public string LUW_184A_OBGAT { get; set; }
        public string LUW_184A_OBLR_LIT_REF_TYPE { get; set; }
        public string LUW_184A_PRIORITY_NO { get; set; }
        public string LUW_184A_PROP_OWNER_NUM { get; set; }
        public string LUW_184A_PROP_OWNER_SNAM { get; set; }
        public string LUW_184A_SERIAL_SECURITY { get; set; }
        public string LUW_184A_TYPE { get; set; }
    }

}
