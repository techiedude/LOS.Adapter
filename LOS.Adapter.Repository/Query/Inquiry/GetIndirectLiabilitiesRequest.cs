
using LOS.Adapter.Data.Services.Query.Base;
using System.Collections.Generic;
namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// 
    /// </summary>
    public class GetIndirectLiabilitiesRequest : BaseRequest<GetIndirectLiabilitiesResponse>
    {

        public GetIndirectLiabilitiesRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class GetIndirectLiabilitiesResponse : BaseResponse
    {
        public IList<IndirectLiabilities> IndirectLiabilityDetails { get; set; }
    }


    public struct IndirectLiabilities
    {

        public string LUW_152A_LITERAL { get; set; }

        public string LUW_152A_OBGAT_NUMB { get; set; }

        public string LUW_152A_PD_IND_OPT { get; set; }

        public string LUW_152A_OBGOR { get; set; }

        public string LUW_152A_EFF_DT { get; set; }

        public string LUW_152A_EXP_DT { get; set; }

        public string LUW_152A_REF_CD { get; set; }

        public string LUW_152A_PCT { get; set; }

        public string LUW_152A_LIMIT { get; set; }

        public string LUW_152A_OBLIGOR_NAME { get; set; }
    }


}
