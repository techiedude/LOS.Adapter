
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    public class CreateCurrentCommand : BaseCommand
    {
        public CreateCurrentCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, luw, restartRequestCode)
        {

        }

        public string x1301_PROCESS_TYPE { get; set; }
        public string x1301_OBLIGATION_TYPE { get; set; }
        public string x1301_GENERAL_LEDGER { get; set; }
        public string x1301_PURPOSE_CODE { get; set; }
        public string x1301_SECURED_CODE { get; set; }
        public string x1301_COLLATERAL_TYPE { get; set; }
        public string x1301_REG_U_Z { get; set; }
        public string x1301_OBLIGOR_TAKEDOWN_NO { get; set; }
        public string x1301_OBLIGATION_TAKEDOWN_NO { get; set; }
        public string x1301_DURATION_CODE { get; set; }
        public string x1301_LEGAL_MATURITY_DT { get; set; }
        public string x1301_ESTIMATED_MATURITY_DT { get; set; }
        public string x1301_BILL_DATE_LIMIT_CODE { get; set; }
        public string x1301_1098_INDICATOR { get; set; }
        public string x1301_NOTE_RESET_IND { get; set; }
        public string x1301_ASSIGNMENT_UNIT { get; set; }
        public string x1301_CONTACT_OFFICER { get; set; }
        public string x1301_SERVICE_UNIT { get; set; }
        public string x1301_FED_CLASS { get; set; }
        public string x1301_BANK_TAX_CLASS { get; set; }
        public string x1301_PREPAY_CODE { get; set; }
        public string x1301_MARGIN_CODE { get; set; }
        public string x1301_PAID_NOTE_NOTICE_IND { get; set; }
        public string x1301_LATE_CHARGE_FORMULA_TYPE { get; set; }
        public string x1301_LATE_CHARGE_PRM_REASON { get; set; }
        public string x1301_PART_SOLD_OBLIGOR { get; set; }
        public string x1301_PART_SOLD_OBLIGATION { get; set; }
        public string x1105_NOT_USED_BY_LEAD { get; set; }
        public string x1305_COLLECTION_MONITOR { get; set; }
        public string x1305_USER_DATE_1 { get; set; }
        public string x1305_CASH_MANAGEMENT { get; set; }
        public string x1305_REALTRAC_IND { get; set; }
        public string x1305_BANK_SPECIFIC { get; set; }
        public string x1305_PRODUCT_CODE { get; set; }
        public string x1305_CREDIT_SCORE { get; set; }
        public string x1305_CREDIT_DATE { get; set; }
        public string x1305_EXAMINERS_TYPE_1 { get; set; }
        public string x1305_EXAMINERS_CLASS_1 { get; set; }
        public string x1305_FACILITY_RISK_RATING { get; set; }
        public string x1305_EXAMINERS_CLASS_DATE_1 { get; set; }
        public string x1305_TRANS_NOTICE_INDICATOR { get; set; }
        public string x1105_NOT_USED_BY_LEAD1A { get; set; }
        public string x1105_USER_CODE_2 { get; set; }
        public string x1105_NOT_USED_BY_LEAD1B { get; set; }
        public string x1307_BILL_TYPE_CODE { get; set; }
        public string x1307_SECURITY_CODE { get; set; }
        public string x1311_ORIG_TERM_MONTHS { get; set; }
        public string x1311_ORIG_TOTAL_PAYMENTS { get; set; }
        public string x1311_COUPON_ORDER_CODE { get; set; }
        public string x1339_MAT_TOL_PERCENT { get; set; }
        public string x1339_CRA_INDICATOR { get; set; }
        public string x1105_NOT_USED_BY_LEAD2 { get; set; }
        public string x1339_RATE_SPREAD { get; set; }
        public string x1339_NOT_USED_BY_LEAD { get; set; }
        public string x1347_ORIGINATING_UNIT { get; set; }
        public string x1347_SPECIAL_CO__INDICATOR { get; set; }
        public string x1347_CREDIT_DESK_REF_NBR { get; set; }
        public string x1347_CASH_FLOW_RATIO { get; set; }
        public string x1347_LOAN_VALUE_RATIO { get; set; }
        public string x1347_REFERRING_OFFICER { get; set; }
        public string x1347_CRA_PROP_ADDRESS { get; set; }
        public string x1347_SECONDARY_OFFICER { get; set; }
        public string x1105_NOT_USED_BY_LEAD3 { get; set; }
        public string x1347_FULLY_NOT_FULLY_FUNDED { get; set; }
        public string x1347_FULLY_SECU_RED_BY_CRE { get; set; }
        public string x1347_PATICIPAT_ION_TYPE { get; set; }
        public string x1347_CDE_IDENTI_FIER { get; set; }
        public string x13BA_SBA_LOAN_NUMBER { get; set; }
        public string x13BA_SOURCE_CODE { get; set; }
        public string x13BA_PROGRAM_TYPE { get; set; }
        public string x13BA_STATUS_CODE { get; set; }
        public string x13BA_APPROVAL_DATE { get; set; }
        public string x13BA_APPROVED_AMOUNT { get; set; }
        public string x13BA_GUARANTEED_PERCENT { get; set; }
        public string x13BA_FTA_SERVI_CING_PCT { get; set; }
        public string x13BA_SBA_OBLIG_OR_NUMBER { get; set; }
        public string x13BA_SPECIAL_MAIL_CODE { get; set; }
        public string x13BA_SETTLEMENT_DATE { get; set; }
        public string x13BA_DATE_SOLD { get; set; }
        public string x13BA_SERVICE_FEE_PCT { get; set; }
        public string x13BA_SERVICE_FEE_AMOUNT { get; set; }
        public string x13BA_SBA_SPREAD_OPTION { get; set; }
        public string x13M1_UNDERWR_CREDIT_SCORE { get; set; }
        public string x13M1_UNDERWR_CREDIT_SC_DATE { get; set; }
        public string x13M1_UNDERWR_CREDIT_SC_TYPE { get; set; }
        public string x13M1_UNDERWR_CREDIT_SC_REF_N { get; set; }
        public string x13M1_DEBT_TO_INCOME_RATIO { get; set; }
        public string x13M1_DEBT_AMOUNT { get; set; }
        public string x13M1_ORIGINAL_LTV_DATE { get; set; }
        public string x13M1_APPLICATION_DATE { get; set; }
        public string x13M1_ORIGINAL_LTV_RATIO { get; set; }
        public string x13M1_CONTRACT_A_DDS { get; set; }
        public string x13M1_L_C_CAP_AMOUNT { get; set; }
        public string x13M1_PRODUCT { get; set; }
        public string x13M1_CAMPAIGN { get; set; }
        public string x13M1_PROGRAM { get; set; }
        public string x13M1_APPLICATION_SOURCE { get; set; }
        public string x13M1_WORKPACKAGE_NUMBER { get; set; }
        public string x13M1_APPL_OVERRIDE_IND { get; set; }
        public string x13M1_WORKPACKAGE_TYPE { get; set; }
        public string x13M1_SUBMITTING_OFFICER { get; set; }
        public string x13M1_FINAL_APPROVE_OFFICER { get; set; }
        public string x13M1_CREDIT_RISK_REVIEW_OFFICER { get; set; }
        public string x13M1_CREDIT_RISK_LAST_REVIEW { get; set; }
        public string x13M1_EXCEPT_APPROVE_OFFICER { get; set; }
        public string x13M1_OCCUPANCY { get; set; }
        public string x13M1_UNDERWRITER { get; set; }
        public string x13M1_L_C_REFERENCE_NUMBER { get; set; }
        public string x13M1_NEXT_REQ_CODE { get; set; }
        public string x13M1_ENTERED_REQ_CODE { get; set; }
        public string x3502_EFF_DATE { get; set; }
        public string x3502_NEW_LOAN_ADVANCE { get; set; }
        public string x3502_OVERRIDE_PASSWORD { get; set; }
        public string x3402_EFF_DATE { get; set; }
        public string x3402_ADVANCE_AMOUNT { get; set; }
        public string x3402_OVERRIDE_PASSWORD { get; set; }



    }
}
