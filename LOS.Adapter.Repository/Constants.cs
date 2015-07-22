
namespace LOS.Adapter.Data.Services
{
    /// <summary>
    /// Constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The transaction_ identifier
        /// </summary>
        public static string TRANSACTION_ID = "LNLX";
        public static string LUW_HEADER_RESTRICTIONS = "POC";
        public static string LUW_HEADER_REST_CALL_APPL = string.Concat(new string(' ', 18), "NC");
        public static string LUW_HEADER_CALLING_APPL = "NC";

        #region HIS error codes
        public const string HIS_META_DATA_ERROR = "HISMAGB0007";
        public const string HIS_TRM_UNAUTH_ERROR = "HISMTTW0027";
        public const string HIS_INPT_BUFF_EXHAUST = "HISMAGB0002";
        public const string HIS_DATA_CONVERT_ERR = "HISMAGB0042";
        #endregion

        /// <summary>
        /// 1192 Restart code
        /// </summary>
        public const string CREATE_COLL_TIE_REQCODE_1192 = "1192";
        /// <summary>
        /// 1392 Restart code
        /// </summary>
        public const string CREATE_COLL_TIE_REQCODE_1392 = "1392";


        #region Counts
        /// <summary>
        /// The Create Collateral Tie Items - 1192/1392
        /// </summary>
        public const int CREATE_COLL_TIE_ITEMS_COUNT = 10;
        /// <summary>
        /// The Create Alt Name Address Item Count - 23
        /// </summary>
        public const int CREATE_ALT_NAME_ADDRESS_COUNT = 23;

        /// <summary>
        /// The CreateCurrentFeeSchedule -1375 field count- 20
        /// </summary>
        public const int CREATE_CURR_FEE_SCHEDULE_COUNT = 20;

        public const int GET_COLL_SUPPORTING_COUNT = 162;
        #endregion

        #region LUW Transaction List

        //LUW TRANSACTIONS
        /// <summary>
        /// L001 - CreateObligor
        /// </summary>
        public readonly static string CREATE_OBLGR_LUW_ID = "L001";
        /// <summary>
        /// L002 - Create Alternate Name/Address
        /// </summary>
        public readonly static string CREATE_ALT_NAME_ADD_LUW_ID = "L002";
        /// <summary>
        /// L003 - Assign Obligation #
        /// </summary>
        public readonly static string ASSIGN_OBLGN_NUM_LUW_ID = "L003";
        /// <summary>
        /// L004 - Create Future
        /// </summary>
        public readonly static string CREATE_FUT_LUW_ID = "L004";
        /// <summary>
        /// L005 - Create Current
        /// </summary>
        public readonly static string CREATE_CUR_LUW_ID = "L005";
        /// <summary>
        /// L006 - Create ELOC
        /// </summary>
        public readonly static string CREATE_ELOC_LUW_ID = "L006";
        /// <summary>
        /// L007 - Create Current/ELOC Schedule
        /// </summary>
        public readonly static string CREATE_ELOC_SCH_LUW_ID = "L007";
        /// <summary>
        /// L008 - Create Future Fee Schedule
        /// </summary>
        public readonly static string CREATE_FUT_FEE_SCH_LUW_ID = "L008";
        /// <summary>
        /// L009 - Create Current Fee Schedule
        /// </summary>
        public readonly static string CREATE_CUR_FEE_SCH_LUW_ID = "L009";
        /// <summary>
        /// L010 - Create Collateral
        /// </summary>
        public readonly static string CREATE_COLL_LUW_ID = "L010";
        /// <summary>
        /// L011 - Create Indirect
        /// </summary>
        public readonly static string CREATE_IND_LUW_ID = "L011";
        /// <summary>
        /// L012 - Create Collateral Tie
        /// </summary>
        public readonly static string CREATE_COLL_TIE_LUW_ID = "L012";
        /// <summary>
        /// L015 - Update Obligor Indicative
        /// </summary>
        public readonly static string UPDATE_OBLGR_IND_LUW_ID = "L015";
        /// <summary>
        /// L016 - Renew Future
        /// </summary>
        public readonly static string RENEW_FUT_LUW_ID = "L016";
        /// <summary>
        /// L017 - Renew Current
        /// </summary>
        public readonly static string RENEW_CUR_LUW_ID = "L017";
        /// <summary>
        /// L018 - Renew ELOC
        /// </summary>
        public readonly static string RENEW_ELOC_LUW_ID = "L018";
        /// <summary>
        /// L019 - Get Obligor
        /// </summary>
        public readonly static string GET_OBLGR_LUW_ID = "L019";
        /// <summary>
        /// L020 - Get Obligor Obligation Summary
        /// </summary>
        public readonly static string GET_OBLGN_SUMM_LUW_ID = "L020";
        /// <summary>
        /// L021 - Get Alternate Name/Address
        /// </summary>
        public readonly static string GET_ALT_NAME_ADD_LUW_ID = "L021";
        /// <summary>
        /// L022 - Get Obligation
        /// </summary>
        public readonly static string GET_OBLGN_LUW_ID = "L022";
        /// <summary>
        /// L023 - Get Renewal Balance
        /// </summary>
        public readonly static string GET_REN_BAL_LUW_ID = "L023";
        /// <summary>
        /// L024 - Get Accrual Schedules
        /// </summary>
        public readonly static string GET_ACC_SCH_LUW_ID = "L024";
        /// <summary>
        /// L025 - Get Billing Schedules
        /// </summary>
        public readonly static string GET_BILL_SCH_LUW_ID = "L025";
        /// <summary>
        /// L026 - Get Principle Repay Schedules
        /// </summary>
        public readonly static string GET_PRN_RPAY_SCH_LUW_ID = "L026";
        /// <summary>
        /// L027 - Get Prime Schedules
        /// </summary>
        public readonly static string GET_PRM_SCH_LUW_ID = "L027";
        /// <summary>
        /// L028 - Get Participation
        /// </summary>
        public readonly static string GET_PRTCPN_LUW_ID = "L028";
        /// <summary>
        /// L029 - Get Indirect
        /// </summary>
        public readonly static string GET_INDIR_LUW_ID = "L029";
        /// <summary>
        /// L031 - Get Collateral Indicative
        /// </summary>
        public readonly static string GET_COLL_IND_LUW_ID = "L031";
        /// <summary>
        /// L032 - Get Collateral Ties
        /// </summary>
        public readonly static string GET_COLL_TIE_LUW_ID = "L032";
        /// <summary>
        /// L033 - Get Collateral Obligor Level
        /// </summary>
        public readonly static string GET_COLL_OBLGR_LUW_ID = "L033";
        /// <summary>
        /// s033 - Get Collateral Obligor Level - Requery for more data
        /// </summary>
        public readonly static string GET_COLL_OBLGR_REQUERY_LUW_ID = "S033";
        /// <summary>
        /// L034 - Open Batch
        /// </summary>
        public readonly static string OPN_BATCH_LUW_ID = "L034";
        /// <summary>
        /// L037 - Get Prime Rate
        /// </summary>
        public readonly static string GET_PRM_RATE_LUW_ID = "L037";
        /// <summary>
        /// L038 - Create Accruing Fee Schedule
        /// </summary>
        public readonly static string CREATE_ACC_FEE_SCH_LUW_ID = "L038";

        /// <summary>
        /// L044 - Get Current/Future Obligation Headers
        /// </summary>
        public readonly static string GET_OBLGN_HEADERS_LUW_ID = "L044";
        #endregion


    }


}
