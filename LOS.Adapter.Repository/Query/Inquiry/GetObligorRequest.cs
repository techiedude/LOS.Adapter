
using LOS.Adapter.Data.Services.Query.Base;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// 
    /// </summary>
    public class GetObligorRequest : BaseRequest<GetObligorResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetObligorRequest"/> class.
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
        public GetObligorRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class GetObligorResponse : BaseResponse
    {
        public short x102A_OBLIGOR_TYPE { get; set; }
        public string x102A_CREDIT_RATING { get; set; }
        public string x102A_DATE_OF_CRED_RATING { get; set; }
        public int x102A_GEOGRAPHIC_CODE_1 { get; set; }
        public string x102A_GEOGRAPHIC_INDICATOR { get; set; }
        public short x102A_OBLIGOR_TAX_CLASS { get; set; }
        public decimal x102A_PERS_INCOME { get; set; }
        public short x102A_HMDA_GENDER { get; set; }
        public short x102A_HMDA_ETHNIC { get; set; }
        public string x102A_CENTRAL_FILE_REFERENCE { get; set; }
        public string x102B_USER_CODE_1 { get; set; }
        public string x102B_USER_CODE_2 { get; set; }
        public decimal x102B_USER_AMOUNT { get; set; }
        public string x102C_ASSIGNMENT_UNIT { get; set; }
        public int x102C_CONTACT_OFFICER { get; set; }
        public int x102C_SERVICE_UNIT { get; set; }
        public short x102C_STATEMENT_TYPE { get; set; }
        public short x102C_STATEMENT_FREQUENCY { get; set; }
        public string x102C_DATE_OF_NEXT_STATEMENT { get; set; }
        public string x102C_CL_USER_CODE_2 { get; set; }
        public string x102C_CL_USER_ALPHA { get; set; }
        public string x102D_CMS_IDENTIFIER { get; set; }
        public int x102E_NAICS { get; set; }
        public string L101_NAME { get; set; }
        public string L101_RECORD_CODE { get; set; }
        public string L101_NAME_CONT { get; set; }
        public string L101_LST_ASSGN_ALT_REC { get; set; }
        public string L101_ADDRESS_LINE_ONE { get; set; }
        public string L101_CUSTOMER_GREETING { get; set; }
        public string L101_ADDRESS_LINE_TWO { get; set; }
        public string L101_AREA_CODE_1 { get; set; }
        public string L101_LOCAL_NUM_1 { get; set; }
        public string L101_EXTENSION_1 { get; set; }
        public string L101_ADDRESS_LINE_THREE { get; set; }
        public string L101_AREA_CODE_2 { get; set; }
        public string L101_LOCAL_NUM_2 { get; set; }
        public string L101_EXTENSION_2 { get; set; }
        public string L101_ADDRESS_LINE_FOUR { get; set; }
        public string L101_TELEX_NUMBER { get; set; }
        public string L101_ADDRESS_LINE_FIVE { get; set; }
        public string L101_CONTACT_DATE { get; set; }
        public string L101_ADDRESS_LINE_SIX { get; set; }
        public string L101_SOCIAL_SECURITY { get; set; }
        public string L101_ADDRESS_LINE7 { get; set; }
        public string L101_TAXID { get; set; }
        public string L101_BIRTH_INC_DATE { get; set; }
        public string x102A_OBLIGOR_TYPE_LIT { get; set; }
        public string x102A_OBLIGOR_SHORT_NAME { get; set; }
        public string x102A_STATUS_CODE { get; set; }
        public string x102A_STATUS_CODE_LIT { get; set; }
        public string x102A_STATUS_DATE { get; set; }
        public string x102A_LAST_FINANCL_STMT_DATE { get; set; }
        public string x102A_CRED_RATING_SOURCE { get; set; }
        public string x102A_CRED_RATING_SOURCE_LIT { get; set; }
        public string x102A_GEOGRAPHIC_IND_DESC { get; set; }
        public string x102A_BANK_TAX { get; set; }
        public string x102A_BANK_TAX_CLASS_LIT { get; set; }
        public string x102A_GEOGRAPHIC_CODE_2 { get; set; }
        public string x102A_FISCAL_YEAR_END_DATE { get; set; }
        public string x102A_OBLIGOR_TAX_CLASS_LIT { get; set; }
        public string x102A_INTERLOCKING_DIRECTOR { get; set; }
        public string x102A_INTERLOCK_CODE_LIT { get; set; }
        public string x102A_BANK_ASSOC_CODE { get; set; }
        public string x102A_BANK_ASSOC_CODE_LIT { get; set; }
        public string x102A_AFFILIATED_RELATIONSHIP { get; set; }
        public string x102A_AFFILIATED_CODE_LIT { get; set; }
        public string x102A_AFFILIATED_NUMBER { get; set; }
        public string x102A_DUNS_NUMBER { get; set; }
        public string x102A_CRA_BUSINESS { get; set; }
        public string x102A_CRA_BUSINESS_LIT { get; set; }
        public string x102A_STAND_METRO_STAT_AREA { get; set; }
        public string x102A_RACE_1 { get; set; }
        public string x102A_RACE_1_LIT { get; set; }
        public string x102A_CRA_GENDER_LIT { get; set; }
        public decimal x102A_CENSUS_TRACT { get; set; }
        public string x102A_RACE_2 { get; set; }
        public string x102A_RACE_2_LIT { get; set; }
        public string x102A_PRIVACY_CODE { get; set; }
        public string x102A_EMPLOYEE_OBLIGOR_NO { get; set; }
        public string x102A_RACE_3 { get; set; }
        public string x102A_RACE_3_LIT { get; set; }
        public string x102A_ETHNICITY_LIT { get; set; }
        public string x102A_RACE_4 { get; set; }
        public string x102A_RACE_4_LIT { get; set; }
        public string x102A_RACE_5 { get; set; }
        public string x102A_RACE_5_LIT { get; set; }
        public string x102B_DATE_ACCOUNT_OPENED { get; set; }
        public string x102B_DATE_OF_LAST_CHANGE { get; set; }
        public string x102B_LAST_TRAN_JOURNAL_DATE { get; set; }
        public string x102B_LAST_ACTIVE_DATE { get; set; }
        public string x102B_DATE_OF_LAST_ACTIVY { get; set; }
        public string x102B_MULT_SERVICE_UNIT_ACTIVTY { get; set; }
        public string x102B_MULT_BORROWS_LIT { get; set; }
        public string x102B_ACTIVE_OBLNS_CODE { get; set; }
        public string x102B_ACTIVE_OBLNS_CODE_LIT { get; set; }
        public string x102B_LAST_OBLIGAT_NR_ASSIGNED { get; set; }
        public string x102B_OLD_OBLIGOR_NUMBER { get; set; }
        public string x102B_SYSTEM_CODE { get; set; }
        public string x102B_STATEMENT_TYPE { get; set; }
        public string x102B_STATEMENT_TYPE_LIT { get; set; }
        public string x102B_STATEMENT_FREQUENCY { get; set; }
        public string x102B_STATEMENT_FREQ_LIT { get; set; }
        public string x102B_DATE_OF_NEXT_STATEMENT { get; set; }
        public string x102B_SPECIAL_INFO_DATE { get; set; }
        public string x102B_SPECIAL_INFO_CODE { get; set; }
        public string x102B_SPEC_INFO_CODE_LIT { get; set; }
        public string x102B_SPL_INSTRUCT_DATE { get; set; }
        public string x102B_SPECIAL_INFO_OFFICE { get; set; }
        public string x102B_SPL_INSTRUCT_OFFICER { get; set; }
        public string x102B_USER_DATE_1 { get; set; }
        public string x102B_USER_DATE_2 { get; set; }
        public string x102B_USER_CODE_3 { get; set; }
        public string x102B_USER_NUMERIC { get; set; }
        public string x102B_USER_ALPHA { get; set; }
        public string x102B_COLLECTION_MONITOR { get; set; }
        public string x102B_COLLECT_MON_LIT { get; set; }
        public string x102B_COLLECTION_TIMES { get; set; }
        public string x102B_PREV_COLLECT_STATUS { get; set; }
        public string x102B_PREV_COLL_LIT { get; set; }
        public string x102B_CURR_COLLECT_STATUS { get; set; }
        public string x102B_CURR_COLL_LIT { get; set; }
        public string x102E_CRED_RATING_SOURCE { get; set; }
        public string x102E_RATING_TYPE_1_LIT { get; set; }
        public string x102E_CREDIT_RATING { get; set; }
        public string x102E_DATE_OF_CRED_RATING { get; set; }
        public string x102E_RATING_TYP_E_2 { get; set; }
        public string x102E_RATING_TYPE_2_LIT { get; set; }
        public string x102E_CREDIT_RAT_ING_2 { get; set; }
        public string x102E_CREDIT_RAT_ING_DATE_2 { get; set; }
        public string x102E_RATING_TYP_E_3 { get; set; }
        public string x102E_RATING_TYPE_3_LIT { get; set; }
        public string x102E_CREDIT_RAT_ING_3 { get; set; }
        public string x102E_CREDIT_RAT_ING_DATE_3 { get; set; }
        public string x102E_RATING_TYP_E_4 { get; set; }
        public string x102E_RATING_TYPE_4_LIT { get; set; }
        public string x102E_CREDIT_RAT_ING_4 { get; set; }
        public string x102E_CREDIT_RAT_ING_DATE_4 { get; set; }
        public string x102E_RATING_TYP_E_5 { get; set; }
        public string x102E_RATING_TYPE_5_LIT { get; set; }
        public string x102E_CREDIT_RAT_ING_5 { get; set; }
        public string x102E_CREDIT_RAT_ING_DATE_5 { get; set; }
        public string x102E_SIC_CODE { get; set; }
        public string x102E_ADDL_NAICS_1 { get; set; }
        public decimal x102E_ADDL_NAICS_1_PCT { get; set; }
        public string x102E_ADDL_NAICS_2 { get; set; }
        public decimal x102E_ADDL_NAICS_2_PCT { get; set; }
        public string x102E_ADDL_NAICS_3 { get; set; }
        public decimal x102E_ADDL_NAICS_3_PCT { get; set; }
        public string x102E_ADDL_NAICS_4 { get; set; }
        public decimal x102E_ADDL_NAICS_4_PCT { get; set; }
        public string x102E_ADDL_NAICS_5 { get; set; }
        public decimal x102E_ADDL_NAICS_5_PCT { get; set; }
        public string x102E_INDUSTRY_A_T_RISK { get; set; }
        public decimal x102E_INDUSTRY_A_T_RISK_PCT { get; set; }
        public string x102E_SOURCE_CHE_CKED { get; set; }
        public string x102E_DATE_LAST_CHECKED { get; set; }
        public string x102E_RESULT_OF_CHECK { get; set; }
        public string x102E_RESULT_OF_CHK_LIT { get; set; }
        public string x102E_COUNTRY_OF_CITIZEN_1 { get; set; }
        public string x102E_COUNTRY_OF_REGISTRATIO { get; set; }
        public string x102E_FOREIGN_PO_LITICAL_IND { get; set; }
        public string x102E_COUNTRY_OF_CITIZEN_2 { get; set; }
        public string x102E_US_CITIZEN_IND { get; set; }
        public decimal x102E_ASSET_SIZ_E { get; set; }
        public string x102C_LOB_NUMBER { get; set; }
        public string x102C_REGION_NUMBER { get; set; }
        public string x102C_SUB_LOB { get; set; }
        public string x102C_GROUP { get; set; }
        public string x102C_MARKET { get; set; }
        public string x102C_USER_HIERARCHY { get; set; }
        public string x102C_LANGUAGE_INDICATOR { get; set; }
        public string x102C_FED_RESERVE_CODE { get; set; }
        public string x102C_STATEMENT_TYPE_LIT { get; set; }
        public string x102C_STATEMENT_FREQ_LIT { get; set; }
        public string x102C_DDA_INTF_ACCOUNT_NUMB { get; set; }
        public string x102C_DDA_INTF_TRANSIT_NUMB { get; set; }
        public string x102C_PURGE_IND { get; set; }
        public string x102C_PURGE_IND_LIT { get; set; }
        public string x102C_ACH_CONSOLID_ATION { get; set; }
        public string x102C_ACH_CONSOL_LIT { get; set; }
        public string x102C_SPECIAL_TYPE_CODE { get; set; }
        public string x102C_SPEC_TYPE_LIT { get; set; }
        public string x102C_HISTORY_REVIEW_CODE { get; set; }
        public string x102C_HISTORY_REV_CODE_LIT { get; set; }
        public string x102C_HISTORY_REVIEW_FREQ { get; set; }
        public string x102C_HISTORY_REV_FREQ_LIT { get; set; }
        public string x102C_DATE_NEXT_HIST_REVIEW { get; set; }
        public decimal x102C_PRIMARY_DDA_ACCOUNT { get; set; }
        public decimal x102C_DDA_AMOUNT { get; set; }
        public string x102C_CL_USER_DATE_1 { get; set; }
        public string x102C_CL_USER_DATE_2 { get; set; }
        public string x102C_CL_USER_CODE_1 { get; set; }
        public string x102C_CL_USER_CODE_3 { get; set; }
        public string x102C_CL_USER_NUMERIC { get; set; }
        public decimal x102C_CL_USER_AMOUNT { get; set; }
        public string x102C_ORGID_1 { get; set; }
        public string x102C_ORGID_2 { get; set; }
        public string x102C_NAME_ADD_NUMBER { get; set; }
        public string x102C_NA_CR_BU_CD { get; set; }
        public string x102C_NAME { get; set; }
        public string x102C_GTS_BASE_NUMBER { get; set; }
        public string x102D_EXPOSURE_STRAT_CODE { get; set; }
        public decimal x102D_EXPOSURE_STRAT_AMT { get; set; }
        public string x102D_EXPOSURE_STRAT_DT { get; set; }
        public string x102D_CONTACT_TYPE { get; set; }
        public string x102D_CONTACT_NAME { get; set; }
        public string x102D_OBLIGOR_DESC_ONE { get; set; }
        public string x102D_OBLIGOR_DESC_TWO { get; set; }
        public string x102D_OBLIGOR_DESC_THREE { get; set; }
        public string x102D_AM_BEST_R_ATING { get; set; }
        public string x102D_AM_BEST_RATING_LIT { get; set; }
        public string x102D_AM_BEST_F_IN_SIZE_CAT { get; set; }
        public string x102D_AM_BEST_FIN_CAT_LIT { get; set; }
        public string x102D_STATE_CODE { get; set; }
        public string x102D_TAX_AUTHORTY_NUMBER { get; set; }
        public string x102D_COUNTY_CODE { get; set; }
        public string x102D_CHECK_OPT_ION { get; set; }
        public string x102D_TOWNSHIP_CODE { get; set; }
        public string x102D_DISB_TAPE_FORMAT { get; set; }
        public string x102D_INSTALLMENT_MONTH_1 { get; set; }
        public string x102D_INSTALL_MO_1 { get; set; }
        public string x102D_INSTALLMENT_MONTH_2 { get; set; }
        public string x102D_INSTALL_MO_2 { get; set; }
        public string x102D_INSTALLMENT_MONTH_3 { get; set; }
        public string x102D_INSTALL_MO_3 { get; set; }
        public string x102D_INSTALLMENT_MONTH_4 { get; set; }
        public string x102D_INSTALL_MO_4 { get; set; }
        public string x102D_DISBURSEMENT_FREQUENCY { get; set; }
        public string x102D_TAX_LIEN_SALES_MONTH { get; set; }
        public string x102D_TAX_LIEN_MONTH { get; set; }
        public string x102D_STI_NUMERIC_A { get; set; }
        public string x102D_STI_NUMERIC_B { get; set; }
        public string x102F_TYPE_OF_TIN_IND { get; set; }
        public string x102F_TYPE_OF_TIN_LIT { get; set; }
        public string x102F_TIN_CERTIFIC_ATION { get; set; }
        public string x102F_TIN_CERT_DAT_E { get; set; }
        public string x102F_TYPE_OF_ID_1 { get; set; }
        public string x102F_TYPE_1_LIT { get; set; }
        public string x102F_ID_1_NUMBER { get; set; }
        public string x102F_STATE_OF_ISSUANCE_1 { get; set; }
        public string x102F_ISSUANCE_DAT_E_1 { get; set; }
        public string x102F_COUNTRY_OF_ISSUANCE_1 { get; set; }
        public string x102F_EXPIRATION_D_ATE_1 { get; set; }
        public string x102F_TYPE_OF_ID_2 { get; set; }
        public string x102F_TYPE_2_LIT { get; set; }
        public string x102F_ID_2_NUMBER { get; set; }
        public string x102F_STATE_OF_ISSUANCE_2 { get; set; }
        public string x102F_ISSUANCE_DAT_E_2 { get; set; }
        public string x102F_COUNTRY_OF_ISSUANCE_2 { get; set; }
        public string x102F_EXPIRATION_D_ATE_2 { get; set; }
        public string x102F_TYPE_OF_ID_3 { get; set; }
        public string x102F_TYPE_3_LIT { get; set; }
        public string x102F_ID_3_NUMBER { get; set; }
        public string x102F_STATE_OF_ISSUANCE_3 { get; set; }
        public string x102F_ISSUANCE_DAT_E_3 { get; set; }
        public string x102F_COUNTRY_OF_ISSUANCE_3 { get; set; }
        public string x102F_EXPIRATION_D_ATE_3 { get; set; }
        public string x102G_STOCK_EXCHANGE { get; set; }
        public string x102G_STOCK_TICKER { get; set; }
        public string x102G_CUSIP_NUMBER { get; set; }
        public string L101_TIME_ZONE { get; set; }
        public string L101_TIME_ZONE_LIT { get; set; }
        public string L101_FAX_NUMBER { get; set; }
        public string L101_E_MAIL_ADDRESS { get; set; }
        public string L101_WEBSITE { get; set; }
        public decimal x110A_COLL_RECEIV_PLEDGED { get; set; }
        public decimal x110A_COLL_UNITS_PLEDGED { get; set; }
        public decimal x110A_COLL_RECEIV_ELIGIBLE { get; set; }
        public decimal x110A_COLL_UNITS_ELIGIBLE { get; set; }
        public decimal x110A_COLL_RECEIV_INELGIBLE { get; set; }
        public decimal x110A_COLL_UNITS_INELGIBLE { get; set; }
        public decimal x110A_COLL_CURR_VALUE { get; set; }
        public string x110A_COLL_LAST_ACTIVE_DATE { get; set; }
        public decimal x110A_COLL_NET_AMOUNT { get; set; }
        public string x110A_COLL_LAST_ITEM_NO { get; set; }
        public string x110A_COLL_TOTAL_ITEMS { get; set; }
        public decimal x110A_TOTAL_ALL_FUTURES { get; set; }
        public decimal x110A_TOTAL_ALL_UNUSED { get; set; }
        public decimal x110A_TOTAL_ALL_CURRENTS { get; set; }
        public decimal x110A_TOTAL_ALL_INTEREST_OUT { get; set; }
        public decimal x110A_TOTAL_ALL_INDIRECTS { get; set; }
        public decimal x110A_TOT_LATE_CHRG_DUE { get; set; }
        public decimal x110A_TOTAL_ALL_INSURANCE { get; set; }

    }
}
