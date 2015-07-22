using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// L015
    /// </summary>
    public class UpdateObligorIndicativeCommand : BaseCommand
    {
        public UpdateObligorIndicativeCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, luw, restartRequestCode)
        {

        }


        public string x2020_CIN { get; set; }
        public string x2020_CREDIT_RATING { get; set; }
        public string x2020_DATE_OF_CRED_RATING { get; set; }
        public string x2020_GEOGRAPHIC_CODE_1 { get; set; }
        public string x2020_GEOGRAPHIC_INDICATOR { get; set; }
        public string x2020_HMDA_ETHNIC { get; set; }
        public string x2020_HMDA_GENDER { get; set; }
        public string x2020_NAD_CUSTOMER_NUMBER { get; set; }
        public string x2020_OBLIGOR_TAX_CLASS { get; set; }
        public string x2020_OBLIGOR_TYPE { get; set; }
        public string x2020_PERS_INCOME { get; set; }
        public string x2025_APPROVAL_LEVEL { get; set; }
        public string x2025_USER_AMOUNT { get; set; }
        public string x2025_W_9_CODE { get; set; }
        public string x2035_NAICS_CODE { get; set; }
        public string x2040_ASSIGNMENT_UNIT { get; set; }
        public string x2040_CL_USER_ALPHA { get; set; }
        public string x2040_CL_USER_CODE_2 { get; set; }
        public string x2040_CL_USER_NUMERIC { get; set; }
        public string x2040_CONTACT_OFFICER { get; set; }
        public string x2040_DATE_OF_NEXT_STATEMENT { get; set; }
        public string x2040_FILLER { get; set; }
        public string x2040_SERVICE_UNIT { get; set; }
        public string x2040_STATEMENT_FREQUENCY { get; set; }
        public string x2040_STATEMENT_TYPE { get; set; }
        public string x2044_CMS_IDENTIFIER { get; set; }
    }
}
