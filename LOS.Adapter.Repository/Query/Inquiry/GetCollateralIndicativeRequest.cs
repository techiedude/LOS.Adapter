
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// 
    /// </summary>
    public class GetCollateralIndicativeRequest : BaseRequest<GetCollateralIndicativeResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollateralIndicativeRequest"/> class.
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
        public GetCollateralIndicativeRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class GetCollateralIndicativeResponse : BaseResponse
    {
        public decimal x186A_COLL_VALUE { get; set; }
        public decimal x186A_UNITS { get; set; }
        public string x186A_EXPIRE_DATE { get; set; }
        public string x186A_SECURITY_NO { get; set; }
        public string x186A_SAFEKP_CODE { get; set; }
        public decimal x186A_ADV_PCT { get; set; }
        public decimal x186A_MAX_LEND_AMT { get; set; }
        public string x186A_DESCRIPT_1 { get; set; }
        public string x186A_DESCRIPT_2 { get; set; }
        public string x186A_FUNCTION_TYPE { get; set; }
        public decimal x186A_UNIT_PRICE { get; set; }
        public short x186A_COLL_TYPE { get; set; }
        public string x186B_USER_NUMERIC { get; set; }
        public string x186B_USER_CODE_1 { get; set; }
        public string x186B_USER_CODE_2 { get; set; }
        public decimal x186F_INDICATIVE_DATA_YEAR { get; set; }
        public string x186F_MAKE { get; set; }
        public string x186F_MODEL { get; set; }
        public string x186F_SERIAL_NUMBER { get; set; }
        public string x186F_PROPERTY_ADDRESS_1 { get; set; }
        public string x186F_PROPERTY_ADDRESS_2 { get; set; }
        public string x186F_CITY { get; set; }
        public string x186F_STATE { get; set; }
        public string x186F_ZIP { get; set; }
        public decimal x186F_INDICATIVE_DATA_AMOUNT { get; set; }
        public string x186F_DISPOSITION_THREE { get; set; }
        public string x186G_CLI_LIEN_POSITION_1 { get; set; }
        public string x186G_CLI_LIEN_HOLDER_1 { get; set; }
        public decimal x186G_CLI_LIEN_AMOUNT_1 { get; set; }
        public string x186I_APPRAISAL_T_YPE { get; set; }
        public string x186I_LAST_APPRAI_SAL_DATE { get; set; }
        public decimal x186I_LAST_APPRAI_SAL_AMT { get; set; }

    }
}
