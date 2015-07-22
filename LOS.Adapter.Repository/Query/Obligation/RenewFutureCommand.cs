
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    public class RenewFutureCommand : BaseCommand
    {
        public RenewFutureCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, luw, restartRequestCode)
        {

        }

        public string x1199_EFF_DATE { get; set; }
        public string x1199_EXPIRATION_DATE { get; set; }
        public string x1199_NEW_LOAN_AMOUNTX { get; set; }
        public string x1199_OVERRIDE_PSWD { get; set; }
        public string x2101_PROCESS_TYPE { get; set; }
        public string x2101_OBLIGATION_TYPE { get; set; }
        public string x2101_GENERAL_LEDGER_CODE { get; set; }
        public string x2101_PURPOSE_CODE { get; set; }
        public string x2101_SECURED_CODE { get; set; }
        public string x2101_COLLATERAL_TYPE { get; set; }
        public string x2101_DURATION_CODE { get; set; }
        public string x2101_LEGAL_MATURITY_DATE { get; set; }
        public string x2101_ESTIMATED_MATURITY_DATE { get; set; }
        public string x2101_RESET_IND { get; set; }
        public string x2101_ASSIGNMENT_UNIT { get; set; }
        public string x2101_CONTACT_OFFICER { get; set; }
        public string x2101_SERVICE_UNIT { get; set; }
        public string x2101_FED_CLASS_CODE { get; set; }
        public string x2101_BANK_TAX { get; set; }
        public string x2101_PART_OBLIGOR { get; set; }
        public string x2101_PART_OBLIGATION { get; set; }
        public string x2105_OPTION_IND { get; set; }
        public string x2105_USER_DATE_1 { get; set; }
        public string x2105_CASH_MANAGEMENT { get; set; }
        public string x2105_REALTRAC_IND { get; set; }
        public string x2105_BANK_SPECIFIC { get; set; }
        public string x2105_PRODUCT_CODE { get; set; }
        public string x2105_CREDIT_SCORE { get; set; }
        public string x2105_CREDIT_DATE { get; set; }
        public string x2105_EXAMINER_TYPE1 { get; set; }
        public string x2105_EXAMINER_CLASS1 { get; set; }
        public string x2105_FACILITY_RATING { get; set; }
        public string x2105_EXAMINER_DATE1 { get; set; }
        public string x2107_CLOSE_IND { get; set; }
        public string x2107_EFF_DATE_OF_COMMIT_CLOSE { get; set; }
        public string x2107_SECURITY_CODE { get; set; }
        public string x2147_ORIGINATING_UNIT { get; set; }
        public string x2147_SPECIAL_COMPANY_IND { get; set; }
        public string x2147_CREDIT_DESK_REF_NBR { get; set; }
        public string x2147_CASH_FLOW_RATIO { get; set; }
        public string x2147_LOAN_TO_VALUE_RATIO { get; set; }
        public string x2147_REFERRING_OFFICER { get; set; }
        public string x2147_CRA_PROPERTY_ADDRESS { get; set; }
        public string x2147_SECONDARY_OFFICER { get; set; }
        public string x2147_FULLY_NOT_FULLY_FUNDED { get; set; }
        public string x2147_FULLY_SECU_RED_BY_CRE { get; set; }
        public string x2147_PATICIPAT_ION_TYPE { get; set; }
        public string x2147_CDE_IDENTI_FIER { get; set; }
        public string x21BA_SOURCE_CODE { get; set; }
        public string x21BA_STATUS_CODE { get; set; }
        public string x21BA_APPROVAL_DATE { get; set; }
        public string x21BA_APPROVED_AMOUNT { get; set; }
        public string x21BA_GUARANTEED_PERCENT { get; set; }
        public string x21BA_FTA_SERVI_CING_PCT { get; set; }
        public string x21BA_SBA_OBLIGOR_OR_NUMBER { get; set; }
        public string x21BA_SPECIAL_MAIL_CODE { get; set; }
        public string x21BA_SETTLEMENT_DATE { get; set; }
        public string x21BA_DATE_SOLD { get; set; }
        public string x21BA_SERVICE_FEE_PCT { get; set; }
        public string x21BA_SERVICE_FEE_AMOUNT { get; set; }
        public string x21BA_SBA_SPREAD_OPTION { get; set; }
        public string x21M1_UNDERWR_CREDIT_SCORE { get; set; }
        public string x21M1_UNDERWR_CREDIT_SC_DATE { get; set; }
        public string x21M1_UNDERWR_CREDIT_SC_TYPE { get; set; }
        public string x21M1_UNDERWR_CREDIT_SC_REF_N { get; set; }
        public string x21M1_DEBT_TO_INCOME_RATIO { get; set; }
        public string x21M1_DEBT_AMOUNT { get; set; }
        public string x21M1_ORIGINAL_LTV_DATE { get; set; }
        public string x21M1_APPLICATION_DATE { get; set; }
        public string x21M1_ORIGINAL_LTV_RATIO { get; set; }
        public string x21M1_CONTRACT_A_DDS { get; set; }
        public string x21M1_L_C_CAP_AMOUNT { get; set; }
        public string x21M1_PRODUCT { get; set; }
        public string x21M1_CAMPAIGN { get; set; }
        public string x21M1_PROGRAM { get; set; }
        public string x21M1_APPLICATION_SOURCE { get; set; }
        public string x21M1_WORKPACKAGE_NUMBER { get; set; }
        public string x21M1_APPL_OVERRIDE_IND { get; set; }
        public string x21M1_WORKPACKAGE_TYPE { get; set; }
        public string x21M1_SUBMITTING_OFFICER { get; set; }
        public string x21M1_FINAL_APPROVE_OFFICER { get; set; }
        public string x21M1_CREDIT_RISK_REVIEW_OFFICER { get; set; }
        public string x21M1_CREDIT_RISK_LAST_REVIEW { get; set; }
        public string x21M1_EXCEPT_APPROVE_OFFICER { get; set; }
        public string x21M1_OCCUPANCY { get; set; }
        public string x21M1_UNDERWRITER { get; set; }
        public string x21M1_L_C_REFERENCE_NUMBER { get; set; }


    }
}
