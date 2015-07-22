using LOS.Adapter.Data.Services.Extensions;
using LOS.Adapter.Data.Services.Interface;
using Microsoft.HostIntegration.TI;
using ObligationServicesContext;
using System;


namespace LOS.Adapter.Data.Services.Repository
{
    /// <summary>
    /// Obligation Repository for handling Obligation operations
    /// </summary>
    public class ObligationRepository : BaseRepository, IObligationRepository
    {

        private IObligation srv;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObligationRepository"/> class.
        /// </summary>
        public ObligationRepository()
        {
            srv = new Obligation();
        }


        /// <summary>
        /// Assigns the obligation number.
        /// </summary>
        /// <param name="request">The request.</param>
        public void AssignObligationNumber(AssignObligationNumberCommand request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);

            AssignObligationNumberInDocument doc = new AssignObligationNumberInDocument
            {
                LUW_BANK = request.BankId,
                LUW_BATCH_ID = request.BatchID,
                LUW_ERROR_MESSAGES = request.Errors,
                LUW_HEADER_FILLER = string.Empty,
                LUW_CALLING_APPL = Constants.LUW_HEADER_CALLING_APPL,
                LUW_ID = request.Luw,
                LUW_ITEM_NBR = request.ItemNumber,
                LUW_LENGTH = request.DataLength,
                LUW_OBLIGATION = request.ObligationNumber,
                LUW_OBLIGOR = request.ObligorNumber,
                LUW_REQUEST_CODE = request.RestartRequestCode,
                SEG_COUNTER = request.Segment
            };
            try
            {
                srv.AssignObligationNumber(ref doc.LUW_ID,
                                    ref doc.LUW_REQUEST_CODE,
                                    ref doc.LUW_BATCH_ID,
                                    ref doc.LUW_BANK,
                                    ref doc.LUW_OBLIGOR,
                                    ref doc.LUW_OBLIGATION,
                                    ref doc.LUW_ITEM_NBR,
                                    ref doc.SEG_COUNTER,
                                    ref doc.LUW_HEADER_FILLER,
                                    ref doc.LUW_CALLING_APPL,
                                    ref doc.LUW_LENGTH,
                                    ref doc.LUW_ERROR_MESSAGES,
                                    ref ctx);

                request.Errors = doc.LUW_ERROR_MESSAGES;
                request.ObligorNumber = doc.LUW_OBLIGOR;
                request.ObligationNumber = doc.LUW_OBLIGATION;

            }
            catch (CustomTIException Ex)
            {
                HandleHISException<AssignObligationNumberCommand>(request, Ex, "AssignObligationNumber");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                request.Errors = msg;
                throw;
            }
        }


        /// <summary>
        /// Creates the current fee schedule.
        /// </summary>
        /// <param name="request">The request.</param>
        public void CreateCurrentFeeSchedule(CreateCurrentFeeScheduleCommand request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);

            //check for specific counts
            if (!request.AccuralFeeBillSchedules.IsNullOrEmpty<REQUEST_1375_FEE_SCHEDULE>())
            {
                request.AccuralFeeBillSchedules.AddOrTrimExcess<REQUEST_1375_FEE_SCHEDULE>(Constants.CREATE_CURR_FEE_SCHEDULE_COUNT);
            }


            var get1375Fields = Array.ConvertAll<REQUEST_1375_FEE_SCHEDULE, ObligationServicesContext.x1375_FEES>(request.AccuralFeeBillSchedules.ToArray(), delegate(REQUEST_1375_FEE_SCHEDULE output)
            {
                var get1375Field = new x1375_FEES()
                {
                    x1375_ACCRUAL_SCHD_CHARGE_CODE = output.x1375_ACCRUAL_SCHD_CHARGE_CODE,
                    x1375_ACCRUAL_SCHD_EFFECT_FROM = output.x1375_ACCRUAL_SCHD_EFFECT_FROM,
                    x1375_ACCRUAL_SCHD_EFFECT_TO_DT = output.x1375_ACCRUAL_SCHD_EFFECT_TO_DT,
                    x1375_ACCRUAL_SCHD_BASIS = output.x1375_ACCRUAL_SCHD_BASIS,
                    x1375_ACCRUAL_SCHD_MEMO_ITEM = output.x1375_ACCRUAL_SCHD_MEMO_ITEM,
                    x1375_ACCRUAL_SCHD_EARN_TYPE = output.x1375_ACCRUAL_SCHD_EARN_TYPE,
                    x1375_ACCRUAL_SCHD_FM_TIER_AMT = output.x1375_ACCRUAL_SCHD_FM_TIER_AMT,
                    x1375_ACCRUAL_SCHD_IMA_IND = output.x1375_ACCRUAL_SCHD_IMA_IND,
                    x1375_BILLING_SCHD_BILL_PERIOD = output.x1375_BILLING_SCHD_BILL_PERIOD,
                    x1375_BILLING_SCHD_BILL_DATE = output.x1375_BILLING_SCHD_BILL_DATE,
                    x1375_BILLING_SCHD_LEAD_DAYS = output.x1375_BILLING_SCHD_LEAD_DAYS,
                    x1375_BILLING_SCHD_DUE_DATE = output.x1375_BILLING_SCHD_DUE_DATE,
                    x1375_BILLING_SCHD_METHOD_COLL = output.x1375_BILLING_SCHD_METHOD_COLL,
                    x1375_BILLING_SCHD_CHARGE_ACCT = output.x1375_BILLING_SCHD_CHARGE_ACCT,
                    x1375_BILLING_SCHD_SPECIAL_MAIL = output.x1375_BILLING_SCHD_SPECIAL_MAIL,
                    x1375_BILLING_SCHD_TRANSIT_NR = output.x1375_BILLING_SCHD_TRANSIT_NR,
                    x1375_BILLING_SCHD_MATURITY_MOC = output.x1375_BILLING_SCHD_MATURITY_MOC

                };

                return get1375Field;
            });

            CreateCurrentFeeScheduleInDocument doc = new CreateCurrentFeeScheduleInDocument
             {
                 LUW_BANK = request.BankId,
                 LUW_BATCH_ID = request.BatchID,
                 LUW_ERROR_MESSAGES = request.Errors,
                 LUW_HEADER_FILLER = string.Empty,
                 LUW_CALLING_APPL = Constants.LUW_HEADER_CALLING_APPL,
                 LUW_ID = request.Luw,
                 LUW_ITEM_NBR = request.ItemNumber,
                 LUW_LENGTH = request.DataLength,
                 LUW_OBLIGATION = request.ObligationNumber,
                 LUW_OBLIGOR = request.ObligorNumber,
                 LUW_REQUEST_CODE = request.RestartRequestCode,
                 SEG_COUNTER = request.Segment,
                 x1375_FEES = get1375Fields
             };

            try
            {
                srv.CreateCurrentFeeSchedule(ref doc.LUW_ID,
                                    ref doc.LUW_REQUEST_CODE,
                                    ref doc.LUW_BATCH_ID,
                                    ref doc.LUW_BANK,
                                    ref doc.LUW_OBLIGOR,
                                    ref doc.LUW_OBLIGATION,
                                    ref doc.LUW_ITEM_NBR,
                                    ref doc.SEG_COUNTER,
                                    ref doc.LUW_HEADER_FILLER,
                                    ref doc.LUW_CALLING_APPL,
                                    ref doc.LUW_LENGTH,
                                    ref doc.LUW_ERROR_MESSAGES,
                                    ref doc.x1375_FEES,
                                    ref ctx);

                request.Errors = doc.LUW_ERROR_MESSAGES;
                //Note: Need to check if there are any other fields that need to be mapped back to the request
                //object for further operation

            }
            catch (CustomTIException Ex)
            {
                HandleHISException<CreateCurrentFeeScheduleCommand>(request, Ex, "CreateCurrentFeeScheduleCommand");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                request.Errors = msg;
                throw;
            }
        }




    }
}
