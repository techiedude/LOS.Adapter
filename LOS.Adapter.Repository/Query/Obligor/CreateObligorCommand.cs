
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    /// <summary>
    /// CreateObligorCommand
    /// </summary>
    public class CreateObligorCommand : BaseCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObligorCommand"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="password">The password.</param>
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
        public CreateObligorCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

        public string X1001_CUSTOMER_GREETING { get; set; }
        public string X1001_CUSTOMER_NAME { get; set; }
        public string X1001_CUSTOMER_NAME_CONT { get; set; }
        public string X1001_BIRTH_INC_DATE { get; set; }
        public string X1001_SOCIAL_SECURITY { get; set; }
        public string X1001_TAXID { get; set; }
        public string X1001_ADDRESS_LINE_ONE { get; set; }
        public string X1001_ADDRESS_LINE_TWO { get; set; }
        public string X1001_ADDRESS_LINE_THREE { get; set; }
        public string X1001_ADDRESS_LINE_FOUR { get; set; }
        public string X1001_ADDRESS_LINE_FIVE { get; set; }
        public string X1001_ADDRESS_LINE_SIX { get; set; }
        public string X1001_CITY { get; set; }
        public string X1001_STATE_PROVINCE { get; set; }
        public string X1001_ZIP_CODE { get; set; }
        public string X1001_BUSINESS_AREA_CODE { get; set; }
        public string X1001_BUSINESS_PHONE_NUMBER { get; set; }
        public string X1001_BUSINESS_EXTENSION { get; set; }
        public string X1001_RESIDENT_AREA_CODE { get; set; }
        public string X1001_RESIDENT_PHONE_NUMBER { get; set; }
        public string X1001_RESIDENT_EXTENSION { get; set; }
        public string X1001_TIME_ZONE { get; set; }
        public string X1001_CONTACT_DATE { get; set; }
        public string X1001_FOUND_ON_CRF { get; set; }
        public string X1035_NAICS_CODE { get; set; }
        public string X1040_ASSIGNMENT_UNIT { get; set; }
        public string X1040_CONTACT_OFFICER { get; set; }
        public string X1040_SERVICE_UNIT { get; set; }
        public string X1040_SIC_CODE { get; set; }
        public string X1043_COUNTRY_OF_ISSUE { get; set; }
        public string X1043_EXPIRATION_DATE { get; set; }
        public string X1043_ID_NUMBER_1 { get; set; }
        public string X1043_ID_NUMBER_2 { get; set; }
        public string X1043_ID_NUMBER_3 { get; set; }
        public string X1043_ISSUANCE_DATE { get; set; }
        public string X1043_STATE_OF_ISSUE { get; set; }
        public string X1043_TYPE_ID { get; set; }
        public string X1043_TYPE_TIN_IND { get; set; }

    }
}
