
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// 
    /// </summary>
    public class GetErrorMessageRequest : BaseRequest<GetErrorMessageResponse>
    {

        public GetErrorMessageRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {
        }


    }

    /// <summary>
    /// 
    /// </summary>
    public class GetErrorMessageResponse : BaseResponse
    {
        public double LUW_EXCESS { get; set; }

    }
}
