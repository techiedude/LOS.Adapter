
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services
{
    public class CreateFutureCommand : BaseCommand
    {
        public CreateFutureCommand(string user, string password, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, password, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, luw, restartRequestCode)
        {

        }


        public string x1101_PROCESS_TYPE { get; set; }
        public string x1101_OBLIGATION_TYPE { get; set; }
        public string x1101_GENERAL_LEDGER { get; set; }
        public string x1101_PURPOSE_CODE { get; set; }
        public string x1101_SECURED_CODE { get; set; }
        public string x1101_COLLATERAL_TYPE { get; set; }
        public string x1101_OBLIGOR_TAKEDOWN_NO { get; set; }
        public string x1101_OBLIGATION_TAKEDOWN_NO { get; set; }
        public string x1101_DURATION_CODE { get; set; }
        public string x1101_LEGAL_MATURITY_DT { get; set; }
        public string x1101_ESTIMATED_MATURITY_DT { get; set; }
        public string x1101_NOTE_RESET_IND { get; set; }
        public string x1101_ASSIGNMENT_UNIT { get; set; }
        public string x1101_CONTACT_OFFICER { get; set; }
        public string x1101_SERVICE_UNIT { get; set; }
        public string x1101_FED_CLASS { get; set; }
        public string x1101_BANK_TAX_CLASS { get; set; }
        public string x1101_PART_SOLD_OBLIGOR { get; set; }
        public string x1101_PART_SOLD_OBLIGATION { get; set; }
        public string x1101_NOT_USED_BY_LEAD { get; set; }
        public string x1105_CLOSE_OPTION_IND { get; set; }
        public string x1105_USER_DATE_1 { get; set; }
        public string x1105_CASH_MANAGEMENT { get; set; }
        public string x1105_REALTRAC_IND { get; set; }
        public string x1105_BANK_SPECIFIC { get; set; }
        public string x1105_PRODUCT_CODE { get; set; }
        public string x1105_CREDIT_SCORE { get; set; }
        public string x1105_CREDIT_DATE { get; set; }
        public string x1105_EXAMINERS_TYPE_1 { get; set; }
        public string x1105_EXAMINERS_CLASS_1 { get; set; }
        public string x1105_FACILITY_RISK_RATING { get; set; }
        public string x1105_EXAMINERS_CLASS_DATE_1 { get; set; }
        public string x1105_NOT_USED_BY_LEAD { get; set; }
        public string x1139_CRA_INDICATOR { get; set; }
        public string x1139_CENSUS_TRACT { get; set; }
        public string x1139_SMSA_CODE { get; set; }
        public string x1139_NOT_USED_BY_LEAD { get; set; }
        public string x1139_RATE_SPREAD { get; set; }
        public string x1139_NOT_USED_BY_LEAD2 { get; set; }
        public string x1147_ORIGINATING_UNIT { get; set; }
        public string x1147_SPECIAL_CO__INDICATOR { get; set; }

        public string x1147_CREDIT_DESK_REF_NBR { get; set; }
        public string x1147_CASH_FLOW_RATIO { get; set; }
        public string x1147_LOAN_VALUE_RATIO { get; set; }
        public string x1147_REFERRING_OFFICER { get; set; }
        public string x1147_CRA_PROP_ADDRESS { get; set; }
        public string x1147_SECONDARY_OFFICER { get; set; }
        public string x1147_NOT_USED_BY_LEAD { get; set; }
        public string x1147_FULLY_NOT_FULLY_FUNDED { get; set; }
        public string x1147_FULLY_SECU_RED_BY_CRE { get; set; }
        public string x1147_PATICIPAT_ION_TYPE { get; set; }
        public string x1147_CDE_IDENTI_FIER { get; set; }
        public string x11BA_SBA_LOAN_NUMBER { get; set; }
        public string x11BA_SOURCE_CODE { get; set; }
        public string x11BA_PROGRAM_TYPE { get; set; }
        public string x11BA_STATUS_CODE { get; set; }
        public string x11BA_APPROVAL_DATE { get; set; }
        public string x11BA_APPROVED_AMOUNT { get; set; }
        public string x11BA_GUARANTEED_PERCENT { get; set; }
        public string x11BA_FTA_SERVI_CING_PCT { get; set; }
        public string x11BA_SBA_OBLIG_OR_NUMBER { get; set; }
        public string x11BA_SPECIAL_MAIL_CODE { get; set; }
        public string x11BA_SETTLEMENT_DATE { get; set; }
        public string x11BA_DATE_SOLD { get; set; }
        public string x11BA_SERVICE_FEE_PCT { get; set; }
        public string x11BA_SERVICE_FEE_AMOUNT { get; set; }
        public string x11BA_SBA_SPREAD_OPTION { get; set; }
        public string x11M1_UNDERWR_CREDIT_SCORE { get; set; }
        public string x11M1_UNDERWR_CREDIT_SC_DATE { get; set; }
        public string x11M1_UNDERWR_CREDIT_SC_TYPE { get; set; }
        public string x11M1_UNDERWR_CREDIT_SC_REF_N { get; set; }
        public string x11M1_DEBT_TO_INCOME_RATIO { get; set; }
        public string x11M1_DEBT_AMOUNT { get; set; }
        public string x11M1_ORIGINAL_LTV_DATE { get; set; }
        public string x11M1_APPLICATION_DATE { get; set; }
        public string x11M1_ORIGINAL_LTV_RATIO { get; set; }
        public string x11M1_CONTRACT_A_DDS { get; set; }
        public string x11M1_L_C_CAP_AMOUNT { get; set; }
        public string x11M1_PRODUCT { get; set; }
        public string x11M1_CAMPAIGN { get; set; }
        public string x11M1_PROGRAM { get; set; }
        public string x11M1_APPLICATION_SOURCE { get; set; }
        public string x11M1_WORKPACKAGE_NUMBER { get; set; }
        public string x11M1_APPL_OVERRIDE_IND { get; set; }
        public string x11M1_WORKPACKAGE_TYPE { get; set; }
        public string x11M1_SUBMITTING_OFFICER { get; set; }
        public string x11M1_FINAL_APPROVE_OFFICER { get; set; }
        public string x11M1_CREDIT_RISK_REVIEW_OFFICER { get; set; }
        public string x11M1_CREDIT_RISK_LAST_REVIEW { get; set; }
        public string x11M1_EXCEPT_APPROVE_OFFICER { get; set; }
        public string x11M1_OCCUPANCY { get; set; }
        public string x11M1_UNDERWRITER { get; set; }
        public string x11M1_L_C_REFERENCE_NUMBER { get; set; }
        public string x11M1_NEXT_REQ_CODE { get; set; }
        public string x11M1_ENTERED_REQ_CODE { get; set; }
        public string x3301_EFF_DATE { get; set; }
        public string x3301_NEW_LOAN_ADVANCE { get; set; }
        public string x3301_OVERRIDE_PASSWORD { get; set; }
        public string x3351_EFF_DATE { get; set; }
        public string x3351_NEW_LOAN_ADVANCE { get; set; }
        public string x3351_OVERRIDE_PASSWORD { get; set; }

    }
}
