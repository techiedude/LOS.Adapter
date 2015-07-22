
using LOS.Adapter.Data.Services.Query.Base;
using System.Collections.Generic;

namespace LOS.Adapter.Data.Services.Query
{
    /// <summary>
    /// IB - LNIQ121 - Get Obligation Headers Request
    /// </summary>
    public class GetObligationHeadersRequest : BaseRequest<GetObligationHeadersResponse>
    {

        public GetObligationHeadersRequest(string user, string pass, string bankId, string obligorNumber, string batchid, string obligationNumber, string segment, string restriction, string dataLength, string itemNumber, string luw, string restartRequestCode)
            : base(user, pass, luw, bankId, obligorNumber, batchid, obligationNumber, segment, restriction, dataLength, itemNumber, restartRequestCode)
        {

        }


    }

    /// <summary>
    /// 
    /// </summary>
    public class GetObligationHeadersResponse : BaseResponse
    {
        public string X121A_TITLE_CURR_DATE { get; set; }
        public short X121A_ENTRIES_IN_USE { get; set; }
        public IList<HeaderInfo> HeaderInfoList { get; set; }

    }


    /// <summary>
    /// 
    /// </summary>
    public struct HeaderInfo
    {
        public string X121A_AS_BAL_TYPE { get; set; }
        public string X121A_AS_BAL_TYPE_LIT { get; set; }
        public string X121A_AS_BASIS { get; set; }
        public string X121A_AS_BASIS_LIT { get; set; }
        public string X121A_AS_EARN_TYPE { get; set; }
        public string X121A_AS_EARN_TYPE_LIT { get; set; }
        public decimal X121A_AS_FM_TIER { get; set; }
        public string X121A_AS_FROM_DT { get; set; }
        public string X121A_AS_MEMO { get; set; }
        public string X121A_AS_MEMO_LIT { get; set; }
        public decimal X121A_AS_RATE { get; set; }
        public string X121A_AS_TAX_CODE { get; set; }
        public string X121A_AS_TAX_CODE_LIT { get; set; }
        public string X121A_AS_TO_DT { get; set; }
        public decimal X121A_AS_TO_TIER { get; set; }
        public string X121A_BS_ACCR_TO { get; set; }
        public string X121A_BS_BILL_DT { get; set; }
        public string X121A_BS_BILL_PERIOD { get; set; }
        public string X121A_BS_BILL_PERIOD_LIT { get; set; }
        public string X121A_BS_COLL_METH { get; set; }
        public string X121A_BS_COLL_METH_LIT { get; set; }
        public string X121A_BS_CUST_BILL { get; set; }
        public string X121A_BS_CUST_BILL_LIT { get; set; }
        public string X121A_BS_DDA { get; set; }
        public string X121A_BS_DUE_DT { get; set; }
        public string X121A_BS_EXT_TYPE { get; set; }
        public string X121A_BS_EXTEND_IND { get; set; }
        public string X121A_BS_FROM_DT { get; set; }
        public string X121A_BS_GRACE_PERIOD { get; set; }
        public string X121A_BS_LEAD_DAYS { get; set; }
        public string X121A_BS_MAT_COLL_METH { get; set; }
        public string X121A_BS_MAT_COLL_METH_LIT { get; set; }
        public string X121A_BS_PRIORITY_CD { get; set; }
        public string X121A_BS_REPAY_TP { get; set; }
        public string X121A_BS_REPAY_TP_LIT { get; set; }
        public string X121A_BS_SPEC_MAIL { get; set; }
        public string X121A_BS_TO_DT { get; set; }
        public string X121A_BS_TRANS_ID { get; set; }
        public string X121A_FILLER_2 { get; set; }
        public string X121A_FILLER_2_A { get; set; }
        public string X121A_FILLER_2_B { get; set; }
        public string X121A_FILLER_2_C { get; set; }
        public string X121A_FILLER_3 { get; set; }
        public string X121A_FILLER_3_A { get; set; }
        public string X121A_FILLER_3_B { get; set; }
        public string X121A_FILLER_3_B2 { get; set; }
        public string X121A_FILLER_3_B3 { get; set; }
        public string X121A_FILLER_3_D { get; set; }
        public string X121A_HDG_CHG_CODE { get; set; }
        public string X121A_HDR_TYPE_LITERAL { get; set; }
        public string X121A_PS_ALT_CAL_IND { get; set; }
        public string X121A_PS_ALT_CAL_LIT { get; set; }
        public string X121A_PS_ANNV_DT { get; set; }
        public string X121A_PS_BREAKAGE { get; set; }
        public decimal X121A_PS_CEILING { get; set; }
        public string X121A_PS_CHG_DAY { get; set; }
        public string X121A_PS_CHG_DAY_LIT_1 { get; set; }
        public string X121A_PS_CHG_DAY_LIT_2 { get; set; }
        public string X121A_PS_FACTOR1 { get; set; }
        public string X121A_PS_FACTOR1_LIT { get; set; }
        public string X121A_PS_FACTOR2 { get; set; }
        public string X121A_PS_FACTOR2_LIT { get; set; }
        public decimal X121A_PS_FLOOR { get; set; }
        public string X121A_PS_FROM_DT { get; set; }
        public string X121A_PS_MOD_BUS { get; set; }
        public string X121A_PS_NBR_MNTHS { get; set; }
        public string X121A_PS_PRIME { get; set; }
        public string X121A_PS_RELAT1 { get; set; }
        public string X121A_PS_RELAT2 { get; set; }
        public string X121A_PS_REPOSITION { get; set; }
        public string X121A_PS_TO_DT { get; set; }
        public string X121A_TAX_IMA_LIT { get; set; }
        public string X121B_DEFERRED_LITERAL { get; set; }
        public string X121B_FILLER_01 { get; set; }
        public string X121B_FILLER_23 { get; set; }
        public decimal X121B_INT_ADJ_MTD_NOT_THIS_MO { get; set; }
        public decimal X121B_INT_ADJ_YTD_NOT_THIS_YR { get; set; }
        public decimal X121B_INT_CHRG_OFF { get; set; }
        public decimal X121B_INT_ERND_IN_SUSPENSE_MTD { get; set; }
        public decimal X121B_INT_ERND_IN_SUSPENSE_YTD { get; set; }
        public string X121B_INT_HDR_PREV_ACCR_TO_DTE { get; set; }
        public decimal X121B_INTEREST_ACC_ROUND { get; set; }
        public string X121B_INTEREST_ACCRUAL_DATE { get; set; }
        public decimal X121B_INTEREST_ADJ_EARN_BTD { get; set; }
        public decimal X121B_INTEREST_ADJ_TO_ITD_DECR { get; set; }
        public decimal X121B_INTEREST_ADJ_TO_ITD_INCR { get; set; }
        public decimal X121B_INTEREST_BIL_ROUND { get; set; }
        public decimal X121B_INTEREST_BILL_NOT_REC { get; set; }
        public decimal X121B_INTEREST_DAILY_EARNS { get; set; }
        public string X121B_INTEREST_DATE_PAID_TO { get; set; }
        public string X121B_INTEREST_DEF_EARN_DT { get; set; }
        public decimal X121B_INTEREST_DEFER_INCOME { get; set; }
        public decimal X121B_INTEREST_EARNED_BTD { get; set; }
        public decimal X121B_INTEREST_EARNED_ITD { get; set; }
        public decimal X121B_INTEREST_EARNED_MTD { get; set; }
        public decimal X121B_INTEREST_EARNED_YTD { get; set; }
        public decimal X121B_INTEREST_ERD_SUSPENSE { get; set; }
        public string X121B_INTEREST_LAST_BILL_DT { get; set; }
        public decimal X121B_INTEREST_PAID_ITD { get; set; }
        public decimal X121B_INTEREST_PAID_MTD { get; set; }
        public decimal X121B_INTEREST_PAID_SUSPENS { get; set; }
        public decimal X121B_INTEREST_PAID_TO_PRIN { get; set; }
        public decimal X121B_INTEREST_PAID_YTD { get; set; }
        public decimal X121B_INTEREST_PAST_DUE { get; set; }
        public short X121B_INTEREST_PAST_DUE_STS { get; set; }
        public decimal X121B_INTEREST_PD_PRIOR_YR { get; set; }
        public string X121B_INTEREST_PREV_DUE_DAT { get; set; }
        public decimal X121B_INTEREST_START_BAL { get; set; }
        public decimal X121B_NEGATIVE_AMORT_AMOUNT { get; set; }
        public decimal X121B_NON_ACCRL_PD_INCOME { get; set; }
        public decimal X121B_ORIG_SUSPEN_AMOUNT { get; set; }
        public string X121B_PAST_DUE_LIT { get; set; }
        public decimal X121B_RECEIVABLE { get; set; }
        public string X121D_ADD_ON_EARN_DATE { get; set; }
        public decimal X121D_ANTICIP_ERNGS { get; set; }
        public string X121D_APR_EXCL_IND { get; set; }
        public string X121D_APR_EXCL_IND_LIT { get; set; }
        public string X121D_CLOSE_ADJ_TYPE { get; set; }
        public string X121D_CLOSE_ADJ_TYPE_LIT { get; set; }
        public short X121D_DELAY_DAYS { get; set; }
        public string X121D_EARNINGS_LIT { get; set; }
        public string X121D_FIELD_NAME { get; set; }
        public string X121D_FIELD_NAME_2 { get; set; }
        public decimal X121D_FINAL_CLOSE_ADJ { get; set; }
        public string X121D_HDR_POINTER_TYPE { get; set; }
        public string X121D_HDR_POINTER_TYPE_LIT { get; set; }
        public decimal X121D_INT_CAPITALI_ZED { get; set; }
        public decimal X121D_INT_METHOD_DEFERRED { get; set; }
        public decimal X121D_INT_PITD_NOT_RECOG { get; set; }
        public decimal X121D_INTEREST_ORIG_DISC { get; set; }
        public int X121D_INTEREST_ORIG_TERM { get; set; }
        public decimal X121D_INTEREST_PD_NOT_REPORTED { get; set; }
        public decimal X121D_INTEREST_PD_REPORTED { get; set; }
        public decimal X121D_INTEREST_REBATE_DSBUR { get; set; }
        public int X121D_INTEREST_REMAIN_TERM { get; set; }
        public decimal X121D_INTEREST_W_AIVED_MTD { get; set; }
        public decimal X121D_INTEREST_W_AIVED_YTD { get; set; }
        public decimal X121D_INTEREST_WAIVED { get; set; }
        public decimal X121D_MIN_EARN_AMOUNT { get; set; }
        public decimal X121D_MIN_EARN_CLOSE_AMT { get; set; }
        public string X121D_MIN_EARN_DAY { get; set; }
        public string X121D_MIN_EARN_DAY_LIT { get; set; }
        public string X121D_MIN_EARN_OVERRIDE { get; set; }
        public string X121D_MIN_EARN_OVERRIDE_LIT { get; set; }
        public decimal X121D_MIN_RBTE_AMOUNT { get; set; }
        public string X121D_MIN_RBTE_CHG_CD_IND { get; set; }
        public string X121D_MIN_RBTE_CHG_CD_IND_LIT { get; set; }
        public string X121D_MIN_RBTE_CODE { get; set; }
        public string X121D_MIN_RBTE_OVERRIDE { get; set; }
        public string X121D_MIN_RBTE_OVERRIDE_LIT { get; set; }
        public decimal X121D_NET_ACTIVITY_TODAY { get; set; }
        public string X121D_NEXT_REPRICE_DATE { get; set; }
        public int X121D_REBATE_BASE_RATE { get; set; }
        public string X121D_REBATE_IND { get; set; }
        public string X121D_REBATE_IND_LIT { get; set; }
        public string X121D_REBATE_METHOD { get; set; }
        public string X121D_REBATE_METHOD_LIT { get; set; }
        public decimal X121D_UNACCR_MIN_EARN { get; set; }
        public decimal X121F_ASSESSED_ITD { get; set; }
        public decimal X121F_ASSESSED_MTD { get; set; }
        public decimal X121F_ASSESSED_YTD { get; set; }
        public string X121F_DATA_PRESENT_SW { get; set; }
        public string X121F_DATE_LST_ASSESS { get; set; }
        public decimal X121F_EDF_CHARGE { get; set; }
        public string X121F_EDF_LMT_CODE { get; set; }
        public string X121F_EDF_LMT_CODE_LITERAL { get; set; }
        public string X121F_EDF_METHOD { get; set; }
        public string X121F_EDF_METHOD_LITERAL { get; set; }
        public string X121F_EVENT_TYPE { get; set; }
        public string X121F_EVENT_TYPE_LITERAL { get; set; }
        public string X121F_MAX_ASSESS { get; set; }
        public string X121F_MIN_ASSESS { get; set; }
        public string X121F_NXT_ASSESS_DATE { get; set; }
        public int X121F_OCCURS_CHARGE { get; set; }
        public short X121F_PERIOD { get; set; }
        public string X121F_PERIOD_LITERAL { get; set; }


    }

}
