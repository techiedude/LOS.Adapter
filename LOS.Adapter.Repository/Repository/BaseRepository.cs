using InquiryServicesContext;
using LOS.Adapter.Data.Services.Query.Base;
using Microsoft.HostIntegration.TI;
using SunTrust.Wholesale.Commercial.Logging;
using System;

namespace LOS.Adapter.Data.Services.Repository
{
    /// <summary>
    /// Base Repository class for Host Integration connector data repository
    /// </summary>
    public abstract class BaseRepository
    {

        /// <summary>
        /// Gets the client context.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="pass">The pass.</param>
        /// <returns></returns>
        protected ClientContext GetClientContext(string user, string pass)
        {
            return new ClientContext { User = user, Password = pass, TransactionId = Constants.TRANSACTION_ID };
        }

        /// <summary>
        /// Handles Host Integration Server exception based on error codes
        /// Logs the exception message through the common logging mechanism and returns a new Response with error block
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Ex">The ex.</param>
        /// <param name="transactionName">Name of the transaction.</param>
        /// <returns></returns>
        protected T HandleHISException<T>(Microsoft.HostIntegration.TI.CustomTIException Ex, BaseRequest<T> request, string transactionName) where T : BaseResponse, new()
        {
            Func<string, T> HISExceptionHanlder = (message) =>
            {
                Logger.Log(this, LogLevel.Error, String.Format("Exception in invoking {0} through HIS:: {1}", transactionName, message), request);
                return new T() { Errors = message };
            };

            switch (Ex.TIExceptionMsgId)
            {
                case Constants.HIS_TRM_UNAUTH_ERROR:
                    return HISExceptionHanlder(Ex.Message);
                case Constants.HIS_INPT_BUFF_EXHAUST:
                    return HISExceptionHanlder(Ex.Message);
                case Constants.HIS_META_DATA_ERROR:
                    string msg = String.Format("CICS program returned an error. \nTI Runtime Error MsgID={0} \nError description=\"{1}\"", Ex.TIExceptionMsgId, Ex.Message);
                    return HISExceptionHanlder(msg);
                case Constants.HIS_DATA_CONVERT_ERR:
                    string compassErrMsg = GetCompassErrorMessage(request);
                    return HISExceptionHanlder(compassErrMsg);
                default:
                    string defaultmsg = String.Format("COMPASS Connection failed with TI Runtime Error MsgID {0}, description: \n{1}", Ex.TIExceptionMsgId, Ex.Message);
                    return HISExceptionHanlder(defaultmsg);
            }
        }

        /// <summary>
        /// Handles Host Integration Server exception based on error codes
        /// Logs the exception message through the common logging mechanism and returns in the error block
        /// for Command object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command">The command.</param>
        /// <param name="Ex">The ex.</param>
        /// <param name="transactionName">Name of the transaction.</param>
        protected void HandleHISException<T>(BaseCommand command, Microsoft.HostIntegration.TI.CustomTIException Ex, string transactionName) where T : BaseCommand
        {
            Action<string> HISExceptionHanlder = (message) =>
            {
                Logger.Log(this, LogLevel.Error, String.Format("Invoking {0} through HIS:: {1}", transactionName, message), command);
                command.Errors = message;
            };


            switch (Ex.TIExceptionMsgId)
            {
                case Constants.HIS_TRM_UNAUTH_ERROR:
                    HISExceptionHanlder(Ex.Message);
                    break;
                case Constants.HIS_INPT_BUFF_EXHAUST:
                    HISExceptionHanlder(Ex.Message);
                    break;
                case Constants.HIS_META_DATA_ERROR:
                    string msg = String.Format("CICS program returned an error. \nTI Runtime Error MsgID={0} \nError description=\"{1}\"", Ex.TIExceptionMsgId, Ex.Message);
                    HISExceptionHanlder(msg);
                    break;
                default:
                    string defaultmsg = String.Format("COMPASS Connection failed with TI Runtime Error MsgID {0}, description: \n{1}", Ex.TIExceptionMsgId, Ex.Message);
                    HISExceptionHanlder(defaultmsg);
                    break;
            }
        }


        /// <summary>
        /// Gets the compass error message.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        private string GetCompassErrorMessage<T>(BaseRequest<T> request) where T : BaseResponse
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            string excess = null;
            var getErrorMessageDocIn = new InquiryServicesContext.GetErrorMsgInDocument
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

                new InquiryServices().GetErrorMsg(ref getErrorMessageDocIn.LUW_ID,
                    ref getErrorMessageDocIn.LUW_REQUEST_CODE,
                    ref getErrorMessageDocIn.LUW_BATCH_ID,
                    ref getErrorMessageDocIn.LUW_BANK,
                    ref getErrorMessageDocIn.LUW_OBLIGOR,
                    ref getErrorMessageDocIn.LUW_OBLIGATION,
                    ref getErrorMessageDocIn.LUW_ITEM_NBR,
                    ref getErrorMessageDocIn.SEG_COUNTER,
                    ref getErrorMessageDocIn.LUW_HEADER_FILLER,
                    ref getErrorMessageDocIn.LUW_CALLING_APPL,
                    ref getErrorMessageDocIn.LUW_LENGTH,
                    ref errors,
                    out excess,
                    ref ctx);

                return errors;

            }

            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return Ex.Message;
            }
            catch (Exception ee)
            {
                return ee.Message;
            }
        }



    }
}
