using LOS.Adapter.Data.Services.Query.Base;
using System.Collections.Generic;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// L002 - Check the copybook
    /// </summary>
    public class CreateAlternateNameAndAddressCommand : BaseCommand
    {
        public CreateAlternateNameAndAddressCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

        /// <summary>
        /// 1091 fields - 23 items to be sent in.
        /// </summary>
        /// <value>
        /// The reques T_1091_ fields.
        /// </value>
        public List<REQUEST_1091_FIELD_DESC> AlternateNameAndAddressFields { get; set; }

        /// <summary>
        /// 1091 extra fields - 23 items to be sent in.
        /// </summary>
        /// <value>
        /// The reques T_1091_ field s_ extra.
        /// </value>
        public List<REQUEST_1091_FIELD_DESC_EXTRA> AlternateNameAndAddressExtraFields { get; set; }

    }

    /// <summary>
    /// 1091 fields
    /// </summary>
    public struct REQUEST_1091_FIELD_DESC
    {

        public string x1091_NAME_TITLE { get; set; }

        public string x1091_NAME { get; set; }

        public string x1091_NAME_CONTINUED { get; set; }

        public string x1091_ADDRESS1 { get; set; }

        public string x1091_ADDRESS2 { get; set; }

        public string x1091_ADDRESS3 { get; set; }

        public string x1091_ADDRESS4 { get; set; }

        public string x1091_ADDRESS5 { get; set; }

        public string x1091_ADDRESS6 { get; set; }

        public string x1091_CITY { get; set; }

        public string x1091_STATE { get; set; }

        public string x1091_ZIP_CODE { get; set; }

        public string x1091_TIN { get; set; }

        public string x1091_SSN { get; set; }

        public string x1091_TELEPHONE1 { get; set; }

        public string x1091_TELEPHONE2 { get; set; }

        public string x1091_NAAD_RECORD_CODE { get; set; }
    }

    /// <summary>
    /// 1091 extra fields
    /// </summary>
    public struct REQUEST_1091_FIELD_DESC_EXTRA
    {
        public string x1091_BYTE_TO_MATCH_1001 { get; set; }
        public string x1091_RESIDENT_EXTENSION { get; set; }
        public string x1091_BUSINESS_EXTENSION { get; set; }
        public string x1091_TELEX_PHONE_NUMBER { get; set; }
        public string x1091_FAX_AREA_CODE { get; set; }
        public string x1091_FAX_PHONE_NUMBER { get; set; }
        public string x1091_TIME_ZONE { get; set; }
        public string x1091_EMAIL_ADDR_ESS { get; set; }
        public string x1091_WEBSITE { get; set; }

    }

}
