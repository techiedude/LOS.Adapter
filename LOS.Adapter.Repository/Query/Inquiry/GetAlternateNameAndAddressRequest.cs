
using LOS.Adapter.Data.Services.Query.Base;
using System.Collections.Generic;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// 
    /// </summary>
    public class GetAlternateNameAndAddressRequest : BaseRequest<GetAlternateNameAndAddressResponse>
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
        public GetAlternateNameAndAddressRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class GetAlternateNameAndAddressResponse : BaseResponse
    {
        /// <summary>
        /// Gets or sets the alternate name and address list.
        /// Max count 23
        /// </summary>
        /// <value>
        /// The alternate name and address list.
        /// </value>
        public IList<AlternateAddressFields> AlternateNameAndAddressList { get; set; }
        /// <summary>
        /// Gets or sets the alternate name and address add list.
        /// Max count 23
        /// </summary>
        /// <value>
        /// The alternate name and address add list.
        /// </value>
        public IList<AlternateAddressAddFields> AlternateNameAndAddressAddList { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public struct AlternateAddressFields
    {

        public string x0101_NAME { get; set; }

        public string x0101_RECORD_CODE { get; set; }

        public string x0101_NAME_CONT { get; set; }

        public string x0101_LST_ASSGN_ALT_REC { get; set; }

        public string x0101_ADDRESS_LINE_ONE { get; set; }

        public string x0101_CUSTOMER_GREETING { get; set; }

        public string x0101_ADDRESS_LINE_TWO { get; set; }

        public string x0101_TELNUM_1 { get; set; }

        public string x0101_ADDRESS_LINE_THREE { get; set; }

        public string x0101_TELNUM_2 { get; set; }

        public string x0101_ADDRESS_LINE_FOUR { get; set; }

        public string x0101_TELEX_NUMBER { get; set; }

        public string x0101_ADDRESS_LINE_FIVE { get; set; }

        public string x0101_CONTACT_DATE { get; set; }

        public string x0101_ADDRESS_LINE_SIX { get; set; }

        public string x0101_SOCIAL_SECURITY { get; set; }

        public string x0101_ADDRESS_LINE7 { get; set; }

        public string x0101_TAXID { get; set; }

        public string x0101_BIRTH_INC_DATE { get; set; }
    }


    public struct AlternateAddressAddFields
    {
        public string x0101_E_MAIL_ADDRESS { get; set; }
        public string x0101_FAX_NUMBER { get; set; }
        public string x0101_WEBSITE { get; set; }
    }

}
