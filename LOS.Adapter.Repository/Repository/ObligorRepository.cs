using LOS.Adapter.Data.Services.Extensions;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using Microsoft.HostIntegration.TI;
using ObligorServicesContext;
using SunTrust.Wholesale.Commercial.Logging;
using System;
using System.Diagnostics;

namespace LOS.Adapter.Data.Services.Repository
{
    /// <summary>
    /// Obligor Repository for handling Obligor based operations
    /// </summary>
    public class ObligorRepository : BaseRepository, IObligorRepository
    {
        private IObligorServices srv;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObligorRepository"/> class.
        /// </summary>
        public ObligorRepository()
        {
            srv = new ObligorServices();
        }
        /// <summary>
        /// Creates the obligor.
        /// </summary>
        /// <param name="request">The request.</param>
        public void CreateObligor(CreateObligorCommand request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);

            CreateObligorInDocument doc = new CreateObligorInDocument
            {
                LUW_BANK = request.BankId,
                LUW_BATCH_ID = request.BatchID,
                LUW_ERROR_MESSAGES = request.Errors,
                LUW_HEADER_RESTRICTIONS = request.HeaderRestrictions,
                LUW_ID = request.Luw,
                LUW_ITEM_NBR = request.ItemNumber,
                LUW_LENGTH = request.DataLength,
                LUW_OBLIGATION = request.ObligationNumber,
                LUW_OBLIGOR = request.ObligorNumber,
                LUW_REQUEST_CODE = request.RestartRequestCode,
                SEG_COUNTER = request.Segment,
                X1001_CUSTOMER_GREETING = request.X1001_CUSTOMER_GREETING,
                X1001_CUSTOMER_NAME = request.X1001_CUSTOMER_NAME,
                X1001_CUSTOMER_NAME_CONT = request.X1001_CUSTOMER_NAME_CONT,
                X1001_BIRTH_INC_DATE = request.X1001_BIRTH_INC_DATE,
                X1001_SOCIAL_SECURITY = request.X1001_SOCIAL_SECURITY,
                X1001_TAXID = request.X1001_TAXID,
                X1001_ADDRESS_LINE_ONE = request.X1001_ADDRESS_LINE_ONE,
                X1001_ADDRESS_LINE_TWO = request.X1001_ADDRESS_LINE_TWO,
                X1001_ADDRESS_LINE_THREE = request.X1001_ADDRESS_LINE_THREE,
                X1001_ADDRESS_LINE_FOUR = request.X1001_ADDRESS_LINE_FOUR,
                X1001_ADDRESS_LINE_FIVE = request.X1001_ADDRESS_LINE_FIVE,
                X1001_ADDRESS_LINE_SIX = request.X1001_ADDRESS_LINE_SIX,
                X1001_CITY = request.X1001_CITY,
                X1001_STATE_PROVINCE = request.X1001_STATE_PROVINCE,
                X1001_ZIP_CODE = request.X1001_ZIP_CODE,
                X1001_BUSINESS_AREA_CODE = request.X1001_BUSINESS_AREA_CODE,
                X1001_BUSINESS_PHONE_NUMBER = request.X1001_BUSINESS_PHONE_NUMBER,
                X1001_BUSINESS_EXTENSION = request.X1001_BUSINESS_EXTENSION,
                X1001_RESIDENT_AREA_CODE = request.X1001_RESIDENT_AREA_CODE,
                X1001_RESIDENT_PHONE_NUMBER = request.X1001_RESIDENT_PHONE_NUMBER,
                X1001_RESIDENT_EXTENSION = request.X1001_RESIDENT_EXTENSION,
                X1001_TIME_ZONE = request.X1001_TIME_ZONE,
                X1001_CONTACT_DATE = request.X1001_CONTACT_DATE,
                X1001_FOUND_ON_CRF = request.X1001_FOUND_ON_CRF,
                X1035_NAICS_CODE = request.X1035_NAICS_CODE,
                X1040_ASSIGNMENT_UNIT = request.X1040_ASSIGNMENT_UNIT,
                X1040_CONTACT_OFFICER = request.X1040_CONTACT_OFFICER,
                X1040_SERVICE_UNIT = request.X1040_SERVICE_UNIT,
                X1040_SIC_CODE = request.X1040_SIC_CODE,
                X1043_COUNTRY_OF_ISSUE = request.X1043_COUNTRY_OF_ISSUE,
                X1043_EXPIRATION_DATE = request.X1043_EXPIRATION_DATE,
                X1043_ID_NUMBER_1 = request.X1043_ID_NUMBER_1,
                X1043_ID_NUMBER_2 = request.X1043_ID_NUMBER_2,
                X1043_ID_NUMBER_3 = request.X1043_ID_NUMBER_3,
                X1043_ISSUANCE_DATE = request.X1043_ISSUANCE_DATE,
                X1043_STATE_OF_ISSUE = request.X1043_STATE_OF_ISSUE,
                X1043_TYPE_ID = request.X1043_TYPE_ID,
                X1043_TYPE_TIN_IND = request.X1043_TYPE_TIN_IND
            };

            try
            {
                srv.CreateObligor(ref doc.LUW_ID,
                                    ref doc.LUW_REQUEST_CODE,
                                    ref doc.LUW_BATCH_ID,
                                    ref doc.LUW_BANK,
                                    ref doc.LUW_OBLIGOR,
                                    ref doc.LUW_OBLIGATION,
                                    ref doc.LUW_ITEM_NBR,
                                    ref doc.SEG_COUNTER,
                                    ref Constants.LUW_HEADER_REST_CALL_APPL,
                                    ref doc.LUW_LENGTH,
                                    ref doc.LUW_ERROR_MESSAGES,
                                    ref doc.X1001_CUSTOMER_NAME,
                                    ref doc.X1001_CUSTOMER_GREETING,
                                    ref doc.X1001_CUSTOMER_NAME_CONT,
                                    ref doc.X1001_TAXID,
                                    ref doc.X1001_ADDRESS_LINE_ONE,
                                    ref doc.X1001_SOCIAL_SECURITY,
                                    ref doc.X1001_ADDRESS_LINE_TWO,
                                    ref doc.X1001_CONTACT_DATE,
                                    ref doc.X1001_ADDRESS_LINE_THREE,
                                    ref doc.X1001_RESIDENT_AREA_CODE,
                                    ref doc.X1001_RESIDENT_PHONE_NUMBER,
                                    ref doc.X1001_ADDRESS_LINE_FOUR,
                                    ref doc.X1001_RESIDENT_EXTENSION,
                                    ref doc.X1001_ADDRESS_LINE_FIVE,
                                    ref doc.X1001_BUSINESS_AREA_CODE,
                                    ref doc.X1001_BUSINESS_PHONE_NUMBER,
                                    ref doc.X1001_ADDRESS_LINE_SIX,
                                    ref doc.X1001_BUSINESS_EXTENSION,
                                    ref doc.X1001_CITY,
                                    ref doc.X1001_STATE_PROVINCE,
                                    ref doc.X1001_BIRTH_INC_DATE,
                                    ref doc.X1001_ZIP_CODE,
                                    ref doc.X1001_TIME_ZONE,
                                    ref doc.X1001_FOUND_ON_CRF,
                                    ref doc.X1040_ASSIGNMENT_UNIT,
                                    ref doc.X1040_CONTACT_OFFICER,
                                    ref doc.X1040_SERVICE_UNIT,
                                    ref doc.X1040_SIC_CODE,
                                    ref doc.X1035_NAICS_CODE,
                                    ref doc.X1043_TYPE_TIN_IND,
                                    ref doc.X1043_TYPE_ID,
                                    ref doc.X1043_ID_NUMBER_1,
                                    ref doc.X1043_STATE_OF_ISSUE,
                                    ref doc.X1043_COUNTRY_OF_ISSUE,
                                    ref doc.X1043_ISSUANCE_DATE,
                                    ref doc.X1043_EXPIRATION_DATE,
                                    ref doc.X1043_ID_NUMBER_2,
                                    ref doc.X1043_ID_NUMBER_3,
                                    ref ctx);

                request.Errors = doc.LUW_ERROR_MESSAGES;
                request.ObligorNumber = doc.LUW_OBLIGOR;

                if (doc.LUW_ERROR_MESSAGES.Length > 0)
                    Logger.Log(this, LogLevel.Error, "Invoke CreateObligor through HIS", doc.LUW_ERROR_MESSAGES);

            }
            catch (CustomTIException Ex)
            {
                var err = string.Empty;
                if (Ex.TIExceptionMsgId == Constants.HIS_META_DATA_ERROR)
                {
                    err = String.Format("CICS program returned an error. \nTI Runtime Error MsgID={0} \nError description=\"{1}\"", Ex.TIExceptionMsgId, Ex.Message);
                    Logger.Log(this, LogLevel.Error, "Invoke CreateObligor through HIS", err);
                    Trace.WriteLine(err);
                }

                else
                {
                    err = String.Format("COMPASS Connection failed with TI Runtime Error MsgID {0}, description: \n{1}", Ex.TIExceptionMsgId, Ex.Message);
                    Logger.Log(this, LogLevel.Error, "Invoke CreateObligor through HIS", err);
                    Trace.WriteLine(err);
                }
                request.Errors = err;
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                request.Errors = msg;
                throw;
            }
        }

        /// <summary>
        /// Creates the alternate name and address.
        /// </summary>
        /// <param name="request"></param>
        public void CreateAlternateNameAndAddress(CreateAlternateNameAndAddressCommand request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);

            //check for specific counts
            if (!request.AlternateNameAndAddressFields.IsNullOrEmpty<REQUEST_1091_FIELD_DESC>())
            {
                request.AlternateNameAndAddressFields.AddOrTrimExcess<REQUEST_1091_FIELD_DESC>(Constants.CREATE_ALT_NAME_ADDRESS_COUNT);
            }
            if (!request.AlternateNameAndAddressExtraFields.IsNullOrEmpty<REQUEST_1091_FIELD_DESC_EXTRA>())
            {
                request.AlternateNameAndAddressExtraFields.AddOrTrimExcess<REQUEST_1091_FIELD_DESC_EXTRA>(Constants.CREATE_ALT_NAME_ADDRESS_COUNT);
            }

            var get1091Fields = Array.ConvertAll<REQUEST_1091_FIELD_DESC, ObligorServicesContext.REQUEST_1091_FIELDS>(request.AlternateNameAndAddressFields.ToArray(), delegate(REQUEST_1091_FIELD_DESC output)
            {
                var get1091Field = new REQUEST_1091_FIELDS()
                {
                    x1091_ADDRESS1 = output.x1091_ADDRESS1,
                    x1091_ADDRESS2 = output.x1091_ADDRESS2,
                    x1091_ADDRESS3 = output.x1091_ADDRESS3,
                    x1091_ADDRESS4 = output.x1091_ADDRESS4,
                    x1091_ADDRESS5 = output.x1091_ADDRESS5,
                    x1091_ADDRESS6 = output.x1091_ADDRESS6,
                    x1091_CITY = output.x1091_CITY,
                    x1091_STATE = output.x1091_STATE,
                    x1091_ZIP_CODE = output.x1091_ZIP_CODE,
                    x1091_NAME_TITLE = output.x1091_NAME_TITLE,
                    x1091_NAME = output.x1091_NAME,
                    x1091_NAME_CONTINUED = output.x1091_NAME_CONTINUED,
                    x1091_SSN = output.x1091_SSN,
                    x1091_TIN = output.x1091_TIN,
                    x1091_TELEPHONE1 = output.x1091_TELEPHONE1,
                    x1091_TELEPHONE2 = output.x1091_TELEPHONE2,
                    x1091_NAAD_RECORD_CODE = output.x1091_NAAD_RECORD_CODE
                };

                return get1091Field;
            });

            var get1091AddFields = Array.ConvertAll<REQUEST_1091_FIELD_DESC_EXTRA, ObligorServicesContext.REQUEST_1091_FIELDS_EXTRA>(request.AlternateNameAndAddressExtraFields.ToArray(), delegate(REQUEST_1091_FIELD_DESC_EXTRA output)
            {
                var get1091AddField = new REQUEST_1091_FIELDS_EXTRA()
                {
                    x1091_BYTE_TO_MATCH_1001 = output.x1091_BYTE_TO_MATCH_1001,
                    x1091_EMAIL_ADDR_ESS = output.x1091_BUSINESS_EXTENSION,
                    x1091_WEBSITE = output.x1091_WEBSITE,
                    x1091_TIME_ZONE = output.x1091_TIME_ZONE,
                    x1091_FAX_AREA_CODE = output.x1091_FAX_AREA_CODE,
                    x1091_FAX_PHONE_NUMBER = output.x1091_FAX_PHONE_NUMBER,
                    x1091_TELEX_PHONE_NUMBER = output.x1091_TELEX_PHONE_NUMBER,
                    x1091_RESIDENT_EXTENSION = output.x1091_RESIDENT_EXTENSION,
                    x1091_BUSINESS_EXTENSION = output.x1091_BUSINESS_EXTENSION
                };

                return get1091AddField;
            });

            CreateAlternateNameAndAddressInDocument doc = new CreateAlternateNameAndAddressInDocument
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
                REQUEST_1091_FIELDS = get1091Fields,
                REQUEST_1091_FIELDS_EXTRA = get1091AddFields

            };

            try
            {
                srv.CreateAlternateNameAndAddress(ref doc.LUW_ID,
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
                                    ref doc.REQUEST_1091_FIELDS,
                                    ref doc.REQUEST_1091_FIELDS_EXTRA,
                                    ref ctx);

                request.Errors = doc.LUW_ERROR_MESSAGES;
                //Note: Need to check if there are any other fields that need to be mapped back to the request
                //object for further operation

            }
            catch (CustomTIException Ex)
            {
                HandleHISException<CreateAlternateNameAndAddressCommand>(request, Ex, "CreateAlternateNameAndAddress");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                request.Errors = msg;
                throw;
            }
        }

        #region Not Implemented

        public void UpdateNameAndAddress()
        {
            throw new NotImplementedException();
        }


        public void UpdateAlternateNameAndAddress()
        {
            throw new NotImplementedException();
        }

        public void UpdateObligor()
        {
            throw new NotImplementedException();
        }
        #endregion



    }
}
