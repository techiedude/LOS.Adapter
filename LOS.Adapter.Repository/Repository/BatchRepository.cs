using BatchServicesContext;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using Microsoft.HostIntegration.TI;
using System;

namespace LOS.Adapter.Data.Services.Repository
{
    /// <summary>
    /// Batch Repository for handling Batch operations
    /// </summary>
    public class BatchRepository : BaseRepository, IBatchRepository
    {

        public string LUW_HEADER_RESTRICTIONS = Constants.LUW_HEADER_RESTRICTIONS;
        private IBatchServices srv;

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRepository"/> class.
        /// </summary>
        public BatchRepository()
        {
            srv = new BatchServices();
        }

        /// <summary>
        /// Opens the batch.
        /// </summary>
        /// <param name="request">The request.</param>
        public void OpenBatch(OpenBatchCommand request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);

            OpenBatchInDocument doc = new OpenBatchInDocument
            {
                LUW_BANK = request.BankId,
                LUW_BATCH_ID = request.BatchID,
                LUW_ERROR_MESSAGES = request.Errors,
                LUW_HEADER_RESTRICTIONS = Constants.LUW_HEADER_REST_CALL_APPL,
                LUW_ID = request.Luw,
                LUW_ITEM_NBR = request.ItemNumber,
                LUW_LENGTH = request.DataLength,
                LUW_OBLIGATION = request.ObligationNumber,
                LUW_OBLIGOR = request.ObligorNumber,
                LUW_REQUEST_CODE = request.RestartRequestCode,
                SEG_COUNTER = request.Segment,
                x0970_COLLATERAL_UNITS = request.x0970_COLLATERAL_UNITS,
                x0970_CREDIT_TOTAL = request.x0970_CREDIT_TOTAL,
                x0970_DEBIT_TOTAL = request.x0970_DEBIT_TOTAL,
                x0970_ENTRY_DATE = request.x0970_ENTRY_DATE,
                x0970_NO_OF_TRANS = request.x0970_NO_OF_TRANS,
                x0970_NON_GL_TOTAL = request.x0970_NON_GL_TOTAL,
                x0970_ORIGIN_UNIT = request.x0970_ORIGIN_UNIT
            };

            try
            {
                srv.OpenBatch(ref doc.LUW_ID,
                                       ref doc.LUW_REQUEST_CODE,
                                       ref doc.LUW_BATCH_ID,
                                       ref doc.LUW_BANK,
                                       ref doc.LUW_OBLIGOR,
                                       ref doc.LUW_OBLIGATION,
                                       ref doc.LUW_ITEM_NBR,
                                       ref doc.SEG_COUNTER,
                                       ref LUW_HEADER_RESTRICTIONS,//doc.LUW_HEADER_RESTRICTIONS,
                                       ref doc.LUW_LENGTH,
                                       ref doc.LUW_ERROR_MESSAGES,
                                       ref doc.x0970_ORIGIN_UNIT,
                                       ref doc.x0970_ENTRY_DATE,
                                       ref doc.x0970_DEBIT_TOTAL,
                                       ref doc.x0970_CREDIT_TOTAL,
                                       ref doc.x0970_NON_GL_TOTAL,
                                       ref doc.x0970_COLLATERAL_UNITS,
                                       ref doc.x0970_NO_OF_TRANS,
                                       ref ctx);

                request.Errors = doc.LUW_ERROR_MESSAGES;

            }
            catch (CustomTIException Ex)
            {
                HandleHISException<OpenBatchCommand>(request, Ex, "OpenBatch");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                request.Errors = msg;
                throw;
            }
        }

        /// <summary>
        /// Closes the batch.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void CloseBatch()
        {
            throw new NotImplementedException();
        }



    }
}
