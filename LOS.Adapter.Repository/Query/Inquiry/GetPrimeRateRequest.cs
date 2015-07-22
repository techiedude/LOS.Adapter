
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPrimeRateRequest : BaseRequest<GetPrimeRateResponse>
    {

        public GetPrimeRateRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode, string rateNumber, string effectiveDate)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {
            LUW_RATE_NUMBER = rateNumber;
            LUW_EFF_DATE = effectiveDate;
        }

        public string LUW_RATE_NUMBER { get; set; }
        public string LUW_EFF_DATE { get; set; } //Format as YYYYMMDD

    }

    /// <summary>
    /// 
    /// </summary>
    public class GetPrimeRateResponse : BaseResponse
    {
        public double LUW_RATE { get; set; }

    }
}
