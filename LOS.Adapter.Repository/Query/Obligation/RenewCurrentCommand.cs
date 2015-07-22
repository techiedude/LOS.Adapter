
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    public class RenewCurrentCommand : BaseCommand
    {
        public RenewCurrentCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, luw, restartRequestCode)
        {

        }

        public string x1321_PROCESS_TYPE { get; set; }
        public string x1321_EFFECTIVE_DATE { get; set; }
        public string x1321_OUTSTANDING_PRINCIPAL { get; set; }
        public string x1321_RENEWAL_PREV_OBLGTN_NO { get; set; }
        public string x1321_LEGAL_MATURITY_DT { get; set; }
        public string x1321_ACCRUAL_SCHD_RATE { get; set; }
        public string x1321_ACCRUAL_SCHD_BASIS { get; set; }
        public string x1321_ORIGINAL_OBLGTN_AMT { get; set; }
        public string x1321_ORIGINAL_DISCOUNT_AMT { get; set; }
        public string x1321_OVERRIDE_PASSWORD { get; set; }
        public string REQUEST_1399_FIELDS { get; set; }
        public string x2301_PROCESS_TYPE { get; set; }
        public string x2301_OBLIGATION_TYPE { get; set; }
        public string x2301_GENERAL_LEDGER { get; set; }
        public string x2301_PURPOSE_CODE { get; set; }
        public string x2301_COLLATERAL_TYPE { get; set; }
        public string x2301_DURATION_CODE { get; set; }
        public string x2301_LEGAL_MATURITY_DATE { get; set; }
        public string x2301_ESTIMATED_MATURITY_DATE { get; set; }
        public string x2301_ASSIGNMENT_UNIT { get; set; }
        public string x2301_CONTACT_OFFICER { get; set; }
        public string x2301_SERVICE_UNIT { get; set; }
        public string x2301_FED_CLASS_CODE { get; set; }
        public string x2301_PREPAY_CODE { get; set; }
        public string x2301_SECURED_CODE { get; set; }
        public string x2305_USER_DATE_1 { get; set; }
        public string x2305_PRODUCT_CODE { get; set; }
        public string x2305_SHRD_NATIONAL_CREDIT { get; set; }
        public string x2305_REALTRAC_IND { get; set; }
        public string x2305_CREDIT_SCORE { get; set; }
        public string x2305_CREDIT_DATE { get; set; }
        public string x2305_EXAMINER_TYPE1 { get; set; }
        public string x2305_EXAMINER_CLASS1 { get; set; }
        public string x2305_FACILITY_RATING { get; set; }
        public string x2305_EXAMINER_DATE1 { get; set; }
        public string x2305_USER_CODE_2 { get; set; }
        public string x2305_BANK_SPECIFIC { get; set; }
        public string x2307_BILL_TYPE_CODE { get; set; }
        public string x2307_SECURITY_CODE { get; set; }
        public string x2311_ORIG_TERM_MONTHS { get; set; }
        public string x2311_ORIG_TOTAL_PAYMENTS { get; set; }
        public string x2311_COUPON_ORDER_CODE { get; set; }
        public string x2339_MAT_TOL_PERCENT { get; set; }
        public string x2339_CRA_IND { get; set; }
        public string x2347_ORIGINATING_UNIT { get; set; }
        public string x2347_SPECIAL_COMPANY_IND { get; set; }
        public string x2347_CREDIT_DESK_REF_NBR { get; set; }
        public string x2347_CASH_FLOW_RATIO { get; set; }
        public string x2347_LOAN_TO_VALUE_RATIO { get; set; }
        public string x2347_REFERRING_OFFICER { get; set; }
        public string x2347_CRA_PROPERTY_ADDRESS { get; set; }
        public string x2347_SECONDARY_OFFICER { get; set; }
        public string x2347_FULLY_NOT_FULLY_FUNDED { get; set; }
        public string x2347_FULLY_SECU_RED_BY_CRE { get; set; }
        public string x2347_PATICIPAT_ION_TYPE { get; set; }
        public string x2347_CDE_IDENTI_FIER { get; set; }
        public string x23BA_SOURCE_CODE { get; set; }
        public string x23BA_STATUS_CODE { get; set; }
        public string x23BA_APPROVAL_DATE { get; set; }
        public string x23BA_APPROVED_AMOUNT { get; set; }
        public string x23BA_GUARANTEED_PERCENT { get; set; }
        public string x23BA_FTA_SERVI_CING_PCT { get; set; }
        public string x23BA_SBA_OBLIGOR_OR_NUMBER { get; set; }
        public string x23BA_SPECIAL_MAIL_CODE { get; set; }
        public string x23BA_SETTLEMENT_DATE { get; set; }
        public string x23BA_DATE_SOLD { get; set; }
        public string x23BA_SERVICE_FEE_PCT { get; set; }
        public string x23BA_SERVICE_FEE_AMOUNT { get; set; }
        public string x23BA_SBA_SPREAD_OPTION { get; set; }
        public string x23M1_UNDERWR_CREDIT_SCORE { get; set; }
        public string x23M1_UNDERWR_CREDIT_SC_DATE { get; set; }
        public string x23M1_UNDERWR_CREDIT_SC_TYPE { get; set; }
        public string x23M1_UNDERWR_CREDIT_SC_REF_N { get; set; }
        public string x23M1_DEBT_TO_INCOME_RATIO { get; set; }
        public string x23M1_DEBT_AMOUNT { get; set; }
        public string x23M1_ORIGINAL_LTV_DATE { get; set; }
        public string x23M1_APPLICATION_DATE { get; set; }
        public string x23M1_ORIGINAL_LTV_RATIO { get; set; }
        public string x23M1_CONTRACT_A_DDS { get; set; }
        public string x23M1_L_C_CAP_AMOUNT { get; set; }
        public string x23M1_PRODUCT { get; set; }
        public string x23M1_CAMPAIGN { get; set; }
        public string x23M1_PROGRAM { get; set; }
        public string x23M1_APPLICATION_SOURCE { get; set; }
        public string x23M1_WORKPACKAGE_NUMBER { get; set; }
        public string x23M1_APPL_OVERRIDE_IND { get; set; }
        public string x23M1_WORKPACKAGE_TYPE { get; set; }
        public string x23M1_SUBMITTING_OFFICER { get; set; }
        public string x23M1_FINAL_APPROVE_OFFICER { get; set; }
        public string x23M1_CREDIT_RISK_REVIEW_OFFICER { get; set; }
        public string x23M1_CREDIT_RISK_LAST_REVIEW { get; set; }
        public string x23M1_EXCEPT_APPROVE_OFFICER { get; set; }
        public string x23M1_OCCUPANCY { get; set; }
        public string x23M1_UNDERWRITER { get; set; }
        public string x23M1_L_C_REFERENCE_NUMBER { get; set; }



    }
}
