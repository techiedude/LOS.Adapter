
using LOS.Adapter.Data.Services.Query.Base;
using System.Collections.Generic;
namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPrimeSchedulesRequest : BaseRequest<GetPrimeSchedulesResponse>
    {

        public GetPrimeSchedulesRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class GetPrimeSchedulesResponse : BaseResponse
    {
        /// <summary>
        /// 162 times
        /// </summary>
        /// <value>
        ///
        /// </value>
        public IList<PrimeSchedulesDetails> primeSchedulesDetails { get; set; }
        public string x137A_LINE24_MESSAGE { get; set; }

    }


    public struct PrimeSchedulesDetails
    {

        public string x137A_CHG_CODE_A { get; set; }

        public string x137A_EFF_FROM_DATE_A { get; set; }

        public string x137A_EFF_TO_DATE_A { get; set; }

        public string x137A_PRIME_A { get; set; }

        public string x137A_ANNV_DT_A { get; set; }

        public string x137A_FLOOR_A { get; set; }

        public string x137A_CHANGE_DAY_A { get; set; }

        public string x137A_CEILING_A { get; set; }

        public string x137A_NBR_MNTHS_A { get; set; }

        public string x137A_FACTOR1_A { get; set; }

        public string x137A_RELATION1_A { get; set; }
    }

}
