using LEADServicesContext;
using LOS.Adapter.Data.Services.Query;
using Microsoft.HostIntegration.TI;
using System;
using System.Diagnostics;


namespace LOS.Adapter.Data.Services
{
    public class CompassRepository : ICompassRepository
    {
        ILEADServices lead;

        public CompassRepository()
        {
            lead = new LEADServices();
        }

        private ClientContext GetClientContext(string user, string pass)
        {
            return new ClientContext { User = user, Password = pass, TransactionId = Constants.TRANSACTION_ID };
        }


        public void GetCollateralIndicative()
        {
            throw new NotImplementedException();
        }

        public GetCollateralForObligorResponse GetCollateralForObligor(GetCollateralForObligorRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);

            string errors = null;
            string outputBlock = string.Empty;
            var getCollateralForDocIn = new LEADServicesContext.GetCollateralForObligorInDocument
            {
                LUW_BANK = request.BankId,
                LUW_BATCH_ID = request.BatchID,
                LUW_ERROR_MESSAGES = request.Errors,
                LUW_HEADER_RESTRICTIONS = request.Restrictions,
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
                lead.GetCollateralForObligor(ref getCollateralForDocIn.LUW_ID,
                    ref getCollateralForDocIn.LUW_REQUEST_CODE,
                    ref getCollateralForDocIn.LUW_BATCH_ID,
                    ref getCollateralForDocIn.LUW_BANK,
                    ref getCollateralForDocIn.LUW_OBLIGOR,
                    ref getCollateralForDocIn.LUW_OBLIGATION,
                    ref getCollateralForDocIn.LUW_ITEM_NBR,
                    ref getCollateralForDocIn.SEG_COUNTER,
                    ref getCollateralForDocIn.LUW_HEADER_RESTRICTIONS,
                    ref getCollateralForDocIn.LUW_LENGTH,
                    ref errors,
                    out outputBlock,
                    ref ctx);
                //lead.GetCollateralForObligor(ref luw, ref restartRequestCode, ref batchID, ref bankId, ref ObligorNumber, ref ObligationNumber, ref itemNumber, ref segment, ref restrictions, ref dataLength, ref errors, out outputBlock, ref ctx);
                return new GetCollateralForObligorResponse() { OutputField = outputBlock, Errors = errors };

            }

            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                if (Ex.TIExceptionMsgId == Constants.HIS_META_DATA_ERROR)
                    Trace.WriteLine(String.Format("CICS program returned an error. \nTI Runtime Error MsgID={0} \nError description=\"{1}\"", Ex.TIExceptionMsgId, Ex.Message));
                else
                    Trace.WriteLine(String.Format("COMPASS Connection failed with TI Runtime Error MsgID {0}, description: \n{1}", Ex.TIExceptionMsgId, Ex.Message));

                return null;
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }


        }

        public void UpdateObligor()
        {
            throw new NotImplementedException();
        }

        public void GetObligor()
        {
            throw new NotImplementedException();
        }

        public void GetAlternateNameAndAddress()
        {
            throw new NotImplementedException();
        }

        public void OpenBatch()
        {
            throw new NotImplementedException();
        }

        public void CloseBatch()
        {
            throw new NotImplementedException();
        }

        public void CreateAlternateNameAndAddress()
        {
            throw new NotImplementedException();
        }

        public void GetObligationNumber()
        {
            throw new NotImplementedException();
        }

        public void GetObligationSummary()
        {
            throw new NotImplementedException();
        }

        public void CreateObligor()
        {
            throw new NotImplementedException();
        }

        public void GetAccrualSchedules()
        {
            throw new NotImplementedException();
        }

        public void CreateCollateralTies()
        {
            throw new NotImplementedException();
        }

        public void CreateExceptionMessage()
        {
            throw new NotImplementedException();
        }

        public void GetBillingSchedules()
        {
            throw new NotImplementedException();
        }

        public void GetRepaymentSchedules()
        {
            throw new NotImplementedException();
        }

        public void GetObligorTicklers()
        {
            throw new NotImplementedException();
        }

        public void GetFutureTicklers()
        {
            throw new NotImplementedException();
        }

        public void GetCurrentTicklers()
        {
            throw new NotImplementedException();
        }

        public void GetPrimeSchedule()
        {
            throw new NotImplementedException();
        }

        public void GetParticipations()
        {
            throw new NotImplementedException();
        }

        public void GetObligation()
        {
            throw new NotImplementedException();
        }

        public void CreateSchedules()
        {
            throw new NotImplementedException();
        }

        public void UpdateELOC()
        {
            throw new NotImplementedException();
        }

        public void CreateObligorTickler()
        {
            throw new NotImplementedException();
        }

        public void CreateFutureTickler()
        {
            throw new NotImplementedException();
        }

        public void CreateCurrentTickler()
        {
            throw new NotImplementedException();
        }

        public void GetPrimeRate()
        {
            throw new NotImplementedException();
        }

        public void RenewCurrentNewObligation()
        {
            throw new NotImplementedException();
        }

        public void RenewCurrentSameObligation()
        {
            throw new NotImplementedException();
        }

        public void CreateFutureFeeSchedule()
        {
            throw new NotImplementedException();
        }

        public void CreateCollateral()
        {
            throw new NotImplementedException();
        }

        public void GetRenewalBalance()
        {
            throw new NotImplementedException();
        }

        public void CreateIndirectLiability()
        {
            throw new NotImplementedException();
        }

        public void GetIndirectLiabilities()
        {
            throw new NotImplementedException();
        }

        public void GetExceptionMessages()
        {
            throw new NotImplementedException();
        }

        public void GetBatchTransactionListing()
        {
            throw new NotImplementedException();
        }

        public void UpdateBatchTotals()
        {
            throw new NotImplementedException();
        }

        public void UpdateBatchTransactions()
        {
            throw new NotImplementedException();
        }

        public void CreateAccrualFeeSchedules()
        {
            throw new NotImplementedException();
        }

        public void CreateFutureObligation()
        {
            throw new NotImplementedException();
        }

        public void CreateELOC()
        {
            throw new NotImplementedException();
        }

        public void RenewFutureObligation()
        {
            throw new NotImplementedException();
        }
    }
}
