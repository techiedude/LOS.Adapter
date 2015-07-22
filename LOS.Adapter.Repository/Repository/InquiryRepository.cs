using InquiryServicesContext;
using LOS.Adapter.Data.Services.Extensions;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using Microsoft.HostIntegration.TI;
using SunTrust.Wholesale.Commercial.Logging;
using System;
using System.Linq;

namespace LOS.Adapter.Data.Services.Repository
{
    /// <summary>
    /// Inquiry Repository for handling Inquiry operations
    /// </summary>
    public class InquiryRepository : BaseRepository, IInquiryRepository
    {

        IInquiryServices inq;

        /// <summary>
        /// Initializes a new instance of the <see cref="InquiryRepository"/> class.
        /// </summary>
        public InquiryRepository()
        {
            //lead = new LEADServices();
            inq = new InquiryServices();
        }

        /// <summary>
        /// Gets the collateral indicative.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetCollateralIndicativeResponse GetCollateralIndicative(GetCollateralIndicativeRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            var getCollIndicativeDocIn = new InquiryServicesContext.GetCollateralIndicativeInDocument
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

            decimal x186A_COLL_VALUE;
            decimal x186A_UNITS;
            string x186A_EXPIRE_DATE;
            string x186A_SECURITY_NO;
            string x186A_SAFEKP_CODE;
            decimal x186A_ADV_PCT;
            decimal x186A_MAX_LEND_AMT;
            string x186A_DESCRIPT_1;
            string x186A_DESCRIPT_2;
            string x186A_FUNCTION_TYPE;
            decimal x186A_UNIT_PRICE;
            short x186A_COLL_TYPE;
            string x186B_USER_NUMERIC;
            string x186B_USER_CODE_1;
            string x186B_USER_CODE_2;
            decimal x186F_INDICATIVE_DATA_YEAR;
            string x186F_MAKE;
            string x186F_MODEL;
            string x186F_SERIAL_NUMBER;
            string x186F_PROPERTY_ADDRESS_1;
            string x186F_PROPERTY_ADDRESS_2;
            string x186F_CITY;
            string x186F_STATE;
            string x186F_ZIP;
            decimal x186F_IND_DATA_AMOUNT;
            string x186F_DISPOSITION_THREE;
            string x186G_CLI_LIEN_POSITION_1;
            string x186G_CLI_LIEN_HOLDER_1;
            decimal x186G_CLI_LIEN_AMOUNT_1;
            string x186I_APPRAISAL_T_YPE;
            string x186I_LAST_APPRAI_SAL_DATE;
            decimal x186I_LAST_APPRAI_SAL_AMT;


            try
            {
                inq.GetCollateralIndicative(ref getCollIndicativeDocIn.LUW_ID,
                                ref getCollIndicativeDocIn.LUW_REQUEST_CODE,
                                ref getCollIndicativeDocIn.LUW_BATCH_ID,
                                ref getCollIndicativeDocIn.LUW_BANK,
                                ref getCollIndicativeDocIn.LUW_OBLIGOR,
                                ref getCollIndicativeDocIn.LUW_OBLIGATION,
                                ref getCollIndicativeDocIn.LUW_ITEM_NBR,
                                ref getCollIndicativeDocIn.SEG_COUNTER,
                                ref getCollIndicativeDocIn.LUW_HEADER_FILLER,
                                ref getCollIndicativeDocIn.LUW_CALLING_APPL,
                                ref getCollIndicativeDocIn.LUW_LENGTH,
                                ref errors,
                                out x186A_COLL_VALUE,
                                out x186A_UNITS,
                                out x186A_EXPIRE_DATE,
                                out x186A_SECURITY_NO,
                                out x186A_SAFEKP_CODE,
                                out x186A_ADV_PCT,
                                out x186A_MAX_LEND_AMT,
                                out x186A_DESCRIPT_1,
                                out x186A_DESCRIPT_2,
                                out x186A_FUNCTION_TYPE,
                                out x186A_UNIT_PRICE,
                                out x186A_COLL_TYPE,
                                out x186B_USER_NUMERIC,
                                out x186B_USER_CODE_1,
                                out x186B_USER_CODE_2,
                                out x186F_INDICATIVE_DATA_YEAR,
                                out x186F_MAKE,
                                out x186F_MODEL,
                                out x186F_SERIAL_NUMBER,
                                out x186F_PROPERTY_ADDRESS_1,
                                out x186F_PROPERTY_ADDRESS_2,
                                out x186F_CITY,
                                out x186F_STATE,
                                out x186F_ZIP,
                                out x186F_IND_DATA_AMOUNT,
                                out x186F_DISPOSITION_THREE,
                                out x186G_CLI_LIEN_POSITION_1,
                                out x186G_CLI_LIEN_HOLDER_1,
                                out x186G_CLI_LIEN_AMOUNT_1,
                                out x186I_APPRAISAL_T_YPE,
                                out x186I_LAST_APPRAI_SAL_DATE,
                                out x186I_LAST_APPRAI_SAL_AMT,
                                ref ctx);

                return new GetCollateralIndicativeResponse()
                {
                    Errors = errors,
                    x186A_COLL_VALUE = x186A_COLL_VALUE,
                    x186A_UNITS = x186A_UNITS,
                    x186A_EXPIRE_DATE = x186A_EXPIRE_DATE,
                    x186A_SECURITY_NO = x186A_SECURITY_NO,
                    x186A_SAFEKP_CODE = x186A_SAFEKP_CODE,
                    x186A_ADV_PCT = x186A_ADV_PCT,
                    x186A_MAX_LEND_AMT = x186A_MAX_LEND_AMT,
                    x186A_DESCRIPT_1 = x186A_DESCRIPT_1,
                    x186A_DESCRIPT_2 = x186A_DESCRIPT_2,
                    x186A_FUNCTION_TYPE = x186A_FUNCTION_TYPE,
                    x186A_UNIT_PRICE = x186A_UNIT_PRICE,
                    x186A_COLL_TYPE = x186A_COLL_TYPE,
                    x186B_USER_NUMERIC = x186B_USER_NUMERIC,
                    x186B_USER_CODE_1 = x186B_USER_CODE_1,
                    x186B_USER_CODE_2 = x186B_USER_CODE_2,
                    x186F_INDICATIVE_DATA_YEAR = x186F_INDICATIVE_DATA_YEAR,
                    x186F_MAKE = x186F_MAKE,
                    x186F_MODEL = x186F_MODEL,
                    x186F_SERIAL_NUMBER = x186F_SERIAL_NUMBER,
                    x186F_PROPERTY_ADDRESS_1 = x186F_PROPERTY_ADDRESS_1,
                    x186F_PROPERTY_ADDRESS_2 = x186F_PROPERTY_ADDRESS_2,
                    x186F_CITY = x186F_CITY,
                    x186F_STATE = x186F_STATE,
                    x186F_ZIP = x186F_ZIP,
                    x186F_INDICATIVE_DATA_AMOUNT = x186F_IND_DATA_AMOUNT,
                    x186F_DISPOSITION_THREE = x186F_DISPOSITION_THREE,
                    x186G_CLI_LIEN_POSITION_1 = x186G_CLI_LIEN_POSITION_1,
                    x186G_CLI_LIEN_HOLDER_1 = x186G_CLI_LIEN_HOLDER_1,
                    x186G_CLI_LIEN_AMOUNT_1 = x186G_CLI_LIEN_AMOUNT_1,
                    x186I_APPRAISAL_T_YPE = x186I_APPRAISAL_T_YPE,
                    x186I_LAST_APPRAI_SAL_DATE = x186I_LAST_APPRAI_SAL_DATE,
                    x186I_LAST_APPRAI_SAL_AMT = x186I_LAST_APPRAI_SAL_AMT
                };
            }

            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetCollateralIndicativeResponse>(Ex, request, "GetCollateralIndicative");
            }
            catch (Exception ee)
            {
                Logger.Log(this, LogLevel.Error, "Invoke GetCollateralIndicative through HIS", ee.Message);
                throw;
            }
        }


        /// <summary>
        /// Gets the Collateral Supporting Obligation.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetCollateralSupportingResponse GetCollateralSupportingObligation(GetCollateralSupportingRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            string LUW_184A_OBLIGOR_SHORT_NAME = null;
            //162 occurences as per copybook
            LUW_184A_TABLE outputField = new LUW_184A_TABLE
            {
                LUW_184A_COLL_CURR_AMT = string.Empty,
                LUW_184A_DESCRIPTION = string.Empty,
                LUW_184A_DT_RECV_EFF = string.Empty,
                LUW_184A_DT_RELS_EFF = string.Empty,
                LUW_184A_ITEM = string.Empty,
                LUW_184A_MAKE_PIECES = string.Empty,
                LUW_184A_MODEL_UNITS = string.Empty,
                LUW_184A_OBGAT = string.Empty,
                LUW_184A_OBLR_LIT_REF_TYPE = string.Empty,
                LUW_184A_PRIORITY_NO = string.Empty,
                LUW_184A_PROP_OWNER_NUM = string.Empty,
                LUW_184A_PROP_OWNER_SNAM = string.Empty,
                LUW_184A_SERIAL_SECURITY = string.Empty,
                LUW_184A_TYPE = string.Empty
            };
            LUW_184A_TABLE[] outputs = new LUW_184A_TABLE[Constants.GET_COLL_SUPPORTING_COUNT];
            for (int i = 0; i < Constants.GET_COLL_SUPPORTING_COUNT; i++)
            {
                outputs[i] = outputField;
            }
            var getCollSupportingDocIn = new InquiryServicesContext.GetCollateralSupportingInDocument
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

                inq.GetCollateralSupporting(ref getCollSupportingDocIn.LUW_ID,
                   ref getCollSupportingDocIn.LUW_REQUEST_CODE,
                   ref getCollSupportingDocIn.LUW_BATCH_ID,
                   ref getCollSupportingDocIn.LUW_BANK,
                   ref getCollSupportingDocIn.LUW_OBLIGOR,
                   ref getCollSupportingDocIn.LUW_OBLIGATION,
                   ref getCollSupportingDocIn.LUW_ITEM_NBR,
                   ref getCollSupportingDocIn.SEG_COUNTER,
                   ref getCollSupportingDocIn.LUW_HEADER_FILLER,
                   ref getCollSupportingDocIn.LUW_CALLING_APPL,
                   ref getCollSupportingDocIn.LUW_LENGTH,
                   ref errors,
                   out LUW_184A_OBLIGOR_SHORT_NAME,
                   out outputs,
                   ref ctx);

                var collSupportObligations = Array.ConvertAll<LUW_184A_TABLE, CollateralSupportingObigation>(outputs, delegate(LUW_184A_TABLE output)
                {
                    CollateralSupportingObigation collObligation = new CollateralSupportingObigation();
                    collObligation.LUW_184A_COLL_CURR_AMT = output.LUW_184A_COLL_CURR_AMT;
                    collObligation.LUW_184A_DESCRIPTION = output.LUW_184A_DESCRIPTION;
                    collObligation.LUW_184A_DT_RECV_EFF = output.LUW_184A_DT_RECV_EFF;
                    collObligation.LUW_184A_DT_RELS_EFF = output.LUW_184A_DT_RELS_EFF;
                    collObligation.LUW_184A_ITEM = output.LUW_184A_ITEM;
                    collObligation.LUW_184A_MAKE_PIECES = output.LUW_184A_MAKE_PIECES;
                    collObligation.LUW_184A_MODEL_UNITS = output.LUW_184A_MODEL_UNITS;
                    collObligation.LUW_184A_OBGAT = output.LUW_184A_OBGAT;
                    collObligation.LUW_184A_OBLR_LIT_REF_TYPE = output.LUW_184A_OBLR_LIT_REF_TYPE;
                    collObligation.LUW_184A_PRIORITY_NO = output.LUW_184A_PRIORITY_NO;
                    collObligation.LUW_184A_PROP_OWNER_NUM = output.LUW_184A_PROP_OWNER_NUM;
                    collObligation.LUW_184A_PROP_OWNER_SNAM = output.LUW_184A_PROP_OWNER_SNAM;
                    collObligation.LUW_184A_SERIAL_SECURITY = output.LUW_184A_SERIAL_SECURITY;
                    collObligation.LUW_184A_TYPE = output.LUW_184A_TYPE;
                    return collObligation;

                });
                return new GetCollateralSupportingResponse() { CollateralSupportingObligations = collSupportObligations.ToList(), Errors = errors };

            }

            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetCollateralSupportingResponse>(Ex, request, "GetCollateralSupportingResponse");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }
        }


        /// <summary>
        /// Gets the Collateral Ties.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetCollateralTiesResponse GetCollateralTies(GetCollateralTiesRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            string x188A_OBLIGOR_SHORT_NAME = null;
            //300 occurences as per copybook
            LUW_188A_TABLE_00O outputField = new LUW_188A_TABLE_00O { x188A_SUPPORT_OBLIGOR = string.Empty, x188A_SUPPORT_APP = string.Empty, x188A_SUPPORT_OBLN = string.Empty, x188A_SUPPORT_TYPE = string.Empty, x188A_SUPPORT_PRIORITY = string.Empty, x188A_SUPPORT_DATE = string.Empty, x188A_SUPPORT_CURR_AMT = 0.0m };
            LUW_188A_TABLE_00O[] outputs = new LUW_188A_TABLE_00O[300];
            for (int i = 0; i < 300; i++)
            {
                outputs[i] = outputField;
            }
            var getCollTiesDocIn = new InquiryServicesContext.GetCollateralTiesInDocument
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

                inq.GetCollateralTies(ref getCollTiesDocIn.LUW_ID,
                   ref getCollTiesDocIn.LUW_REQUEST_CODE,
                   ref getCollTiesDocIn.LUW_BATCH_ID,
                   ref getCollTiesDocIn.LUW_BANK,
                   ref getCollTiesDocIn.LUW_OBLIGOR,
                   ref getCollTiesDocIn.LUW_OBLIGATION,
                   ref getCollTiesDocIn.LUW_ITEM_NBR,
                   ref getCollTiesDocIn.SEG_COUNTER,
                   ref getCollTiesDocIn.LUW_HEADER_FILLER,
                   ref getCollTiesDocIn.LUW_CALLING_APPL,
                   ref getCollTiesDocIn.LUW_LENGTH,
                   ref errors,
                   out x188A_OBLIGOR_SHORT_NAME,
                   out outputs,
                   ref ctx);

                var collSupportObligors = Array.ConvertAll<LUW_188A_TABLE_00O, CollateralSupportObligor>(outputs, delegate(LUW_188A_TABLE_00O output)
                {
                    CollateralSupportObligor obligor = new CollateralSupportObligor();
                    obligor.x188A_SUPPORT_OBLIGOR = output.x188A_SUPPORT_OBLIGOR;
                    obligor.x188A_SUPPORT_APP = output.x188A_SUPPORT_APP;
                    obligor.x188A_SUPPORT_OBLN = output.x188A_SUPPORT_OBLN;
                    obligor.x188A_SUPPORT_PRIORITY = output.x188A_SUPPORT_PRIORITY;
                    obligor.x188A_SUPPORT_TYPE = output.x188A_SUPPORT_TYPE;
                    obligor.x188A_SUPPORT_DATE = output.x188A_SUPPORT_DATE;
                    obligor.x188A_SUPPORT_CURR_AMT = output.x188A_SUPPORT_CURR_AMT;
                    return obligor;

                });
                return new GetCollateralTiesResponse() { CollateralSupportObligors = collSupportObligors.ToList(), Errors = errors };

            }

            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetCollateralTiesResponse>(Ex, request, "GetCollateralTiesResponse");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }
        }

        /// <summary>
        /// Gets the alternate name and address.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetAlternateNameAndAddressResponse GetAlternateNameAndAddress(GetAlternateNameAndAddressRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            REQUEST_0101_FIELDS outputField = new REQUEST_0101_FIELDS
            {
                x0101_CUSTOMER_GREETING = string.Empty,
                x0101_NAME = string.Empty,
                x0101_NAME_CONT = string.Empty,
                x0101_SOCIAL_SECURITY = string.Empty,
                x0101_BIRTH_INC_DATE = string.Empty,
                x0101_TAXID = string.Empty,
                x0101_RECORD_CODE = string.Empty,
                x0101_CONTACT_DATE = string.Empty,
                x0101_LST_ASSGN_ALT_REC = string.Empty,
                x0101_ADDRESS_LINE_ONE = string.Empty,
                x0101_ADDRESS_LINE_TWO = string.Empty,
                x0101_ADDRESS_LINE_THREE = string.Empty,
                x0101_ADDRESS_LINE_FOUR = string.Empty,
                x0101_ADDRESS_LINE_FIVE = string.Empty,
                x0101_ADDRESS_LINE_SIX = string.Empty,
                x0101_ADDRESS_LINE7 = string.Empty,
                x0101_TELEPHONE_NUMBER_1 = string.Empty,
                x0101_TELEPHONE_NUMBER_2 = string.Empty,
                x0101_TELEX_NUMBER = string.Empty
            };
            REQUEST_0101_FIELDS[] outputs = new REQUEST_0101_FIELDS[23];

            REQUEST_0101_ADD_FIELDS addOutputField = new REQUEST_0101_ADD_FIELDS
            {
                x0101_E_MAIL_ADDRESS = string.Empty,
                x0101_FAX_NUMBER = string.Empty,
                x0101_WEBSITE = string.Empty
            };

            REQUEST_0101_ADD_FIELDS[] addOutputs = new REQUEST_0101_ADD_FIELDS[23];


            for (int i = 0; i < 23; i++)
            {
                outputs[i] = outputField;
                addOutputs[i] = addOutputField;
            }


            var getAlternateNameAddressDocIn = new InquiryServicesContext.GetAlternateNameAndAddressInDocument
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
                inq.GetAlternateNameAndAddress(ref getAlternateNameAddressDocIn.LUW_ID,
                    ref getAlternateNameAddressDocIn.LUW_REQUEST_CODE,
                    ref getAlternateNameAddressDocIn.LUW_BATCH_ID,
                    ref getAlternateNameAddressDocIn.LUW_BANK,
                    ref getAlternateNameAddressDocIn.LUW_OBLIGOR,
                    ref getAlternateNameAddressDocIn.LUW_OBLIGATION,
                    ref getAlternateNameAddressDocIn.LUW_ITEM_NBR,
                    ref getAlternateNameAddressDocIn.SEG_COUNTER,
                    ref getAlternateNameAddressDocIn.LUW_HEADER_FILLER,
                    ref getAlternateNameAddressDocIn.LUW_CALLING_APPL,
                    ref getAlternateNameAddressDocIn.LUW_LENGTH,
                    ref errors,
                    out outputs,
                    out addOutputs,
                    ref ctx);

                var altNameAddressArray = Array.ConvertAll<REQUEST_0101_FIELDS, AlternateAddressFields>(outputs, delegate(REQUEST_0101_FIELDS output)
                {
                    AlternateAddressFields altNameAddress = new AlternateAddressFields();
                    altNameAddress.x0101_CUSTOMER_GREETING = output.x0101_CUSTOMER_GREETING;
                    altNameAddress.x0101_NAME = output.x0101_NAME;
                    altNameAddress.x0101_NAME_CONT = output.x0101_NAME_CONT;
                    altNameAddress.x0101_SOCIAL_SECURITY = output.x0101_SOCIAL_SECURITY;
                    altNameAddress.x0101_BIRTH_INC_DATE = output.x0101_BIRTH_INC_DATE;
                    altNameAddress.x0101_TAXID = output.x0101_TAXID;
                    altNameAddress.x0101_RECORD_CODE = output.x0101_RECORD_CODE;
                    altNameAddress.x0101_CONTACT_DATE = output.x0101_CONTACT_DATE;
                    altNameAddress.x0101_LST_ASSGN_ALT_REC = output.x0101_LST_ASSGN_ALT_REC;
                    altNameAddress.x0101_ADDRESS_LINE_ONE = output.x0101_ADDRESS_LINE_ONE;
                    altNameAddress.x0101_ADDRESS_LINE_TWO = output.x0101_ADDRESS_LINE_TWO;
                    altNameAddress.x0101_ADDRESS_LINE_THREE = output.x0101_ADDRESS_LINE_THREE;
                    altNameAddress.x0101_ADDRESS_LINE_FOUR = output.x0101_ADDRESS_LINE_FOUR;
                    altNameAddress.x0101_ADDRESS_LINE_FIVE = output.x0101_ADDRESS_LINE_FIVE;
                    altNameAddress.x0101_ADDRESS_LINE_SIX = output.x0101_ADDRESS_LINE_SIX;
                    altNameAddress.x0101_ADDRESS_LINE7 = output.x0101_ADDRESS_LINE7;
                    altNameAddress.x0101_TELNUM_1 = output.x0101_TELEPHONE_NUMBER_1;
                    altNameAddress.x0101_TELNUM_2 = output.x0101_TELEPHONE_NUMBER_2;
                    altNameAddress.x0101_TELEX_NUMBER = output.x0101_TELEX_NUMBER;
                    return altNameAddress;

                });

                var altNameAddressAddArray = Array.ConvertAll<REQUEST_0101_ADD_FIELDS, AlternateAddressAddFields>(addOutputs, delegate(REQUEST_0101_ADD_FIELDS output)
                {
                    AlternateAddressAddFields addAltNameAddress = new AlternateAddressAddFields();
                    addAltNameAddress.x0101_E_MAIL_ADDRESS = output.x0101_E_MAIL_ADDRESS;
                    addAltNameAddress.x0101_FAX_NUMBER = output.x0101_FAX_NUMBER;
                    addAltNameAddress.x0101_WEBSITE = output.x0101_WEBSITE;
                    return addAltNameAddress;
                });

                return new GetAlternateNameAndAddressResponse() { AlternateNameAndAddressList = altNameAddressArray.ToList(), AlternateNameAndAddressAddList = altNameAddressAddArray.ToList(), Errors = errors };

            }

            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetAlternateNameAndAddressResponse>(Ex, request, "GetAlternateNameAndAddressResponse");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }
        }


        /// <summary>
        /// Gets the obligor.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetObligorResponse GetObligor(GetObligorRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            var getObligorDocIn = new InquiryServicesContext.GetObligorInDocument
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

            short x102A_OBLIGOR_TYPE;
            string x102A_CREDIT_RATING;
            string x102A_DATE_OF_CRED_RATING;
            int x102A_GEOGRAPHIC_CODE_1;
            string x102A_GEOGRAPHIC_INDICATOR;
            short x102A_OBLIGOR_TAX_CLASS;
            decimal x102A_PERS_INCOME;
            short x102A_HMDA_GENDER;
            short x102A_HMDA_ETHNIC;
            string x102A_CENTRAL_FILE_REFERENCE;
            string x102B_USER_CODE_1;
            string x102B_USER_CODE_2;
            decimal x102B_USER_AMOUNT;
            string x102C_ASSIGNMENT_UNIT;
            int x102C_CONTACT_OFFICER;
            int x102C_SERVICE_UNIT;
            short x102C_STATEMENT_TYPE;
            short x102C_STATEMENT_FREQUENCY;
            string x102C_DATE_OF_NEXT_STATEMENT;
            string x102C_CL_USER_CODE_2;
            string x102C_CL_USER_ALPHA;
            string x102D_CMS_IDENTIFIER;
            int x102E_NAICS;
            string L101_NAME;
            string L101_RECORD_CODE;
            string L101_NAME_CONT;
            string L101_LST_ASSGN_ALT_REC;
            string L101_ADDRESS_LINE_ONE;
            string L101_CUSTOMER_GREETING;
            string L101_ADDRESS_LINE_TWO;
            string L101_AREA_CODE_1;
            string L101_LOCAL_NUM_1;
            string L101_EXTENSION_1;
            string L101_ADDRESS_LINE_THREE;
            string L101_AREA_CODE_2;
            string L101_LOCAL_NUM_2;
            string L101_EXTENSION_2;
            string L101_ADDRESS_LINE_FOUR;
            string L101_TELEX_NUMBER;
            string L101_ADDRESS_LINE_FIVE;
            string L101_CONTACT_DATE;
            string L101_ADDRESS_LINE_SIX;
            string L101_SOCIAL_SECURITY;
            string L101_ADDRESS_LINE7;
            string L101_TAXID;
            string L101_BIRTH_INC_DATE;
            string x102A_OBLIGOR_TYPE_LIT;
            string x102A_OBLIGOR_SHORT_NAME;
            string x102A_STATUS_CODE;
            string x102A_STATUS_CODE_LIT;
            string x102A_STATUS_DATE;
            string x102A_LAST_FINANCL_STMT_DATE;
            string x102A_CRED_RATING_SOURCE;
            string x102A_CRED_RATING_SOURCE_LIT;
            string x102A_GEOGRAPHIC_IND_DESC;
            string x102A_BANK_TAX;
            string x102A_BANK_TAX_CLASS_LIT;
            string x102A_GEOGRAPHIC_CODE_2;
            string x102A_FISCAL_YEAR_END_DATE;
            string x102A_OBLIGOR_TAX_CLASS_LIT;
            string x102A_INTERLOCKING_DIRECTOR;
            string x102A_INTERLOCK_CODE_LIT;
            string x102A_BANK_ASSOC_CODE;
            string x102A_BANK_ASSOC_CODE_LIT;
            string x102A_AFFILIATED_RELATIONSHIP;
            string x102A_AFFILIATED_CODE_LIT;
            string x102A_AFFILIATED_NUMBER;
            string x102A_DUNS_NUMBER;
            string x102A_CRA_BUSINESS;
            string x102A_CRA_BUSINESS_LIT;
            string x102A_STAND_METRO_STAT_AREA;
            string x102A_RACE_1;
            string x102A_RACE_1_LIT;
            string x102A_CRA_GENDER_LIT;
            decimal x102A_CENSUS_TRACT;
            string x102A_RACE_2;
            string x102A_RACE_2_LIT;
            string x102A_PRIVACY_CODE;
            string x102A_EMPLOYEE_OBLIGOR_NO;
            string x102A_RACE_3;
            string x102A_RACE_3_LIT;
            string x102A_ETHNICITY_LIT;
            string x102A_RACE_4;
            string x102A_RACE_4_LIT;
            string x102A_RACE_5;
            string x102A_RACE_5_LIT;
            string x102B_DATE_ACCOUNT_OPENED;
            string x102B_DATE_OF_LAST_CHANGE;
            string x102B_LAST_TRAN_JOURNAL_DATE;
            string x102B_LAST_ACTIVE_DATE;
            string x102B_DATE_OF_LAST_ACTIVY;
            string x102B_MULT_SERVICE_UNIT_ACTIVTY;
            string x102B_MULT_BORROWS_LIT;
            string x102B_ACTIVE_OBLNS_CODE;
            string x102B_ACTIVE_OBLNS_CODE_LIT;
            string x102B_LAST_OBLIGAT_NR_ASSIGNED;
            string x102B_OLD_OBLIGOR_NUMBER;
            string x102B_SYSTEM_CODE;
            string x102B_STATEMENT_TYPE;
            string x102B_STATEMENT_TYPE_LIT;
            string x102B_STATEMENT_FREQUENCY;
            string x102B_STATEMENT_FREQ_LIT;
            string x102B_DATE_OF_NEXT_STATEMENT;
            string x102B_SPECIAL_INFO_DATE;
            string x102B_SPECIAL_INFO_CODE;
            string x102B_SPEC_INFO_CODE_LIT;
            string x102B_SPL_INSTRUCT_DATE;
            string x102B_SPECIAL_INFO_OFFICE;
            string x102B_SPL_INSTRUCT_OFFICER;
            string x102B_USER_DATE_1;
            string x102B_USER_DATE_2;
            string x102B_USER_CODE_3;
            string x102B_USER_NUMERIC;
            string x102B_USER_ALPHA;
            string x102B_COLLECTION_MONITOR;
            string x102B_COLLECT_MON_LIT;
            string x102B_COLLECTION_TIMES;
            string x102B_PREV_COLLECT_STATUS;
            string x102B_PREV_COLL_LIT;
            string x102B_CURR_COLLECT_STATUS;
            string x102B_CURR_COLL_LIT;
            string x102E_CRED_RATING_SOURCE;
            string x102E_RATING_TYPE_1_LIT;
            string x102E_CREDIT_RATING;
            string x102E_DATE_OF_CRED_RATING;
            string x102E_RATING_TYP_E_2;
            string x102E_RATING_TYPE_2_LIT;
            string x102E_CREDIT_RAT_ING_2;
            string x102E_CREDIT_RAT_ING_DATE_2;
            string x102E_RATING_TYP_E_3;
            string x102E_RATING_TYPE_3_LIT;
            string x102E_CREDIT_RAT_ING_3;
            string x102E_CREDIT_RAT_ING_DATE_3;
            string x102E_RATING_TYP_E_4;
            string x102E_RATING_TYPE_4_LIT;
            string x102E_CREDIT_RAT_ING_4;
            string x102E_CREDIT_RAT_ING_DATE_4;
            string x102E_RATING_TYP_E_5;
            string x102E_RATING_TYPE_5_LIT;
            string x102E_CREDIT_RAT_ING_5;
            string x102E_CREDIT_RAT_ING_DATE_5;
            string x102E_SIC_CODE;
            string x102E_ADDL_NAICS_1;
            decimal x102E_ADDL_NAICS_1_PCT;
            string x102E_ADDL_NAICS_2;
            decimal x102E_ADDL_NAICS_2_PCT;
            string x102E_ADDL_NAICS_3;
            decimal x102E_ADDL_NAICS_3_PCT;
            string x102E_ADDL_NAICS_4;
            decimal x102E_ADDL_NAICS_4_PCT;
            string x102E_ADDL_NAICS_5;
            decimal x102E_ADDL_NAICS_5_PCT;
            string x102E_INDUSTRY_A_T_RISK;
            decimal x102E_INDUSTRY_A_T_RISK_PCT;
            string x102E_SOURCE_CHE_CKED;
            string x102E_DATE_LAST_CHECKED;
            string x102E_RESULT_OF_CHECK;
            string x102E_RESULT_OF_CHK_LIT;
            string x102E_COUNTRY_OF_CITIZEN_1;
            string x102E_COUNTRY_OF_REGISTRATIO;
            string x102E_FOREIGN_PO_LITICAL_IND;
            string x102E_COUNTRY_OF_CITIZEN_2;
            string x102E_US_CITIZEN_IND;
            decimal x102E_ASSET_SIZ_E;
            string x102C_LOB_NUMBER;
            string x102C_REGION_NUMBER;
            string x102C_SUB_LOB;
            string x102C_GROUP;
            string x102C_MARKET;
            string x102C_USER_HIERARCHY;
            string x102C_LANGUAGE_INDICATOR;
            string x102C_FED_RESERVE_CODE;
            string x102C_STATEMENT_TYPE_LIT;
            string x102C_STATEMENT_FREQ_LIT;
            string x102C_DDA_INTF_ACCOUNT_NUMB;
            string x102C_DDA_INTF_TRANSIT_NUMB;
            string x102C_PURGE_IND;
            string x102C_PURGE_IND_LIT;
            string x102C_ACH_CONSOLID_ATION;
            string x102C_ACH_CONSOL_LIT;
            string x102C_SPECIAL_TYPE_CODE;
            string x102C_SPEC_TYPE_LIT;
            string x102C_HISTORY_REVIEW_CODE;
            string x102C_HISTORY_REV_CODE_LIT;
            string x102C_HISTORY_REVIEW_FREQ;
            string x102C_HISTORY_REV_FREQ_LIT;
            string x102C_DATE_NEXT_HIST_REVIEW;
            decimal x102C_PRIMARY_DDA_ACCOUNT;
            decimal x102C_DDA_AMOUNT;
            string x102C_CL_USER_DATE_1;
            string x102C_CL_USER_DATE_2;
            string x102C_CL_USER_CODE_1;
            string x102C_CL_USER_CODE_3;
            string x102C_CL_USER_NUMERIC;
            decimal x102C_CL_USER_AMOUNT;
            string x102C_ORGID_1;
            string x102C_ORGID_2;
            string x102C_NAME_ADD_NUMBER;
            string x102C_NA_CR_BU_CD;
            string x102C_NAME;
            string x102C_GTS_BASE_NUMBER;
            string x102D_EXPOSURE_STRAT_CODE;
            decimal x102D_EXPOSURE_STRAT_AMT;
            string x102D_EXPOSURE_STRAT_DT;
            string x102D_CONTACT_TYPE;
            string x102D_CONTACT_NAME;
            string x102D_OBLIGOR_DESC_ONE;
            string x102D_OBLIGOR_DESC_TWO;
            string x102D_OBLIGOR_DESC_THREE;
            string x102D_AM_BEST_R_ATING;
            string x102D_AM_BEST_RATING_LIT;
            string x102D_AM_BEST_F_IN_SIZE_CAT;
            string x102D_AM_BEST_FIN_CAT_LIT;
            string x102D_STATE_CODE;
            string x102D_TAX_AUTHORTY_NUMBER;
            string x102D_COUNTY_CODE;
            string x102D_CHECK_OPT_ION;
            string x102D_TOWNSHIP_CODE;
            string x102D_DISB_TAPE_FORMAT;
            string x102D_INSTALLMENT_MONTH_1;
            string x102D_INSTALL_MO_1;
            string x102D_INSTALLMENT_MONTH_2;
            string x102D_INSTALL_MO_2;
            string x102D_INSTALLMENT_MONTH_3;
            string x102D_INSTALL_MO_3;
            string x102D_INSTALLMENT_MONTH_4;
            string x102D_INSTALL_MO_4;
            string x102D_DISBURSEMENT_FREQUENCY;
            string x102D_TAX_LIEN_SALES_MONTH;
            string x102D_TAX_LIEN_MONTH;
            string x102D_STI_NUMERIC_A;
            string x102D_STI_NUMERIC_B;
            string x102F_TYPE_OF_TIN_IND;
            string x102F_TYPE_OF_TIN_LIT;
            string x102F_TIN_CERTIFIC_ATION;
            string x102F_TIN_CERT_DAT_E;
            string x102F_TYPE_OF_ID_1;
            string x102F_TYPE_1_LIT;
            string x102F_ID_1_NUMBER;
            string x102F_STATE_OF_ISSUANCE_1;
            string x102F_ISSUANCE_DAT_E_1;
            string x102F_COUNTRY_OF_ISSUANCE_1;
            string x102F_EXPIRATION_D_ATE_1;
            string x102F_TYPE_OF_ID_2;
            string x102F_TYPE_2_LIT;
            string x102F_ID_2_NUMBER;
            string x102F_STATE_OF_ISSUANCE_2;
            string x102F_ISSUANCE_DAT_E_2;
            string x102F_COUNTRY_OF_ISSUANCE_2;
            string x102F_EXPIRATION_D_ATE_2;
            string x102F_TYPE_OF_ID_3;
            string x102F_TYPE_3_LIT;
            string x102F_ID_3_NUMBER;
            string x102F_STATE_OF_ISSUANCE_3;
            string x102F_ISSUANCE_DAT_E_3;
            string x102F_COUNTRY_OF_ISSUANCE_3;
            string x102F_EXPIRATION_D_ATE_3;
            string x102G_STOCK_EXCHANGE;
            string x102G_STOCK_TICKER;
            string x102G_CUSIP_NUMBER;
            string L101_TIME_ZONE;
            string L101_TIME_ZONE_LIT;
            string L101_FAX_NUMBER;
            string L101_E_MAIL_ADDRESS;
            string L101_WEBSITE;
            decimal x110A_COLL_RECEIV_PLEDGED;
            decimal x110A_COLL_UNITS_PLEDGED;
            decimal x110A_COLL_RECEIV_ELIGIBLE;
            decimal x110A_COLL_UNITS_ELIGIBLE;
            decimal x110A_COLL_RECEIV_INELGIBLE;
            decimal x110A_COLL_UNITS_INELGIBLE;
            decimal x110A_COLL_CURR_VALUE;
            string x110A_COLL_LAST_ACTIVE_DATE;
            decimal x110A_COLL_NET_AMOUNT;
            string x110A_COLL_LAST_ITEM_NO;
            string x110A_COLL_TOTAL_ITEMS;
            decimal x110A_TOTAL_ALL_FUTURES;
            decimal x110A_TOTAL_ALL_UNUSED;
            decimal x110A_TOTAL_ALL_CURRENTS;
            decimal x110A_TOTAL_ALL_INTEREST_OUT;
            decimal x110A_TOTAL_ALL_INDIRECTS;
            decimal x110A_TOT_LATE_CHRG_DUE;
            decimal x110A_TOTAL_ALL_INSURANCE;


            try
            {



                inq.GetObligor(ref getObligorDocIn.LUW_ID,
                                ref getObligorDocIn.LUW_REQUEST_CODE,
                                ref getObligorDocIn.LUW_BATCH_ID,
                                ref getObligorDocIn.LUW_BANK,
                                ref getObligorDocIn.LUW_OBLIGOR,
                                ref getObligorDocIn.LUW_OBLIGATION,
                                ref getObligorDocIn.LUW_ITEM_NBR,
                                ref getObligorDocIn.SEG_COUNTER,
                                ref getObligorDocIn.LUW_HEADER_FILLER,
                                ref getObligorDocIn.LUW_CALLING_APPL,
                                ref getObligorDocIn.LUW_LENGTH,
                                ref errors,
                                 out  x102A_OBLIGOR_TYPE,
                                 out  x102A_CREDIT_RATING,
                                 out  x102A_DATE_OF_CRED_RATING,
                                 out  x102A_GEOGRAPHIC_CODE_1,
                                 out  x102A_GEOGRAPHIC_INDICATOR,
                                 out  x102A_OBLIGOR_TAX_CLASS,
                                 out  x102A_PERS_INCOME,
                                 out  x102A_HMDA_GENDER,
                                 out  x102A_HMDA_ETHNIC,
                                 out  x102A_CENTRAL_FILE_REFERENCE,
                                 out  x102B_USER_CODE_1,
                                 out  x102B_USER_CODE_2,
                                 out  x102B_USER_AMOUNT,
                                 out  x102C_ASSIGNMENT_UNIT,
                                 out  x102C_CONTACT_OFFICER,
                                 out  x102C_SERVICE_UNIT,
                                 out  x102C_STATEMENT_TYPE,
                                 out  x102C_STATEMENT_FREQUENCY,
                                 out  x102C_DATE_OF_NEXT_STATEMENT,
                                 out  x102C_CL_USER_CODE_2,
                                 out  x102C_CL_USER_ALPHA,
                                 out  x102D_CMS_IDENTIFIER,
                                 out  x102E_NAICS,
                                 out  L101_NAME,
                                 out  L101_RECORD_CODE,
                                 out  L101_NAME_CONT,
                                 out  L101_LST_ASSGN_ALT_REC,
                                 out  L101_ADDRESS_LINE_ONE,
                                 out  L101_CUSTOMER_GREETING,
                                 out  L101_ADDRESS_LINE_TWO,
                                 out  L101_AREA_CODE_1,
                                 out  L101_LOCAL_NUM_1,
                                 out  L101_EXTENSION_1,
                                 out  L101_ADDRESS_LINE_THREE,
                                 out  L101_AREA_CODE_2,
                                 out  L101_LOCAL_NUM_2,
                                 out  L101_EXTENSION_2,
                                 out  L101_ADDRESS_LINE_FOUR,
                                 out  L101_TELEX_NUMBER,
                                 out  L101_ADDRESS_LINE_FIVE,
                                 out  L101_CONTACT_DATE,
                                 out  L101_ADDRESS_LINE_SIX,
                                 out  L101_SOCIAL_SECURITY,
                                 out  L101_ADDRESS_LINE7,
                                 out  L101_TAXID,
                                 out  L101_BIRTH_INC_DATE,
                                 out  x102A_OBLIGOR_TYPE_LIT,
                                 out  x102A_OBLIGOR_SHORT_NAME,
                                 out  x102A_STATUS_CODE,
                                 out  x102A_STATUS_CODE_LIT,
                                 out  x102A_STATUS_DATE,
                                 out  x102A_LAST_FINANCL_STMT_DATE,
                                 out  x102A_CRED_RATING_SOURCE,
                                 out  x102A_CRED_RATING_SOURCE_LIT,
                                 out  x102A_GEOGRAPHIC_IND_DESC,
                                 out  x102A_BANK_TAX,
                                 out  x102A_BANK_TAX_CLASS_LIT,
                                 out  x102A_GEOGRAPHIC_CODE_2,
                                 out  x102A_FISCAL_YEAR_END_DATE,
                                 out  x102A_OBLIGOR_TAX_CLASS_LIT,
                                 out  x102A_INTERLOCKING_DIRECTOR,
                                 out  x102A_INTERLOCK_CODE_LIT,
                                 out  x102A_BANK_ASSOC_CODE,
                                 out  x102A_BANK_ASSOC_CODE_LIT,
                                 out  x102A_AFFILIATED_RELATIONSHIP,
                                 out  x102A_AFFILIATED_CODE_LIT,
                                 out  x102A_AFFILIATED_NUMBER,
                                 out  x102A_DUNS_NUMBER,
                                 out  x102A_CRA_BUSINESS,
                                 out  x102A_CRA_BUSINESS_LIT,
                                 out  x102A_STAND_METRO_STAT_AREA,
                                 out  x102A_RACE_1,
                                 out  x102A_RACE_1_LIT,
                                 out  x102A_CRA_GENDER_LIT,
                                 out  x102A_CENSUS_TRACT,
                                 out  x102A_RACE_2,
                                 out  x102A_RACE_2_LIT,
                                 out  x102A_PRIVACY_CODE,
                                 out  x102A_EMPLOYEE_OBLIGOR_NO,
                                 out  x102A_RACE_3,
                                 out  x102A_RACE_3_LIT,
                                 out  x102A_ETHNICITY_LIT,
                                 out  x102A_RACE_4,
                                 out  x102A_RACE_4_LIT,
                                 out  x102A_RACE_5,
                                 out  x102A_RACE_5_LIT,
                                 out  x102B_DATE_ACCOUNT_OPENED,
                                 out  x102B_DATE_OF_LAST_CHANGE,
                                 out  x102B_LAST_TRAN_JOURNAL_DATE,
                                 out  x102B_LAST_ACTIVE_DATE,
                                 out  x102B_DATE_OF_LAST_ACTIVY,
                                 out  x102B_MULT_SERVICE_UNIT_ACTIVTY,
                                 out  x102B_MULT_BORROWS_LIT,
                                 out  x102B_ACTIVE_OBLNS_CODE,
                                 out  x102B_ACTIVE_OBLNS_CODE_LIT,
                                 out  x102B_LAST_OBLIGAT_NR_ASSIGNED,
                                 out  x102B_OLD_OBLIGOR_NUMBER,
                                 out  x102B_SYSTEM_CODE,
                                 out  x102B_STATEMENT_TYPE,
                                 out  x102B_STATEMENT_TYPE_LIT,
                                 out  x102B_STATEMENT_FREQUENCY,
                                 out  x102B_STATEMENT_FREQ_LIT,
                                 out  x102B_DATE_OF_NEXT_STATEMENT,
                                 out  x102B_SPECIAL_INFO_DATE,
                                 out  x102B_SPECIAL_INFO_CODE,
                                 out  x102B_SPEC_INFO_CODE_LIT,
                                 out  x102B_SPL_INSTRUCT_DATE,
                                 out  x102B_SPECIAL_INFO_OFFICE,
                                 out  x102B_SPL_INSTRUCT_OFFICER,
                                 out  x102B_USER_DATE_1,
                                 out  x102B_USER_DATE_2,
                                 out  x102B_USER_CODE_3,
                                 out  x102B_USER_NUMERIC,
                                 out  x102B_USER_ALPHA,
                                 out  x102B_COLLECTION_MONITOR,
                                 out  x102B_COLLECT_MON_LIT,
                                 out  x102B_COLLECTION_TIMES,
                                 out  x102B_PREV_COLLECT_STATUS,
                                 out  x102B_PREV_COLL_LIT,
                                 out  x102B_CURR_COLLECT_STATUS,
                                 out  x102B_CURR_COLL_LIT,
                                 out  x102E_CRED_RATING_SOURCE,
                                 out  x102E_RATING_TYPE_1_LIT,
                                 out  x102E_CREDIT_RATING,
                                 out  x102E_DATE_OF_CRED_RATING,
                                 out  x102E_RATING_TYP_E_2,
                                 out  x102E_RATING_TYPE_2_LIT,
                                 out  x102E_CREDIT_RAT_ING_2,
                                 out  x102E_CREDIT_RAT_ING_DATE_2,
                                 out  x102E_RATING_TYP_E_3,
                                 out  x102E_RATING_TYPE_3_LIT,
                                 out  x102E_CREDIT_RAT_ING_3,
                                 out  x102E_CREDIT_RAT_ING_DATE_3,
                                 out  x102E_RATING_TYP_E_4,
                                 out  x102E_RATING_TYPE_4_LIT,
                                 out  x102E_CREDIT_RAT_ING_4,
                                 out  x102E_CREDIT_RAT_ING_DATE_4,
                                 out  x102E_RATING_TYP_E_5,
                                 out  x102E_RATING_TYPE_5_LIT,
                                 out  x102E_CREDIT_RAT_ING_5,
                                 out  x102E_CREDIT_RAT_ING_DATE_5,
                                 out  x102E_SIC_CODE,
                                 out  x102E_ADDL_NAICS_1,
                                 out  x102E_ADDL_NAICS_1_PCT,
                                 out  x102E_ADDL_NAICS_2,
                                 out  x102E_ADDL_NAICS_2_PCT,
                                 out  x102E_ADDL_NAICS_3,
                                 out  x102E_ADDL_NAICS_3_PCT,
                                 out  x102E_ADDL_NAICS_4,
                                 out  x102E_ADDL_NAICS_4_PCT,
                                 out  x102E_ADDL_NAICS_5,
                                 out  x102E_ADDL_NAICS_5_PCT,
                                 out  x102E_INDUSTRY_A_T_RISK,
                                 out  x102E_INDUSTRY_A_T_RISK_PCT,
                                 out  x102E_SOURCE_CHE_CKED,
                                 out  x102E_DATE_LAST_CHECKED,
                                 out  x102E_RESULT_OF_CHECK,
                                 out  x102E_RESULT_OF_CHK_LIT,
                                 out  x102E_COUNTRY_OF_CITIZEN_1,
                                 out  x102E_COUNTRY_OF_REGISTRATIO,
                                 out  x102E_FOREIGN_PO_LITICAL_IND,
                                 out  x102E_COUNTRY_OF_CITIZEN_2,
                                 out  x102E_US_CITIZEN_IND,
                                 out  x102E_ASSET_SIZ_E,
                                 out  x102C_LOB_NUMBER,
                                 out  x102C_REGION_NUMBER,
                                 out  x102C_SUB_LOB,
                                 out  x102C_GROUP,
                                 out  x102C_MARKET,
                                 out  x102C_USER_HIERARCHY,
                                 out  x102C_LANGUAGE_INDICATOR,
                                 out  x102C_FED_RESERVE_CODE,
                                 out  x102C_STATEMENT_TYPE_LIT,
                                 out  x102C_STATEMENT_FREQ_LIT,
                                 out  x102C_DDA_INTF_ACCOUNT_NUMB,
                                 out  x102C_DDA_INTF_TRANSIT_NUMB,
                                 out  x102C_PURGE_IND,
                                 out  x102C_PURGE_IND_LIT,
                                 out  x102C_ACH_CONSOLID_ATION,
                                 out  x102C_ACH_CONSOL_LIT,
                                 out  x102C_SPECIAL_TYPE_CODE,
                                 out  x102C_SPEC_TYPE_LIT,
                                 out  x102C_HISTORY_REVIEW_CODE,
                                 out  x102C_HISTORY_REV_CODE_LIT,
                                 out  x102C_HISTORY_REVIEW_FREQ,
                                 out  x102C_HISTORY_REV_FREQ_LIT,
                                 out  x102C_DATE_NEXT_HIST_REVIEW,
                                 out  x102C_PRIMARY_DDA_ACCOUNT,
                                 out  x102C_DDA_AMOUNT,
                                 out  x102C_CL_USER_DATE_1,
                                 out  x102C_CL_USER_DATE_2,
                                 out  x102C_CL_USER_CODE_1,
                                 out  x102C_CL_USER_CODE_3,
                                 out  x102C_CL_USER_NUMERIC,
                                 out  x102C_CL_USER_AMOUNT,
                                 out  x102C_ORGID_1,
                                 out  x102C_ORGID_2,
                                 out  x102C_NAME_ADD_NUMBER,
                                 out  x102C_NA_CR_BU_CD,
                                 out  x102C_NAME,
                                 out  x102C_GTS_BASE_NUMBER,
                                 out  x102D_EXPOSURE_STRAT_CODE,
                                 out  x102D_EXPOSURE_STRAT_AMT,
                                 out  x102D_EXPOSURE_STRAT_DT,
                                 out  x102D_CONTACT_TYPE,
                                 out  x102D_CONTACT_NAME,
                                 out  x102D_OBLIGOR_DESC_ONE,
                                 out  x102D_OBLIGOR_DESC_TWO,
                                 out  x102D_OBLIGOR_DESC_THREE,
                                 out  x102D_AM_BEST_R_ATING,
                                 out  x102D_AM_BEST_RATING_LIT,
                                 out  x102D_AM_BEST_F_IN_SIZE_CAT,
                                 out  x102D_AM_BEST_FIN_CAT_LIT,
                                 out  x102D_STATE_CODE,
                                 out  x102D_TAX_AUTHORTY_NUMBER,
                                 out  x102D_COUNTY_CODE,
                                 out  x102D_CHECK_OPT_ION,
                                 out  x102D_TOWNSHIP_CODE,
                                 out  x102D_DISB_TAPE_FORMAT,
                                 out  x102D_INSTALLMENT_MONTH_1,
                                 out  x102D_INSTALL_MO_1,
                                 out  x102D_INSTALLMENT_MONTH_2,
                                 out  x102D_INSTALL_MO_2,
                                 out  x102D_INSTALLMENT_MONTH_3,
                                 out  x102D_INSTALL_MO_3,
                                 out  x102D_INSTALLMENT_MONTH_4,
                                 out  x102D_INSTALL_MO_4,
                                 out  x102D_DISBURSEMENT_FREQUENCY,
                                 out  x102D_TAX_LIEN_SALES_MONTH,
                                 out  x102D_TAX_LIEN_MONTH,
                                 out  x102D_STI_NUMERIC_A,
                                 out  x102D_STI_NUMERIC_B,
                                 out  x102F_TYPE_OF_TIN_IND,
                                 out  x102F_TYPE_OF_TIN_LIT,
                                 out  x102F_TIN_CERTIFIC_ATION,
                                 out  x102F_TIN_CERT_DAT_E,
                                 out  x102F_TYPE_OF_ID_1,
                                 out  x102F_TYPE_1_LIT,
                                 out  x102F_ID_1_NUMBER,
                                 out  x102F_STATE_OF_ISSUANCE_1,
                                 out  x102F_ISSUANCE_DAT_E_1,
                                 out  x102F_COUNTRY_OF_ISSUANCE_1,
                                 out  x102F_EXPIRATION_D_ATE_1,
                                 out  x102F_TYPE_OF_ID_2,
                                 out  x102F_TYPE_2_LIT,
                                 out  x102F_ID_2_NUMBER,
                                 out  x102F_STATE_OF_ISSUANCE_2,
                                 out  x102F_ISSUANCE_DAT_E_2,
                                 out  x102F_COUNTRY_OF_ISSUANCE_2,
                                 out  x102F_EXPIRATION_D_ATE_2,
                                 out  x102F_TYPE_OF_ID_3,
                                 out  x102F_TYPE_3_LIT,
                                 out  x102F_ID_3_NUMBER,
                                 out  x102F_STATE_OF_ISSUANCE_3,
                                 out  x102F_ISSUANCE_DAT_E_3,
                                 out  x102F_COUNTRY_OF_ISSUANCE_3,
                                 out  x102F_EXPIRATION_D_ATE_3,
                                 out  x102G_STOCK_EXCHANGE,
                                 out  x102G_STOCK_TICKER,
                                 out  x102G_CUSIP_NUMBER,
                                 out  L101_TIME_ZONE,
                                 out  L101_TIME_ZONE_LIT,
                                 out  L101_FAX_NUMBER,
                                 out  L101_E_MAIL_ADDRESS,
                                 out  L101_WEBSITE,
                                 out  x110A_COLL_RECEIV_PLEDGED,
                                 out  x110A_COLL_UNITS_PLEDGED,
                                 out  x110A_COLL_RECEIV_ELIGIBLE,
                                 out  x110A_COLL_UNITS_ELIGIBLE,
                                 out  x110A_COLL_RECEIV_INELGIBLE,
                                 out  x110A_COLL_UNITS_INELGIBLE,
                                 out  x110A_COLL_CURR_VALUE,
                                 out  x110A_COLL_LAST_ACTIVE_DATE,
                                 out  x110A_COLL_NET_AMOUNT,
                                 out  x110A_COLL_LAST_ITEM_NO,
                                 out  x110A_COLL_TOTAL_ITEMS,
                                 out  x110A_TOTAL_ALL_FUTURES,
                                 out  x110A_TOTAL_ALL_UNUSED,
                                 out  x110A_TOTAL_ALL_CURRENTS,
                                 out  x110A_TOTAL_ALL_INTEREST_OUT,
                                 out  x110A_TOTAL_ALL_INDIRECTS,
                                 out  x110A_TOT_LATE_CHRG_DUE,
                                 out  x110A_TOTAL_ALL_INSURANCE,
                                ref ctx);

                return new GetObligorResponse()
                {
                    Errors = errors,
                    x102A_OBLIGOR_TYPE = x102A_OBLIGOR_TYPE,
                    x102A_CREDIT_RATING = x102A_CREDIT_RATING,
                    x102A_DATE_OF_CRED_RATING = x102A_DATE_OF_CRED_RATING,
                    x102A_GEOGRAPHIC_CODE_1 = x102A_GEOGRAPHIC_CODE_1,
                    x102A_GEOGRAPHIC_INDICATOR = x102A_GEOGRAPHIC_INDICATOR,
                    x102A_OBLIGOR_TAX_CLASS = x102A_OBLIGOR_TAX_CLASS,
                    x102A_PERS_INCOME = x102A_PERS_INCOME,
                    x102A_HMDA_GENDER = x102A_HMDA_GENDER,
                    x102A_HMDA_ETHNIC = x102A_HMDA_ETHNIC,
                    x102A_CENTRAL_FILE_REFERENCE = x102A_CENTRAL_FILE_REFERENCE,
                    x102B_USER_CODE_1 = x102B_USER_CODE_1,
                    x102B_USER_CODE_2 = x102B_USER_CODE_2,
                    x102B_USER_AMOUNT = x102B_USER_AMOUNT,
                    x102C_ASSIGNMENT_UNIT = x102C_ASSIGNMENT_UNIT,
                    x102C_CONTACT_OFFICER = x102C_CONTACT_OFFICER,
                    x102C_SERVICE_UNIT = x102C_SERVICE_UNIT,
                    x102C_STATEMENT_TYPE = x102C_STATEMENT_TYPE,
                    x102C_STATEMENT_FREQUENCY = x102C_STATEMENT_FREQUENCY,
                    x102C_DATE_OF_NEXT_STATEMENT = x102C_DATE_OF_NEXT_STATEMENT,
                    x102C_CL_USER_CODE_2 = x102C_CL_USER_CODE_2,
                    x102C_CL_USER_ALPHA = x102C_CL_USER_ALPHA,
                    x102D_CMS_IDENTIFIER = x102D_CMS_IDENTIFIER,
                    x102E_NAICS = x102E_NAICS,
                    L101_NAME = L101_NAME,
                    L101_RECORD_CODE = L101_RECORD_CODE,
                    L101_NAME_CONT = L101_NAME_CONT,
                    L101_LST_ASSGN_ALT_REC = L101_LST_ASSGN_ALT_REC,
                    L101_ADDRESS_LINE_ONE = L101_ADDRESS_LINE_ONE,
                    L101_CUSTOMER_GREETING = L101_CUSTOMER_GREETING,
                    L101_ADDRESS_LINE_TWO = L101_ADDRESS_LINE_TWO,
                    L101_AREA_CODE_1 = L101_AREA_CODE_1,
                    L101_LOCAL_NUM_1 = L101_LOCAL_NUM_1,
                    L101_EXTENSION_1 = L101_EXTENSION_1,
                    L101_ADDRESS_LINE_THREE = L101_ADDRESS_LINE_THREE,
                    L101_AREA_CODE_2 = L101_AREA_CODE_2,
                    L101_LOCAL_NUM_2 = L101_LOCAL_NUM_2,
                    L101_EXTENSION_2 = L101_EXTENSION_2,
                    L101_ADDRESS_LINE_FOUR = L101_ADDRESS_LINE_FOUR,
                    L101_TELEX_NUMBER = L101_TELEX_NUMBER,
                    L101_ADDRESS_LINE_FIVE = L101_ADDRESS_LINE_FIVE,
                    L101_CONTACT_DATE = L101_CONTACT_DATE,
                    L101_ADDRESS_LINE_SIX = L101_ADDRESS_LINE_SIX,
                    L101_SOCIAL_SECURITY = L101_SOCIAL_SECURITY,
                    L101_ADDRESS_LINE7 = L101_ADDRESS_LINE7,
                    L101_TAXID = L101_TAXID,
                    L101_BIRTH_INC_DATE = L101_BIRTH_INC_DATE,
                    x110A_COLL_RECEIV_PLEDGED = x110A_COLL_RECEIV_PLEDGED,
                    x110A_COLL_UNITS_PLEDGED = x110A_COLL_UNITS_PLEDGED,
                    x110A_COLL_RECEIV_ELIGIBLE = x110A_COLL_RECEIV_ELIGIBLE,
                    x110A_COLL_UNITS_ELIGIBLE = x110A_COLL_UNITS_ELIGIBLE,
                    x110A_COLL_RECEIV_INELGIBLE = x110A_COLL_RECEIV_INELGIBLE,
                    x110A_COLL_UNITS_INELGIBLE = x110A_COLL_UNITS_INELGIBLE,
                    x110A_COLL_CURR_VALUE = x110A_COLL_CURR_VALUE,
                    x110A_COLL_LAST_ACTIVE_DATE = x110A_COLL_LAST_ACTIVE_DATE,
                    x110A_COLL_NET_AMOUNT = x110A_COLL_NET_AMOUNT,
                    x110A_COLL_LAST_ITEM_NO = x110A_COLL_LAST_ITEM_NO,
                    x110A_COLL_TOTAL_ITEMS = x110A_COLL_TOTAL_ITEMS,
                    x110A_TOTAL_ALL_FUTURES = x110A_TOTAL_ALL_FUTURES,
                    x110A_TOTAL_ALL_UNUSED = x110A_TOTAL_ALL_UNUSED,
                    x110A_TOTAL_ALL_CURRENTS = x110A_TOTAL_ALL_CURRENTS,
                    x110A_TOTAL_ALL_INTEREST_OUT = x110A_TOTAL_ALL_INTEREST_OUT,
                    x110A_TOTAL_ALL_INDIRECTS = x110A_TOTAL_ALL_INDIRECTS,
                    x110A_TOT_LATE_CHRG_DUE = x110A_TOT_LATE_CHRG_DUE,
                    x110A_TOTAL_ALL_INSURANCE = x110A_TOTAL_ALL_INSURANCE
                };

            }

            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetObligorResponse>(Ex, request, "GetObligor");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }
        }


        /// <summary>
        /// Gets the obligor obligations.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetObligationSummaryResponse GetObligationSummary(GetObligationSummaryRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            var getObligationSummaryDocIn = new InquiryServicesContext.GetObligationSummaryInDocument
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

            LUW_105A_TABLE_00O outputField = new LUW_105A_TABLE_00O { LUWA_OBLN_NUMB = string.Empty, LUWA_PROC_TYPE = string.Empty, LUWA_TAKEDOWN_OBLN = string.Empty, LUWA_TAKEDOWN_OBLR = string.Empty };
            LUW_105A_TABLE_00O[] outputs = new LUW_105A_TABLE_00O[269];
            for (int i = 0; i < 120; i++)
            {
                outputs[i] = outputField;
            }


            try
            {
                inq.GetObligationSummary(ref getObligationSummaryDocIn.LUW_ID,
                           ref getObligationSummaryDocIn.LUW_REQUEST_CODE,
                           ref getObligationSummaryDocIn.LUW_BATCH_ID,
                           ref getObligationSummaryDocIn.LUW_BANK,
                           ref getObligationSummaryDocIn.LUW_OBLIGOR,
                           ref getObligationSummaryDocIn.LUW_OBLIGATION,
                           ref getObligationSummaryDocIn.LUW_ITEM_NBR,
                           ref getObligationSummaryDocIn.SEG_COUNTER,
                           ref getObligationSummaryDocIn.LUW_HEADER_FILLER,
                           ref getObligationSummaryDocIn.LUW_CALLING_APPL,
                           ref getObligationSummaryDocIn.LUW_LENGTH,
                           ref errors,
                           out outputs,
                           ref ctx
                       );

                var obligationSummaryArray = Array.ConvertAll<LUW_105A_TABLE_00O, ObligationSummary>(outputs, delegate(LUW_105A_TABLE_00O output)
                {
                    var obligationSummary = new ObligationSummary()
                    {
                        LUWA_OBLN_NUMB = output.LUWA_OBLN_NUMB,
                        LUWA_PROC_TYPE = output.LUWA_PROC_TYPE,
                        LUWA_TAKEDOWN_OBLN = output.LUWA_TAKEDOWN_OBLN,
                        LUWA_TAKEDOWN_OBLR = output.LUWA_TAKEDOWN_OBLR
                    };
                    return obligationSummary;

                });

                return new GetObligationSummaryResponse() { ObligationSummaryList = obligationSummaryArray.ToList(), Errors = errors };
            }
            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetObligationSummaryResponse>(Ex, request, "GetObligationSummary");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }

        }


        /// <summary>
        /// Gets the obligation.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetObligationResponse GetObligation(GetObligationRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            var getObligationDocIn = new InquiryServicesContext.GetObligationInDocument
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
                SEG_COUNTER = request.Segment
            };

            string x103A_PROC_TYPE;
            string x103A_EFF_DATE;
            string x103A_MATUR_DATE;
            string x103A_EST_MATUR_DATE;
            decimal x103A_ORIG_AMT;
            decimal x103A_CURR_AMT;
            decimal x103A_AVAILABILITY;
            string x103A_TKDOWN_OBLR;
            string x103A_TKDOWN_OBLN;
            decimal x103A_COMMITMENT_BAL;
            string x103B_PREPAY_CODE;
            string x103B_PREPAY_CODE_LIT;
            string x103B_DUR_CODE;
            string x103B_DUR_CODE_LIT;
            string x103B_SECUR_CODE;
            string x103B_SECUR_CODE_LIT;
            string x103B_MARGIN_CODE;
            string x103B_MARGIN_CODE_LIT;
            string x103B_REG_UZ;
            string x103B_REG_UZ_LIT;
            string x103B_TAX_BANK;
            string x103B_TAX_BANK_LIT;
            string x103B_NOTE_RESET_IND;
            string x103B_NOTE_RESET_IND_LIT;
            string x103B_BILL_LIMIT_CODE;
            string x103B_BILL_LIMIT_CODE_LIT;
            string x103B_TRANS_NOTICE;
            string x103B_TRANS_NOTICE_LIT;
            string x103B_1098_INDICATOR;
            string x103B_1098_INDICATOR_LIT;
            string x103C_ORIG_OBLN_DATE;
            decimal x103C_ORIG_OBLN_AMT;
            string x103C_DATE_LAST_RENEWED;
            string x103C_CLOSE_OPT_IND;
            string x103C_CLOSE_OPT_IND_LIT;
            string x103C_CLOSE_IND;
            string x103C_CLOSE_IND_LIT;
            decimal x103C_CLOSE_TOL_AMT;
            string x103C_PD_OFF_NOTICE;
            string x103C_PD_OFF_NOTICE_LIT;
            string x103D_CONT_OFF;
            string x103D_SERV_UNIT;
            string x103D_ASSIGN_UNIT;
            string x103D_FED_CLASS;
            string x103D_OBLN_TYPE;
            string x103D_PURPOSE_CODE;
            string x103D_GEN_LEDG;
            string x103D_COLLAT_TYPE;
            string x103D_LCHG_PRM_REASON;
            string x103D_LCHG_FORMULA_TYPE;
            string x103D_SCHED_BAL_IND;
            string x103E_STAT_CODE;
            string x103E_STAT_CODE_LIT;
            string x103E_FROZEN_STAT_FLAG;
            string x103E_FROZEN_STAT_FLAG_LIT;
            string x103F_EXAM_TYPE_1;
            string x103F_EXAM_TYPE_1_LIT;
            string x103F_EXAM_CLASS_1;
            string x103F_FACILITY_RISK_RATING;
            string x103F_EXAM_DATE_1;
            string x103F_ORIG_TERM_MONTHS;
            string x103F_CREDIT_SCORE;
            string x103F_CREDIT_DATE;
            string x103F_BKVAL_DATE;
            string x103G_COLLECTION_MONITOR;
            string x103G_COLLECTION_MONITOR_LIT;
            string x103G_ALT_NAME_ADR_CD;
            string x103H_CRA_IND;
            string x103H_RT_SITEID;
            string x103H_PROD_DEF_CODE;
            string x103H_BILL_TYPE_CODE;
            string x103H_USER_CODE_1;
            string x103H_USER_DATE_1;
            string x103H_USER_ALPHA;
            string x103K_SPECIAL_CO__INDICATOR;
            string x103K_CREDIT_DESK_REF_NBR;
            string x103K_CASH_FLOW_RATIO;
            string x103K_LOAN_VALUE_RATIO;
            string x103K_REFERRING_OFFICER;
            string x103K_SECONDARY_OFFICER;
            string x103K_AFS_ALPHA_1;
            string x103L_CREDIT_SC_REF_NO;
            string x103L_ORIG_LTV_DATE;
            string x103L_ORIG_LTV;
            string x103L_REFERRING_OFFICER;
            string x103L_UNDERWRITER;
            string x103N_USER_CODE_2;
            string x103N_USER_CODE_3;
            string x1BAA_SBA_STATUS;
            string x1BAA_SBA_STATUS_LIT;
            string x1BAA_SBA_GP_NUMBER;
            string x1BAA_SBA_PROGRAM_NUMBER;
            string x1BAA_APPROVAL_DATE;
            string x1BAA_APPROVAL_AMOUNT;
            string x1BAA_GUARANTEED_PCT;
            string x1BAA_FTA_SERVIC_FEE_PCT;
            string x1BAA_SBA_SOURCE_CODE;
            string x1BAA_SBA_OBGR_NO;
            string x1BAA_SPEC_MAIL_CODE;
            string x1BAA_DATE_SOLD;
            string x1BAA_SETTLEMENT_DATE;
            string x1BAA_SERVICE_FEE_AMT;
            string x1BAA_SERVICE_FEE_PCT;
            string x1BAA_SPREAD_PMT_OPT;
            string x1BAA_SPREAD_PMT_OPT_LIT;
            string x103A_TITLE_CURR_DATE;
            string x103A_POSTED_DATE;
            string x103A_LAST_ACT_DATE;
            string x103A_LAST_CHG_DATE;
            decimal x103A_GUAR_AMT;
            decimal x103A_COLLAT_VALUE;
            decimal x103A_PAID_TO_PRIN;
            decimal x103A_USER_BALANCE;
            decimal x103A_BOOK_VALUE;
            decimal x103A_SCHED_BALANCE;
            decimal x103A_PART_AMT;
            decimal x103A_AMT_TKNDWN;
            decimal x103A_NET_BOOK_VALUE;
            decimal x103A_PROCEEDS;
            decimal x103A_NET_PRIN_TDY;
            decimal x103A_NET_PARTS_TDY;
            decimal x103A_NET_COLLAT_ACTIVITY;
            decimal x103A_NET_INT_TDY;
            string x103A_INTER_COMM;
            string x103A_R;
            string x103A_RS;
            string x103A_RL;
            string x103A_LINE_23_LIT;
            string x103B_PRIN_PD_TO_DT;
            string x103B_PRIN_LAST_BILL_DT;
            string x103B_PRIN_PREV_DUE_DT;
            decimal x103B_PRIN_PAID_MTD;
            decimal x103B_PRIN_PAID_YTD;
            decimal x103B_PRIN_PAID_NOT_BLD;
            decimal x103B_PRIN_WAIVE_AMT;
            decimal x103B_BILL_AGING_AMOUNT;
            decimal x103B_MTHLY_CUM_BAL;
            string x103B_DATE_NEXT_DUE;
            decimal x103B_PREV_YR_AVG_USE;
            string x103B_PRIN_BLD_NT_PD_LT;
            decimal x103B_PRIN_BLD_NOT_PAID;
            decimal x103B_PRIN_PAST_DUE;
            decimal x103B_CAPITALIZED_INT;
            string x103B_DISC_CODE;
            string x103B_MARGIN_PCT;
            string x103B_REDISC_CODE;
            string x103B_ACCR_LIMIT_CODE;
            string x103B_FLOAT_IND;
            string x103B_RT_CHG_NOTICE;
            string x103B_CUST_EXP_IND;
            string x103B_EXCLUDE_CD;
            string x103B_LC_REF_NUMBER;
            string x103B_PREPAY_PENALTY_IND;
            string x103C_RENEW_TIMES;
            string x103C_RENEW_TYPE;
            string x103C_ORIG_MATUR_DATE;
            decimal x103C_ORIG_DISC_AMT;
            string x103C_RENEW_PREV;
            string x103C_RENEW_TO;
            string x103C_RENEWAL_POSTED_DT;
            string x103C_REFINANCED_FROM_OBLN;
            string x103C_REFINANCED_TO_OBLN;
            string x103C_ASSUMED_FROM_OBGR;
            string x103C_ASSUMED_TO_OBGR;
            string x103C_ASSUMED_FROM_OBLN;
            string x103C_ASSUMED_TO_OBLN;
            string x103C_DATE_LAST_EXTEND;
            string x103C_TIMES_EXTEND;
            string x103C_MNTHS_EXTEND;
            string x103C_CLOSE_DT;
            decimal x103C_CLOSE_AMT;
            string x103C_YESTERDAYS_CLOSE;
            string x103C_HI_ADV_IND;
            string x103C_IMA_TKDWN_IND;
            string x103C_FINAL_CLOSE_IND;
            decimal x103C_FINAL_CLOSE_PRIN_ADJ;
            string x103C_FINAL_CLOSE_POST_DATE;
            decimal x103C_FINAL_CLOSE_PRIN_WVE;
            string x103C_WAIVE_EARN_IND;
            string x103C_NON_RESTART_DATE;
            string x103C_OUT_DEBT_DATE;
            string x103D_LAST_WEKLY_DATE;
            string x103D_LAST_DAILY_DATE;
            string x103D_DIVISION;
            string x103D_REGION;
            string x103D_SUB_LOB;
            string x103D_SIC_CODE;
            string x103D_GEOG_CODE;
            string x103D_PNLTY_FORMULA;
            string x103D_GROUP;
            string x103D_MARKET;
            string x103D_CNTL_BRK_U_HIERARCHY;
            string x103D_REAM_INDICATOR;
            string x103D_REAM_BASIS_IND;
            string x103D_REAM_FREQ_MONTHS;
            string x103D_REAM_PRIORITY;
            string x103D_REAM_NXT_SCHD_DT;
            string x103D_LAST_REAM_DATE;
            string x103D_REAM_PERIOD_DATE;
            string x103D_CUST_NOTIFY_DAYS;
            string x103D_REAM_ERR_EFF_DT;
            string x103D_LAST_NOTICE_DATE;
            decimal x103D_CURR_BALLOON;
            string x103D_LAST_CHANGE_DATE;
            decimal x103D_ORIG_BALLOON;
            string x103D_REDISCLOSE_DATE;
            string x103D_TERM_OUT_STATUS;
            string x103D_SCHED_BAL_ROUND;
            string x103D_LEGAL_STATUS;
            string x103D_LEGAL_STATUS_DATE;
            string x103D_ADVANCE_OPT;
            string x103D_CURTAILMENT_OPT;
            string x103D_UNAPPLIED_OPT;
            string x103D_PMT_SPRD_SEQ;
            string x103D_MATURITY_PMT_SPRD;
            string x103E_STAT_DATE;
            string x103E_CHG_OFF_DATE;
            string x103E_NON_PERFM_DT;
            string x103E_CHARGE_OFF_STATUS;
            string x103E_CHG_OFF_RECOV;
            decimal x103E_RECOVERY_AMT_ITD;
            string x103E_E_SUSP_AMORT_DT;
            string x103E_NON_PERFM_OVRD;
            string x103E_ACCRL_MNTR_FLAG;
            string x103E_NON_PERFM_IND;
            string x103E_NON_ACCRL_DATE;
            string x103E_NON_ACCRL_OVRD;
            string x103E_REDUCED_RT_IND;
            string x103E_RENEG_FLAG;
            string x103E_FROZEN_STAT_DATE;
            string x103E_FROZ_OPT;
            string x103E_FROZ_CHG_DAYS;
            string x103E_FROZ_LEAD_DAYS;
            string x103E_FROZ_AUTO_RESUM_DAYS;
            string x103E_FROZ_AUTO_RESUME_DATE;
            decimal x103E_CHARGE_OFF_ITD;
            string x103E_IMPAIRMENT_IND;
            string x103E_IMPAIRMENT_DATE;
            string x103E_DATE_LAST_IMPAIRED;
            decimal x103E_VALUATION_AMT;
            decimal x103E_VALUATION_ALLOWANCE;
            string x103E_VALUATION_DATE;
            string x103E_VALUATION_IND;
            string x103E_MARK_TO_MARKET_PCT;
            decimal x103E_ORIG_SUSPENSE_AMT;
            decimal x103E_LOST_INCOME_MTD;
            decimal x103E_PAID_NON_ACCRL_YTD;
            decimal x103E_LOST_INCOME_QTD;
            decimal x103E_LOST_INCOME_YTD;
            decimal x103F_BKVAL_PRIN_BAL;
            decimal x103F_BKVAL_ORIG_BAL;
            decimal x103F_BKVAL_AMT_TKDOWN;
            decimal x103F_EXAM_AMT_1;
            decimal x103F_BKVAL_INT_OVER;
            string x103F_EXAM_TYPE_2;
            decimal x103F_BKVAL_CHG_OFF_BAL;
            string x103F_EXAM_CLASS_2;
            decimal x103F_BKVAL_USER_BAL;
            string x103F_EXAM_DATE_2;
            decimal x103F_EXAM_AMT_2;
            string x103F_COUP_POST_DATE_REPL;
            string x103F_COUP_REPL_1ST_DUE_DATE;
            string x103F_COUP_REORDER_NUMB;
            string x103F_COUP_ORDER_FREQ;
            string x103F_COUP_DATE_NEXT_ORDER;
            string x103F_NUMB_ORIG_PYMNTS;
            string x103F_OBLGN_XREF_NO;
            string x103G_PASTDUE_DATE;
            decimal x103G_TOT_PAST_DUE_AMT;
            string x103G_CURR_PAST_DUE_DAYS;
            string x103G_ADV_AFTER_MAT_OPT;
            string x103G_PREV_COLLECT_STATUS;
            string x103G_CURR_COLLECT_STATUS;
            string x103G_TIMES_IN_COLLECTION;
            string x103G_COLLECTION_UNIT;
            string x103G_COLLECTION_OFFICER;
            string x103G_PENALTY_BKVAL_DATE;
            string x103G_PENALTY_CONV_DATE;
            string x103G_RET_CHECK_CTR;
            string x103G_TIMES_PAST_30_DAYS;
            string x103G_TIMES_PAST_60_DAYS;
            string x103G_DELINQ_15_COUNTER;
            string x103G_DELINQ_120_COUNTER;
            string x103G_TIMES_PAST_90_DAYS;
            string x103G_DELINQ_30_COUNTER;
            string x103G_DELINQ_150_COUNTER;
            string x103G_TIMES_PAST_120_DAYS;
            string x103G_DELINQ_60_COUNTER;
            string x103G_DELINQ_180_COUNTER;
            string x103G_TIMES_PAST_150_DAYS;
            string x103G_DELINQ_90_COUNTER;
            decimal x103G_MAT_TOLERANCE_PERCENT;
            string x103G_SETTLEMENT_DATE;
            decimal x103G_MAT_TOLERANCE_AMT;
            string x103G_SETTLEMENT_PD;
            string x103G_LOAN_TYPE;
            string x103G_CUSIP_NO;
            string x103G_SNC_CODE;
            string x103G_SNC_ID;
            string x103H_COLL_SHRTGE_CD;
            string x103H_USER_CODE_1_TITLE;
            string x103H_COLL_SHRTGE_DATE;
            string x103H_USER_DATE_2;
            string x103H_USER_CODE_2_TITLE;
            string x103H_USER_CODE_2;
            string x103H_COLL_UNDERMARGIN_DATE;
            string x103H_USER_CODE_3;
            string x103H_COMP_BAL_IND;
            decimal x103H_USER_AMT;
            string x103H_SMSA_CODE;
            string x103H_USER_FIELD_1_TITLE;
            string x103H_USER_FIELD_1;
            decimal x103H_CENSUS_TRACT;
            string x103H_HOEPA_STATUS;
            string x103H_RATE_SPRD;
            string x103H_PROPERTY_TYPE;
            decimal x103H_INCOME_REVENUE;
            string x103H_PURCHASER_TP;
            string x103H_BUDGET_ID;
            string x103H_MASTER_DOC;
            string x103H_FC824;
            string x103H_ACH_DELAY_DAYS;
            string x103H_FC826;
            string x103H_DEFRD_DUE_DATE_IND;
            string x103H_DEFRD_DUE_DATE_DAYS;
            string x103H_UNIT_ACCR_IND;
            string x103H_BALLOON_IND;
            decimal x103H_CONVERSION_PCT;
            string x103H_MATUR_BILL_IND;
            decimal x103H_RISK_WEIGHT_PCT;
            string x103H_TAX_EQUIV_NO;
            string x103H_OBLN_TAX_CLASS;
            decimal x103H_PRIN_OVERDUE;
            decimal x103H_INT_OVERDUE;
            string x103H_BILL_ALONE_IND;
            string x103H_DEAL_NUMBER;
            string x103H_NAICS_CODE;
            string x103K_USER_OFFICER_1;
            string x103K_USER_OFFICER_2;
            string x103K_AFS_ALPHA_2;
            string x103K_USER_OFFICER_3;
            string x103K_AFS_ALPHA_3;
            string x103K_USER_OFFICER_4;
            string x103K_AFS_ALPHA_4;
            string x103K_AFS_ALPHA_5;
            string x103K_PREV_TKDWN_FROM_OBLIGOR;
            string x103K_TIED_TO_POSTING_DATE;
            string x103K_PREV_TKDWN_FROM_OBLIGAT;
            string x103K_UNTIED_FROM_POSTING_DATE;
            string x103K_PREV_PROCESS_TYPE;
            string x103K_ORIG_TIE_UNTIE_ACTIV_DAT;
            string x103K_CRED_BUREAU_ASSOC;
            string x103K_CRED_BUREAU_RPT_IND;
            string x103K_CREDIT_SCORE_TYPE;
            string x103K_CREDIT_SCORE_REF_NUM;
            string x103K_CRED_BUREAU_STATUS_CODE;
            string x103K_CRED_CONS_INFO_IND;
            string x103K_CRED_COMP_COND_CD;
            string x103K_CRED_BUREAU_COMM_IND;
            string x103K_ALT_REC_CD_1;
            string x103K_ALT_ASSOC_CD_1;
            string x103K_DATE_LAST_PR_IN_PYMNT;
            string x103K_ALT_REC_CD_2;
            string x103K_ALT_ASSOC_CD_2;
            decimal x103K_CR_BUR_PAST_DUE;
            string x103K_ALT_REC_CD_3;
            string x103K_ALT_ASSOC_CD_3;
            string x103L_CREDIT_SC;
            string x103L_CREDIT_SC_DT;
            string x103L_CREDIT_SC_TYPE;
            string x103L_DEBT_INCOME_RATIO;
            string x103L_CURRENT_LTV;
            string x103L_APPL_DATE;
            decimal x103L_DEBT_AMOUNT;
            string x103L_CONTRACT_ADDS;
            decimal x103L_LC_CAP_AMOUNT;
            string x103L_PRODUCT;
            string x103L_CAMPAIGN;
            string x103L_PROGRAM;
            string x103L_APPL_SOURCE;
            string x103L_WORKPACKAGE_NO;
            string x103L_APPL_OVERRIDE_IND;
            string x103L_WORKPACKAGE_TYPE;
            string x103L_FINAL_APPROVAL_OFFICER;
            string x103L_CREDIT_RVW_OFFICER;
            string x103L_CREDIT_LST_REV_DT;
            string x103L_EXCEPT_APPROVAL_OFFICER;
            string x103L_OCCUPANCY;
            string x103M_APPRAISAL_TYPE;
            string x103M_APPRAISER;
            string x103M_APPRAISAL_DATE;
            decimal x103M_APPRAISAL_AMT;
            decimal x103M_ORIG_RE_LTV;
            decimal x103M_ORIG_RE_APPL_AMT;
            decimal x103M_CURR_RE_LTV;
            decimal x103M_CURR_RE_APPL_AMT;
            string x103M_NUM_PROP;
            int x103M_TOT_OFF_SF;
            decimal x103M_NUM_UNITS;
            int x103M_TOT_RES_SF;
            int x103M_NUM_RES_ROOM;
            int x103M_TOT_RETAIL_SF;
            int x103M_TOT_COMM_SF;
            string x103M_TOT_ACREAGE;
            decimal x103M_TOT_RENT_SF;
            decimal x103M_TOT_BLDG_SF;
            decimal x103M_FIRST_LIEN_AMT;
            string x103M_LIEN_POSITION;
            string x103M_LIEN_HOLDER_NAME;
            string x103M_OLD_LOAN_NUMBER;
            string x103M_SYSTEM_CONV_FROM;
            string x103N_AFS_COMM_OBLIGOR;
            string x103N_AFS_COMM_OBLIGATION;
            string x103N_U_NUMERIC3;
            string x103N_ORIGINATING_RU;
            string x103N_USER_STI_NUMERIC_A;
            string x103N_LAST_REPRICE_INDEX;
            string x103N_USER_STI_NUMERIC_B;
            string x103N_CALL_DATE;
            string x103N_USER_ALPHA_5;
            string x103N_COMMIT_DATE;
            string x103O_CONTIGUOUS_PROPERTY_IND;
            string x103O_ORIG_AMORTIZATION_DATE;
            string x103O_LOAN_REN_CODE;
            string x103O_MODIFICATION_DATE;
            string x103O_RENEWAL_DATE;
            string x103O_INDEX_NAME;
            string x103O_ADV_NOTICE_PERIOD;
            decimal x103O_INDEX_RATE;
            string x103O_REN_PAYMENT_TY;
            string x103O_INDEX_DATE;
            string x103O_SECONDARY_FIN_IND;
            decimal x103O_MARGIN1;
            string x103O_AMORTIZATION_TERM;
            decimal x103O_FEE_PERCENT;
            string x103O_BALLOON_DATE;
            decimal x103O_FEE_AMOUNT;
            string x103O_CALL_DATE;
            string x103O_FEE_BAL_TYPE;
            string x103O_COMMENTS;
            string x103O_REFI_BANK1;
            string x103O_REFI_OBLIGOR1;
            string x103O_REFI_OBLIGATION1;
            decimal x103O_REFI_AMOUNT1;
            string x103O_REFI_BANK2;
            string x103O_REFI_OBLIGOR2;
            string x103O_REFI_OBLIGATION2;
            decimal x103O_REFI_AMOUNT2;
            string x103O_REFI_BANK3;
            string x103O_REFI_OBLIGOR3;
            string x103O_REFI_OBLIGATION3;
            decimal x103O_REFI_AMOUNT3;
            string x103O_REFI_BANK4;
            string x103O_REFI_OBLIGOR4;
            string x103O_REFI_OBLIGATION4;
            decimal x103O_REFI_AMOUNT4;
            string x103O_REFI_BANK5;
            string x103O_REFI_OBLIGOR5;
            string x103O_REFI_OBLIGATION5;
            decimal x103O_REFI_AMOUNT5;
            decimal x103P_TOTAL_EXPENSE;
            string x103P_LAST_FISCAL_YEAR;
            decimal x103P_NET_OPERATION_INCOME;
            string x103P_FISCAL_YEAR_MONTH;
            decimal x103P_TOTAL_DEBT_SERVICE;
            string x103P_DEBT_SERVICE_CHARGE;
            decimal x103P_GROSS_INCOME;
            string x103P_EXPENSE_RATIO;
            decimal x103P_ROOM_EGI;
            string x103P_RENT_ROLL_DATE;
            decimal x103P_SF_EGI;
            decimal x103P_NOTE_RATE;
            string x103P_LOAN_GRADE;
            string x103P_CD_CC_IND;
            string x103P_SWAP_IND;
            decimal x103P_NON_RE_COLLATERAL_PERC;
            decimal x103P_RE_COLLATERAL_PERCENT;
            decimal x103P_RE_LTV;
            string x103P_LAST_INSPECT_DATE;
            decimal x103P_44XX_TOL_OVER_AMT;
            decimal x103P_44XX_TOL_SHORT_AMT;
            short x103P_44XX_TOL_OVER_PCT;
            decimal x103P_44XX_TOL_SHORT_PCT;
            string x103P_PMT_PRE_JAN;
            string x103P_PMT_PRE_FEB;
            string x103P_PMT_PRE_MAR;
            string x103P_PMT_PRE_APR;
            string x103P_PMT_PRE_MAY;
            string x103P_PMT_PRE_JUN;
            string x103P_PMT_PRE_JUL;
            string x103P_PMT_PRE_AUG;
            string x103P_PMT_PRE_SEP;
            string x103P_PMT_PRE_OCT;
            string x103P_PMT_PRE_NOV;
            string x103P_PMT_PRE_DEC;
            string x103P_PMT_CUR_JAN;
            string x103P_PMT_CUR_FEB;
            string x103P_PMT_CUR_MAR;
            string x103P_PMT_CUR_APR;
            string x103P_PMT_CUR_MAY;
            string x103P_PMT_CUR_JUN;
            string x103P_PMT_CUR_JUL;
            string x103P_PMT_CUR_AUG;
            string x103P_PMT_CUR_SEP;
            string x103P_PMT_CUR_OCT;
            string x103P_PMT_CUR_NOV;
            string x103P_PMT_CUR_DEC;
            string x103I_DATA_PRESENT_SW;
            string x103I_INDIC_DATA_YEAR;
            string x103I_INDIC_DATA_TYPE;
            string x103I_INDIC_DATA_MAKE;
            string x103I_INDIC_DATA_MODEL;
            string x103I_INDIC_DATA_SERIAL;
            string x103I_INDIC_DATA_ADDRESS_1;
            string x103I_INDIC_DATA_ADDRESS_2;
            string x103I_INDIC_DATA_CITY;
            string x103I_INDIC_DATA_STATE;
            string x103I_INDIC_DATA_ZIP_CODE;
            decimal x103I_INDIC_DATA_USER_AMOUNT;
            string x103I_INDIC_DATA_USER_CODE;
            string x103I_INDIC_DATA_DATE_RECVD;
            string x103I_INDIC_DATA_DATE_REL;
            string x103I_INDIC_DATA_LOC_RECVD;
            string x103I_INDIC_DATA_LOC_HELD;
            string x103I_DISPOSITION_ONE;
            string x103I_INDIC_DATA_ID_NUMBER;
            string x103I_DISPOSITION_TWO;
            string x103I_INDIC_DATA_FILING_REF;
            string x103I_DISPOSITION_THREE;
            string x103I_INDIC_DATA_DESC_1;
            string x103I_INDIC_DATA_DESC_2;
            string x103I_PDI_REQ_CODE;
            string x103I_PDI_STATUS_CODE;
            string x103I_PDI_POLICY_NUMB;
            string x103I_PDI_STATUS_DATE;
            string x103I_PDI_COMPANY;
            string x103I_PDI_EXP_DATE;
            string x103I_PDI_AGENT_NAME;
            string x103J_DATA_PRESENT_SW;
            string x103J_FORE_ABAND_POST_DATE;
            string x103J_FORE_ABAND_DATE;
            string x103J_LIABILITY_IND;
            decimal x103J_OUTSTANDING_BAL;
            decimal x103J_FORE_BID_PRICE;
            decimal x103J_APPRAISAL_VALUE;
            string x103J_DESC_1;
            string x103J_DESC_2;
            decimal x103J_ODD_DAYS_INT_AMT;
            string x103J_DAYS_TO_CHG_PAYOFF;
            string x103J_ODD_DAYS_EARN_IND;
            string x103J_DAYS_TO_CHG_INS;
            decimal x103J_PART_PAYMENT;
            string x103J_NUMB_PAYMENTS_MADE;
            decimal x103J_AMT_FINANCED;
            string x103J_COLL_RECD_IND;
            string x103J_PREPAID_FIN_CHGS;
            string x103J_VARY_RATE_IND;
            decimal x103J_APR;
            string x103J_APR_VERIF_IND;
            string x103J_78TH_EARN_DAY;
            string x103J_78TH_EARN_DAY_INS;
            string x103J_12_MONTH_PYMNT_HIST;


            try
            {
                inq.GetObligation(ref getObligationDocIn.LUW_ID,
                             ref getObligationDocIn.LUW_REQUEST_CODE,
                             ref getObligationDocIn.LUW_BATCH_ID,
                             ref getObligationDocIn.LUW_BANK,
                             ref getObligationDocIn.LUW_OBLIGOR,
                             ref getObligationDocIn.LUW_OBLIGATION,
                             ref getObligationDocIn.LUW_ITEM_NBR,
                             ref getObligationDocIn.SEG_COUNTER,
                             ref getObligationDocIn.LUW_HEADER_RESTRICTIONS,
                             ref getObligationDocIn.LUW_LENGTH,
                             ref errors,
                             out  x103A_PROC_TYPE,
                             out  x103A_EFF_DATE,
                             out  x103A_MATUR_DATE,
                             out  x103A_EST_MATUR_DATE,
                             out  x103A_ORIG_AMT,
                             out  x103A_CURR_AMT,
                             out  x103A_AVAILABILITY,
                             out  x103A_TKDOWN_OBLR,
                             out  x103A_TKDOWN_OBLN,
                             out  x103A_COMMITMENT_BAL,
                             out  x103B_PREPAY_CODE,
                             out  x103B_PREPAY_CODE_LIT,
                             out  x103B_DUR_CODE,
                             out  x103B_DUR_CODE_LIT,
                             out  x103B_SECUR_CODE,
                             out  x103B_SECUR_CODE_LIT,
                             out  x103B_MARGIN_CODE,
                             out  x103B_MARGIN_CODE_LIT,
                             out  x103B_REG_UZ,
                             out  x103B_REG_UZ_LIT,
                             out  x103B_TAX_BANK,
                             out  x103B_TAX_BANK_LIT,
                             out  x103B_NOTE_RESET_IND,
                             out  x103B_NOTE_RESET_IND_LIT,
                             out  x103B_BILL_LIMIT_CODE,
                             out  x103B_BILL_LIMIT_CODE_LIT,
                             out  x103B_TRANS_NOTICE,
                             out  x103B_TRANS_NOTICE_LIT,
                             out  x103B_1098_INDICATOR,
                             out  x103B_1098_INDICATOR_LIT,
                             out  x103C_ORIG_OBLN_DATE,
                             out  x103C_ORIG_OBLN_AMT,
                             out  x103C_DATE_LAST_RENEWED,
                             out  x103C_CLOSE_OPT_IND,
                             out  x103C_CLOSE_OPT_IND_LIT,
                             out  x103C_CLOSE_IND,
                             out  x103C_CLOSE_IND_LIT,
                             out  x103C_CLOSE_TOL_AMT,
                             out  x103C_PD_OFF_NOTICE,
                             out  x103C_PD_OFF_NOTICE_LIT,
                             out  x103D_CONT_OFF,
                             out  x103D_SERV_UNIT,
                             out  x103D_ASSIGN_UNIT,
                             out  x103D_FED_CLASS,
                             out  x103D_OBLN_TYPE,
                             out  x103D_PURPOSE_CODE,
                             out  x103D_GEN_LEDG,
                             out  x103D_COLLAT_TYPE,
                             out  x103D_LCHG_PRM_REASON,
                             out  x103D_LCHG_FORMULA_TYPE,
                             out  x103D_SCHED_BAL_IND,
                             out  x103E_STAT_CODE,
                             out  x103E_STAT_CODE_LIT,
                             out  x103E_FROZEN_STAT_FLAG,
                             out  x103E_FROZEN_STAT_FLAG_LIT,
                             out  x103F_EXAM_TYPE_1,
                             out  x103F_EXAM_TYPE_1_LIT,
                             out  x103F_EXAM_CLASS_1,
                             out  x103F_FACILITY_RISK_RATING,
                             out  x103F_EXAM_DATE_1,
                             out  x103F_ORIG_TERM_MONTHS,
                             out  x103F_CREDIT_SCORE,
                             out  x103F_CREDIT_DATE,
                             out  x103F_BKVAL_DATE,
                             out  x103G_COLLECTION_MONITOR,
                             out  x103G_COLLECTION_MONITOR_LIT,
                             out  x103G_ALT_NAME_ADR_CD,
                             out  x103H_CRA_IND,
                             out  x103H_RT_SITEID,
                             out  x103H_PROD_DEF_CODE,
                             out  x103H_BILL_TYPE_CODE,
                             out  x103H_USER_CODE_1,
                             out  x103H_USER_DATE_1,
                             out  x103H_USER_ALPHA,
                             out  x103K_SPECIAL_CO__INDICATOR,
                             out  x103K_CREDIT_DESK_REF_NBR,
                             out  x103K_CASH_FLOW_RATIO,
                             out  x103K_LOAN_VALUE_RATIO,
                             out  x103K_REFERRING_OFFICER,
                             out  x103K_SECONDARY_OFFICER,
                             out  x103K_AFS_ALPHA_1,
                             out  x103L_CREDIT_SC_REF_NO,
                             out  x103L_ORIG_LTV_DATE,
                             out  x103L_ORIG_LTV,
                             out  x103L_REFERRING_OFFICER,
                             out  x103L_UNDERWRITER,
                             out  x103N_USER_CODE_2,
                             out  x103N_USER_CODE_3,
                             out  x1BAA_SBA_STATUS,
                             out  x1BAA_SBA_STATUS_LIT,
                             out  x1BAA_SBA_GP_NUMBER,
                             out  x1BAA_SBA_PROGRAM_NUMBER,
                             out  x1BAA_APPROVAL_DATE,
                             out  x1BAA_APPROVAL_AMOUNT,
                             out  x1BAA_GUARANTEED_PCT,
                             out  x1BAA_FTA_SERVIC_FEE_PCT,
                             out  x1BAA_SBA_SOURCE_CODE,
                             out  x1BAA_SBA_OBGR_NO,
                             out  x1BAA_SPEC_MAIL_CODE,
                             out  x1BAA_DATE_SOLD,
                             out  x1BAA_SETTLEMENT_DATE,
                             out  x1BAA_SERVICE_FEE_AMT,
                             out  x1BAA_SERVICE_FEE_PCT,
                             out  x1BAA_SPREAD_PMT_OPT,
                             out  x1BAA_SPREAD_PMT_OPT_LIT,
                             out  x103A_TITLE_CURR_DATE,
                             out  x103A_POSTED_DATE,
                             out  x103A_LAST_ACT_DATE,
                             out  x103A_LAST_CHG_DATE,
                             out  x103A_GUAR_AMT,
                             out  x103A_COLLAT_VALUE,
                             out  x103A_PAID_TO_PRIN,
                             out  x103A_USER_BALANCE,
                             out  x103A_BOOK_VALUE,
                             out  x103A_SCHED_BALANCE,
                             out  x103A_PART_AMT,
                             out  x103A_AMT_TKNDWN,
                             out  x103A_NET_BOOK_VALUE,
                             out  x103A_PROCEEDS,
                             out  x103A_NET_PRIN_TDY,
                             out  x103A_NET_PARTS_TDY,
                             out  x103A_NET_COLLAT_ACTIVITY,
                             out  x103A_NET_INT_TDY,
                             out  x103A_INTER_COMM,
                             out  x103A_R,
                             out  x103A_RS,
                             out  x103A_RL,
                             out  x103A_LINE_23_LIT,
                             out  x103B_PRIN_PD_TO_DT,
                             out  x103B_PRIN_LAST_BILL_DT,
                             out  x103B_PRIN_PREV_DUE_DT,
                             out  x103B_PRIN_PAID_MTD,
                             out  x103B_PRIN_PAID_YTD,
                             out  x103B_PRIN_PAID_NOT_BLD,
                             out  x103B_PRIN_WAIVE_AMT,
                             out  x103B_BILL_AGING_AMOUNT,
                             out  x103B_MTHLY_CUM_BAL,
                             out  x103B_DATE_NEXT_DUE,
                             out  x103B_PREV_YR_AVG_USE,
                             out  x103B_PRIN_BLD_NT_PD_LT,
                             out  x103B_PRIN_BLD_NOT_PAID,
                             out  x103B_PRIN_PAST_DUE,
                             out  x103B_CAPITALIZED_INT,
                             out  x103B_DISC_CODE,
                             out  x103B_MARGIN_PCT,
                             out  x103B_REDISC_CODE,
                             out  x103B_ACCR_LIMIT_CODE,
                             out  x103B_FLOAT_IND,
                             out  x103B_RT_CHG_NOTICE,
                             out  x103B_CUST_EXP_IND,
                             out  x103B_EXCLUDE_CD,
                             out  x103B_LC_REF_NUMBER,
                             out  x103B_PREPAY_PENALTY_IND,
                             out  x103C_RENEW_TIMES,
                             out  x103C_RENEW_TYPE,
                             out  x103C_ORIG_MATUR_DATE,
                             out  x103C_ORIG_DISC_AMT,
                             out  x103C_RENEW_PREV,
                             out  x103C_RENEW_TO,
                             out  x103C_RENEWAL_POSTED_DT,
                             out  x103C_REFINANCED_FROM_OBLN,
                             out  x103C_REFINANCED_TO_OBLN,
                             out  x103C_ASSUMED_FROM_OBGR,
                             out  x103C_ASSUMED_TO_OBGR,
                             out  x103C_ASSUMED_FROM_OBLN,
                             out  x103C_ASSUMED_TO_OBLN,
                             out  x103C_DATE_LAST_EXTEND,
                             out  x103C_TIMES_EXTEND,
                             out  x103C_MNTHS_EXTEND,
                             out  x103C_CLOSE_DT,
                             out  x103C_CLOSE_AMT,
                             out  x103C_YESTERDAYS_CLOSE,
                             out  x103C_HI_ADV_IND,
                             out  x103C_IMA_TKDWN_IND,
                             out  x103C_FINAL_CLOSE_IND,
                             out  x103C_FINAL_CLOSE_PRIN_ADJ,
                             out  x103C_FINAL_CLOSE_POST_DATE,
                             out  x103C_FINAL_CLOSE_PRIN_WVE,
                             out  x103C_WAIVE_EARN_IND,
                             out  x103C_NON_RESTART_DATE,
                             out  x103C_OUT_DEBT_DATE,
                             out  x103D_LAST_WEKLY_DATE,
                             out  x103D_LAST_DAILY_DATE,
                             out  x103D_DIVISION,
                             out  x103D_REGION,
                             out  x103D_SUB_LOB,
                             out  x103D_SIC_CODE,
                             out  x103D_GEOG_CODE,
                             out  x103D_PNLTY_FORMULA,
                             out  x103D_GROUP,
                             out  x103D_MARKET,
                             out  x103D_CNTL_BRK_U_HIERARCHY,
                             out  x103D_REAM_INDICATOR,
                             out  x103D_REAM_BASIS_IND,
                             out  x103D_REAM_FREQ_MONTHS,
                             out  x103D_REAM_PRIORITY,
                             out  x103D_REAM_NXT_SCHD_DT,
                             out  x103D_LAST_REAM_DATE,
                             out  x103D_REAM_PERIOD_DATE,
                             out  x103D_CUST_NOTIFY_DAYS,
                             out  x103D_REAM_ERR_EFF_DT,
                             out  x103D_LAST_NOTICE_DATE,
                             out  x103D_CURR_BALLOON,
                             out  x103D_LAST_CHANGE_DATE,
                             out  x103D_ORIG_BALLOON,
                             out  x103D_REDISCLOSE_DATE,
                             out  x103D_TERM_OUT_STATUS,
                             out  x103D_SCHED_BAL_ROUND,
                             out  x103D_LEGAL_STATUS,
                             out  x103D_LEGAL_STATUS_DATE,
                             out  x103D_ADVANCE_OPT,
                             out  x103D_CURTAILMENT_OPT,
                             out  x103D_UNAPPLIED_OPT,
                             out  x103D_PMT_SPRD_SEQ,
                             out  x103D_MATURITY_PMT_SPRD,
                             out  x103E_STAT_DATE,
                             out  x103E_CHG_OFF_DATE,
                             out  x103E_NON_PERFM_DT,
                             out  x103E_CHARGE_OFF_STATUS,
                             out  x103E_CHG_OFF_RECOV,
                             out  x103E_RECOVERY_AMT_ITD,
                             out  x103E_E_SUSP_AMORT_DT,
                             out  x103E_NON_PERFM_OVRD,
                             out  x103E_ACCRL_MNTR_FLAG,
                             out  x103E_NON_PERFM_IND,
                             out  x103E_NON_ACCRL_DATE,
                             out  x103E_NON_ACCRL_OVRD,
                             out  x103E_REDUCED_RT_IND,
                             out  x103E_RENEG_FLAG,
                             out  x103E_FROZEN_STAT_DATE,
                             out  x103E_FROZ_OPT,
                             out  x103E_FROZ_CHG_DAYS,
                             out  x103E_FROZ_LEAD_DAYS,
                             out  x103E_FROZ_AUTO_RESUM_DAYS,
                             out  x103E_FROZ_AUTO_RESUME_DATE,
                             out  x103E_CHARGE_OFF_ITD,
                             out  x103E_IMPAIRMENT_IND,
                             out  x103E_IMPAIRMENT_DATE,
                             out  x103E_DATE_LAST_IMPAIRED,
                             out  x103E_VALUATION_AMT,
                             out  x103E_VALUATION_ALLOWANCE,
                             out  x103E_VALUATION_DATE,
                             out  x103E_VALUATION_IND,
                             out  x103E_MARK_TO_MARKET_PCT,
                             out  x103E_ORIG_SUSPENSE_AMT,
                             out  x103E_LOST_INCOME_MTD,
                             out  x103E_PAID_NON_ACCRL_YTD,
                             out  x103E_LOST_INCOME_QTD,
                             out  x103E_LOST_INCOME_YTD,
                             out  x103F_BKVAL_PRIN_BAL,
                             out  x103F_BKVAL_ORIG_BAL,
                             out  x103F_BKVAL_AMT_TKDOWN,
                             out  x103F_EXAM_AMT_1,
                             out  x103F_BKVAL_INT_OVER,
                             out  x103F_EXAM_TYPE_2,
                             out  x103F_BKVAL_CHG_OFF_BAL,
                             out  x103F_EXAM_CLASS_2,
                             out  x103F_BKVAL_USER_BAL,
                             out  x103F_EXAM_DATE_2,
                             out  x103F_EXAM_AMT_2,
                             out  x103F_COUP_POST_DATE_REPL,
                             out  x103F_COUP_REPL_1ST_DUE_DATE,
                             out  x103F_COUP_REORDER_NUMB,
                             out  x103F_COUP_ORDER_FREQ,
                             out  x103F_COUP_DATE_NEXT_ORDER,
                             out  x103F_NUMB_ORIG_PYMNTS,
                             out  x103F_OBLGN_XREF_NO,
                             out  x103G_PASTDUE_DATE,
                             out  x103G_TOT_PAST_DUE_AMT,
                             out  x103G_CURR_PAST_DUE_DAYS,
                             out  x103G_ADV_AFTER_MAT_OPT,
                             out  x103G_PREV_COLLECT_STATUS,
                             out  x103G_CURR_COLLECT_STATUS,
                             out  x103G_TIMES_IN_COLLECTION,
                             out  x103G_COLLECTION_UNIT,
                             out  x103G_COLLECTION_OFFICER,
                             out  x103G_PENALTY_BKVAL_DATE,
                             out  x103G_PENALTY_CONV_DATE,
                             out  x103G_RET_CHECK_CTR,
                             out  x103G_TIMES_PAST_30_DAYS,
                             out  x103G_TIMES_PAST_60_DAYS,
                             out  x103G_DELINQ_15_COUNTER,
                             out  x103G_DELINQ_120_COUNTER,
                             out  x103G_TIMES_PAST_90_DAYS,
                             out  x103G_DELINQ_30_COUNTER,
                             out  x103G_DELINQ_150_COUNTER,
                             out  x103G_TIMES_PAST_120_DAYS,
                             out  x103G_DELINQ_60_COUNTER,
                             out  x103G_DELINQ_180_COUNTER,
                             out  x103G_TIMES_PAST_150_DAYS,
                             out  x103G_DELINQ_90_COUNTER,
                             out  x103G_MAT_TOLERANCE_PERCENT,
                             out  x103G_SETTLEMENT_DATE,
                             out  x103G_MAT_TOLERANCE_AMT,
                             out  x103G_SETTLEMENT_PD,
                             out  x103G_LOAN_TYPE,
                             out  x103G_CUSIP_NO,
                             out  x103G_SNC_CODE,
                             out  x103G_SNC_ID,
                             out  x103H_COLL_SHRTGE_CD,
                             out  x103H_USER_CODE_1_TITLE,
                             out  x103H_COLL_SHRTGE_DATE,
                             out  x103H_USER_DATE_2,
                             out  x103H_USER_CODE_2_TITLE,
                             out  x103H_USER_CODE_2,
                             out  x103H_COLL_UNDERMARGIN_DATE,
                             out  x103H_USER_CODE_3,
                             out  x103H_COMP_BAL_IND,
                             out  x103H_USER_AMT,
                             out  x103H_SMSA_CODE,
                             out  x103H_USER_FIELD_1_TITLE,
                             out  x103H_USER_FIELD_1,
                             out  x103H_CENSUS_TRACT,
                             out  x103H_HOEPA_STATUS,
                             out  x103H_RATE_SPRD,
                             out  x103H_PROPERTY_TYPE,
                             out  x103H_INCOME_REVENUE,
                             out  x103H_PURCHASER_TP,
                             out  x103H_BUDGET_ID,
                             out  x103H_MASTER_DOC,
                             out  x103H_FC824,
                             out  x103H_ACH_DELAY_DAYS,
                             out  x103H_FC826,
                             out  x103H_DEFRD_DUE_DATE_IND,
                             out  x103H_DEFRD_DUE_DATE_DAYS,
                             out  x103H_UNIT_ACCR_IND,
                             out  x103H_BALLOON_IND,
                             out  x103H_CONVERSION_PCT,
                             out  x103H_MATUR_BILL_IND,
                             out  x103H_RISK_WEIGHT_PCT,
                             out  x103H_TAX_EQUIV_NO,
                             out  x103H_OBLN_TAX_CLASS,
                             out  x103H_PRIN_OVERDUE,
                             out  x103H_INT_OVERDUE,
                             out  x103H_BILL_ALONE_IND,
                             out  x103H_DEAL_NUMBER,
                             out  x103H_NAICS_CODE,
                             out  x103K_USER_OFFICER_1,
                             out  x103K_USER_OFFICER_2,
                             out  x103K_AFS_ALPHA_2,
                             out  x103K_USER_OFFICER_3,
                             out  x103K_AFS_ALPHA_3,
                             out  x103K_USER_OFFICER_4,
                             out  x103K_AFS_ALPHA_4,
                             out  x103K_AFS_ALPHA_5,
                             out  x103K_PREV_TKDWN_FROM_OBLIGOR,
                             out  x103K_TIED_TO_POSTING_DATE,
                             out  x103K_PREV_TKDWN_FROM_OBLIGAT,
                             out  x103K_UNTIED_FROM_POSTING_DATE,
                             out  x103K_PREV_PROCESS_TYPE,
                             out  x103K_ORIG_TIE_UNTIE_ACTIV_DAT,
                             out  x103K_CRED_BUREAU_ASSOC,
                             out  x103K_CRED_BUREAU_RPT_IND,
                             out  x103K_CREDIT_SCORE_TYPE,
                             out  x103K_CREDIT_SCORE_REF_NUM,
                             out  x103K_CRED_BUREAU_STATUS_CODE,
                             out  x103K_CRED_CONS_INFO_IND,
                             out  x103K_CRED_COMP_COND_CD,
                             out  x103K_CRED_BUREAU_COMM_IND,
                             out  x103K_ALT_REC_CD_1,
                             out  x103K_ALT_ASSOC_CD_1,
                             out  x103K_DATE_LAST_PR_IN_PYMNT,
                             out  x103K_ALT_REC_CD_2,
                             out  x103K_ALT_ASSOC_CD_2,
                             out  x103K_CR_BUR_PAST_DUE,
                             out  x103K_ALT_REC_CD_3,
                             out  x103K_ALT_ASSOC_CD_3,
                             out  x103L_CREDIT_SC,
                             out  x103L_CREDIT_SC_DT,
                             out  x103L_CREDIT_SC_TYPE,
                             out  x103L_DEBT_INCOME_RATIO,
                             out  x103L_CURRENT_LTV,
                             out  x103L_APPL_DATE,
                             out  x103L_DEBT_AMOUNT,
                             out  x103L_CONTRACT_ADDS,
                             out  x103L_LC_CAP_AMOUNT,
                             out  x103L_PRODUCT,
                             out  x103L_CAMPAIGN,
                             out  x103L_PROGRAM,
                             out  x103L_APPL_SOURCE,
                             out  x103L_WORKPACKAGE_NO,
                             out  x103L_APPL_OVERRIDE_IND,
                             out  x103L_WORKPACKAGE_TYPE,
                             out  x103L_FINAL_APPROVAL_OFFICER,
                             out  x103L_CREDIT_RVW_OFFICER,
                             out  x103L_CREDIT_LST_REV_DT,
                             out  x103L_EXCEPT_APPROVAL_OFFICER,
                             out  x103L_OCCUPANCY,
                             out  x103M_APPRAISAL_TYPE,
                             out  x103M_APPRAISER,
                             out  x103M_APPRAISAL_DATE,
                             out  x103M_APPRAISAL_AMT,
                             out  x103M_ORIG_RE_LTV,
                             out  x103M_ORIG_RE_APPL_AMT,
                             out  x103M_CURR_RE_LTV,
                             out  x103M_CURR_RE_APPL_AMT,
                             out  x103M_NUM_PROP,
                             out  x103M_TOT_OFF_SF,
                             out  x103M_NUM_UNITS,
                             out  x103M_TOT_RES_SF,
                             out  x103M_NUM_RES_ROOM,
                             out  x103M_TOT_RETAIL_SF,
                             out  x103M_TOT_COMM_SF,
                             out  x103M_TOT_ACREAGE,
                             out  x103M_TOT_RENT_SF,
                             out  x103M_TOT_BLDG_SF,
                             out  x103M_FIRST_LIEN_AMT,
                             out  x103M_LIEN_POSITION,
                             out  x103M_LIEN_HOLDER_NAME,
                             out  x103M_OLD_LOAN_NUMBER,
                             out  x103M_SYSTEM_CONV_FROM,
                             out  x103N_AFS_COMM_OBLIGOR,
                             out  x103N_AFS_COMM_OBLIGATION,
                             out  x103N_U_NUMERIC3,
                             out  x103N_ORIGINATING_RU,
                             out  x103N_USER_STI_NUMERIC_A,
                             out  x103N_LAST_REPRICE_INDEX,
                             out  x103N_USER_STI_NUMERIC_B,
                             out  x103N_CALL_DATE,
                             out  x103N_USER_ALPHA_5,
                             out  x103N_COMMIT_DATE,
                             out  x103O_CONTIGUOUS_PROPERTY_IND,
                             out  x103O_ORIG_AMORTIZATION_DATE,
                             out  x103O_LOAN_REN_CODE,
                             out  x103O_MODIFICATION_DATE,
                             out  x103O_RENEWAL_DATE,
                             out  x103O_INDEX_NAME,
                             out  x103O_ADV_NOTICE_PERIOD,
                             out  x103O_INDEX_RATE,
                             out  x103O_REN_PAYMENT_TY,
                             out  x103O_INDEX_DATE,
                             out  x103O_SECONDARY_FIN_IND,
                             out  x103O_MARGIN1,
                             out  x103O_AMORTIZATION_TERM,
                             out  x103O_FEE_PERCENT,
                             out  x103O_BALLOON_DATE,
                             out  x103O_FEE_AMOUNT,
                             out  x103O_CALL_DATE,
                             out  x103O_FEE_BAL_TYPE,
                             out  x103O_COMMENTS,
                             out  x103O_REFI_BANK1,
                             out  x103O_REFI_OBLIGOR1,
                             out  x103O_REFI_OBLIGATION1,
                             out  x103O_REFI_AMOUNT1,
                             out  x103O_REFI_BANK2,
                             out  x103O_REFI_OBLIGOR2,
                             out  x103O_REFI_OBLIGATION2,
                             out  x103O_REFI_AMOUNT2,
                             out  x103O_REFI_BANK3,
                             out  x103O_REFI_OBLIGOR3,
                             out  x103O_REFI_OBLIGATION3,
                             out  x103O_REFI_AMOUNT3,
                             out  x103O_REFI_BANK4,
                             out  x103O_REFI_OBLIGOR4,
                             out  x103O_REFI_OBLIGATION4,
                             out  x103O_REFI_AMOUNT4,
                             out  x103O_REFI_BANK5,
                             out  x103O_REFI_OBLIGOR5,
                             out  x103O_REFI_OBLIGATION5,
                             out  x103O_REFI_AMOUNT5,
                             out  x103P_TOTAL_EXPENSE,
                             out  x103P_LAST_FISCAL_YEAR,
                             out  x103P_NET_OPERATION_INCOME,
                             out  x103P_FISCAL_YEAR_MONTH,
                             out  x103P_TOTAL_DEBT_SERVICE,
                             out  x103P_DEBT_SERVICE_CHARGE,
                             out  x103P_GROSS_INCOME,
                             out  x103P_EXPENSE_RATIO,
                             out  x103P_ROOM_EGI,
                             out  x103P_RENT_ROLL_DATE,
                             out  x103P_SF_EGI,
                             out  x103P_NOTE_RATE,
                             out  x103P_LOAN_GRADE,
                             out  x103P_CD_CC_IND,
                             out  x103P_SWAP_IND,
                             out  x103P_NON_RE_COLLATERAL_PERC,
                             out  x103P_RE_COLLATERAL_PERCENT,
                             out  x103P_RE_LTV,
                             out  x103P_LAST_INSPECT_DATE,
                             out  x103P_44XX_TOL_OVER_AMT,
                             out  x103P_44XX_TOL_SHORT_AMT,
                             out  x103P_44XX_TOL_OVER_PCT,
                             out  x103P_44XX_TOL_SHORT_PCT,
                             out  x103P_PMT_PRE_JAN,
                             out  x103P_PMT_PRE_FEB,
                             out  x103P_PMT_PRE_MAR,
                             out  x103P_PMT_PRE_APR,
                             out  x103P_PMT_PRE_MAY,
                             out  x103P_PMT_PRE_JUN,
                             out  x103P_PMT_PRE_JUL,
                             out  x103P_PMT_PRE_AUG,
                             out  x103P_PMT_PRE_SEP,
                             out  x103P_PMT_PRE_OCT,
                             out  x103P_PMT_PRE_NOV,
                             out  x103P_PMT_PRE_DEC,
                             out  x103P_PMT_CUR_JAN,
                             out  x103P_PMT_CUR_FEB,
                             out  x103P_PMT_CUR_MAR,
                             out  x103P_PMT_CUR_APR,
                             out  x103P_PMT_CUR_MAY,
                             out  x103P_PMT_CUR_JUN,
                             out  x103P_PMT_CUR_JUL,
                             out  x103P_PMT_CUR_AUG,
                             out  x103P_PMT_CUR_SEP,
                             out  x103P_PMT_CUR_OCT,
                             out  x103P_PMT_CUR_NOV,
                             out  x103P_PMT_CUR_DEC,
                             out  x103I_DATA_PRESENT_SW,
                             out  x103I_INDIC_DATA_YEAR,
                             out  x103I_INDIC_DATA_TYPE,
                             out  x103I_INDIC_DATA_MAKE,
                             out  x103I_INDIC_DATA_MODEL,
                             out  x103I_INDIC_DATA_SERIAL,
                             out  x103I_INDIC_DATA_ADDRESS_1,
                             out  x103I_INDIC_DATA_ADDRESS_2,
                             out  x103I_INDIC_DATA_CITY,
                             out  x103I_INDIC_DATA_STATE,
                             out  x103I_INDIC_DATA_ZIP_CODE,
                             out  x103I_INDIC_DATA_USER_AMOUNT,
                             out  x103I_INDIC_DATA_USER_CODE,
                             out  x103I_INDIC_DATA_DATE_RECVD,
                             out  x103I_INDIC_DATA_DATE_REL,
                             out  x103I_INDIC_DATA_LOC_RECVD,
                             out  x103I_INDIC_DATA_LOC_HELD,
                             out  x103I_DISPOSITION_ONE,
                             out  x103I_INDIC_DATA_ID_NUMBER,
                             out  x103I_DISPOSITION_TWO,
                             out  x103I_INDIC_DATA_FILING_REF,
                             out  x103I_DISPOSITION_THREE,
                             out  x103I_INDIC_DATA_DESC_1,
                             out  x103I_INDIC_DATA_DESC_2,
                             out  x103I_PDI_REQ_CODE,
                             out  x103I_PDI_STATUS_CODE,
                             out  x103I_PDI_POLICY_NUMB,
                             out  x103I_PDI_STATUS_DATE,
                             out  x103I_PDI_COMPANY,
                             out  x103I_PDI_EXP_DATE,
                             out  x103I_PDI_AGENT_NAME,
                             out  x103J_DATA_PRESENT_SW,
                             out  x103J_FORE_ABAND_POST_DATE,
                             out  x103J_FORE_ABAND_DATE,
                             out  x103J_LIABILITY_IND,
                             out  x103J_OUTSTANDING_BAL,
                             out  x103J_FORE_BID_PRICE,
                             out  x103J_APPRAISAL_VALUE,
                             out  x103J_DESC_1,
                             out  x103J_DESC_2,
                             out  x103J_ODD_DAYS_INT_AMT,
                             out  x103J_DAYS_TO_CHG_PAYOFF,
                             out  x103J_ODD_DAYS_EARN_IND,
                             out  x103J_DAYS_TO_CHG_INS,
                             out  x103J_PART_PAYMENT,
                             out  x103J_NUMB_PAYMENTS_MADE,
                             out  x103J_AMT_FINANCED,
                             out  x103J_COLL_RECD_IND,
                             out  x103J_PREPAID_FIN_CHGS,
                             out  x103J_VARY_RATE_IND,
                             out  x103J_APR,
                             out  x103J_APR_VERIF_IND,
                             out  x103J_78TH_EARN_DAY,
                             out  x103J_78TH_EARN_DAY_INS,
                             out  x103J_12_MONTH_PYMNT_HIST,
                           ref ctx
                       );

                return new GetObligationResponse()
                {
                    Errors = errors,
                    x103A_PROC_TYPE = x103A_PROC_TYPE,
                    x103A_EFF_DATE = x103A_EFF_DATE,
                    x103A_MATUR_DATE = x103A_MATUR_DATE,
                    x103A_EST_MATUR_DATE = x103A_EST_MATUR_DATE,
                    x103A_ORIG_AMT = x103A_ORIG_AMT,
                    x103A_CURR_AMT = x103A_CURR_AMT,
                    x103A_AVAILABILITY = x103A_AVAILABILITY,
                    x103A_TKDOWN_OBLR = x103A_TKDOWN_OBLR,
                    x103A_TKDOWN_OBLN = x103A_TKDOWN_OBLN,
                    x103A_COMMITMENT_BAL = x103A_COMMITMENT_BAL,
                    x103B_PREPAY_CODE = x103B_PREPAY_CODE,
                    x103B_PREPAY_CODE_LIT = x103B_PREPAY_CODE_LIT,
                    x103B_DUR_CODE = x103B_DUR_CODE,
                    x103B_DUR_CODE_LIT = x103B_DUR_CODE_LIT,
                    x103B_SECUR_CODE = x103B_SECUR_CODE,
                    x103B_SECUR_CODE_LIT = x103B_SECUR_CODE_LIT,
                    x103B_MARGIN_CODE = x103B_MARGIN_CODE,
                    x103B_MARGIN_CODE_LIT = x103B_MARGIN_CODE_LIT,
                    x103B_REG_UZ = x103B_REG_UZ,
                    x103B_REG_UZ_LIT = x103B_REG_UZ_LIT,
                    x103B_TAX_BANK = x103B_TAX_BANK,
                    x103B_TAX_BANK_LIT = x103B_TAX_BANK_LIT,
                    x103B_NOTE_RESET_IND = x103B_NOTE_RESET_IND,
                    x103B_NOTE_RESET_IND_LIT = x103B_NOTE_RESET_IND_LIT,
                    x103B_BILL_LIMIT_CODE = x103B_BILL_LIMIT_CODE,
                    x103B_BILL_LIMIT_CODE_LIT = x103B_BILL_LIMIT_CODE_LIT,
                    x103B_TRANS_NOTICE = x103B_TRANS_NOTICE,
                    x103B_TRANS_NOTICE_LIT = x103B_TRANS_NOTICE_LIT,
                    x103B_1098_INDICATOR = x103B_1098_INDICATOR,
                    x103B_1098_INDICATOR_LIT = x103B_1098_INDICATOR_LIT,
                    x103C_ORIG_OBLN_DATE = x103C_ORIG_OBLN_DATE,
                    x103C_ORIG_OBLN_AMT = x103C_ORIG_OBLN_AMT,
                    x103C_DATE_LAST_RENEWED = x103C_DATE_LAST_RENEWED,
                    x103C_CLOSE_OPT_IND = x103C_CLOSE_OPT_IND,
                    x103C_CLOSE_OPT_IND_LIT = x103C_CLOSE_OPT_IND_LIT,
                    x103C_CLOSE_IND = x103C_CLOSE_IND,
                    x103C_CLOSE_IND_LIT = x103C_CLOSE_IND_LIT,
                    x103C_CLOSE_TOL_AMT = x103C_CLOSE_TOL_AMT,
                    x103C_PD_OFF_NOTICE = x103C_PD_OFF_NOTICE,
                    x103C_PD_OFF_NOTICE_LIT = x103C_PD_OFF_NOTICE_LIT,
                    x103D_CONT_OFF = x103D_CONT_OFF,
                    x103D_SERV_UNIT = x103D_SERV_UNIT,
                    x103D_ASSIGN_UNIT = x103D_ASSIGN_UNIT,
                    x103D_FED_CLASS = x103D_FED_CLASS,
                    x103D_OBLN_TYPE = x103D_OBLN_TYPE,
                    x103D_PURPOSE_CODE = x103D_PURPOSE_CODE,
                    x103D_GEN_LEDG = x103D_GEN_LEDG,
                    x103D_COLLAT_TYPE = x103D_COLLAT_TYPE,
                    x103D_LCHG_PRM_REASON = x103D_LCHG_PRM_REASON,
                    x103D_LCHG_FORMULA_TYPE = x103D_LCHG_FORMULA_TYPE,
                    x103D_SCHED_BAL_IND = x103D_SCHED_BAL_IND,
                    x103E_STAT_CODE = x103E_STAT_CODE,
                    x103E_STAT_CODE_LIT = x103E_STAT_CODE_LIT,
                    x103E_FROZEN_STAT_FLAG = x103E_FROZEN_STAT_FLAG,
                    x103E_FROZEN_STAT_FLAG_LIT = x103E_FROZEN_STAT_FLAG_LIT,
                    x103F_EXAM_TYPE_1 = x103F_EXAM_TYPE_1,
                    x103F_EXAM_TYPE_1_LIT = x103F_EXAM_TYPE_1_LIT,
                    x103F_EXAM_CLASS_1 = x103F_EXAM_CLASS_1,
                    x103F_FACILITY_RISK_RATING = x103F_FACILITY_RISK_RATING,
                    x103F_EXAM_DATE_1 = x103F_EXAM_DATE_1,
                    x103F_ORIG_TERM_MONTHS = x103F_ORIG_TERM_MONTHS,
                    x103F_CREDIT_SCORE = x103F_CREDIT_SCORE,
                    x103F_CREDIT_DATE = x103F_CREDIT_DATE,
                    x103F_BKVAL_DATE = x103F_BKVAL_DATE,
                    x103G_COLLECTION_MONITOR = x103G_COLLECTION_MONITOR,
                    x103G_COLLECTION_MONITOR_LIT = x103G_COLLECTION_MONITOR_LIT,
                    x103G_ALT_NAME_ADR_CD = x103G_ALT_NAME_ADR_CD,
                    x103H_CRA_IND = x103H_CRA_IND,
                    x103H_RT_SITEID = x103H_RT_SITEID,
                    x103H_PROD_DEF_CODE = x103H_PROD_DEF_CODE,
                    x103H_BILL_TYPE_CODE = x103H_BILL_TYPE_CODE,
                    x103H_USER_CODE_1 = x103H_USER_CODE_1,
                    x103H_USER_DATE_1 = x103H_USER_DATE_1,
                    x103H_USER_ALPHA = x103H_USER_ALPHA,
                    x103K_SPECIAL_CO__INDICATOR = x103K_SPECIAL_CO__INDICATOR,
                    x103K_CREDIT_DESK_REF_NBR = x103K_CREDIT_DESK_REF_NBR,
                    x103K_CASH_FLOW_RATIO = x103K_CASH_FLOW_RATIO,
                    x103K_LOAN_VALUE_RATIO = x103K_LOAN_VALUE_RATIO,
                    x103K_REFERRING_OFFICER = x103K_REFERRING_OFFICER,
                    x103K_SECONDARY_OFFICER = x103K_SECONDARY_OFFICER,
                    x103K_AFS_ALPHA_1 = x103K_AFS_ALPHA_1,
                    x103L_CREDIT_SC_REF_NO = x103L_CREDIT_SC_REF_NO,
                    x103L_ORIG_LTV_DATE = x103L_ORIG_LTV_DATE,
                    x103L_ORIG_LTV = x103L_ORIG_LTV,
                    x103L_REFERRING_OFFICER = x103L_REFERRING_OFFICER,
                    x103L_UNDERWRITER = x103L_UNDERWRITER,
                    x103N_USER_CODE_2 = x103N_USER_CODE_2,
                    x103N_USER_CODE_3 = x103N_USER_CODE_3,
                    x1BAA_SBA_STATUS = x1BAA_SBA_STATUS,
                    x1BAA_SBA_STATUS_LIT = x1BAA_SBA_STATUS_LIT,
                    x1BAA_SBA_GP_NUMBER = x1BAA_SBA_GP_NUMBER,
                    x1BAA_SBA_PROGRAM_NUMBER = x1BAA_SBA_PROGRAM_NUMBER,
                    x1BAA_APPROVAL_DATE = x1BAA_APPROVAL_DATE,
                    x1BAA_APPROVAL_AMOUNT = x1BAA_APPROVAL_AMOUNT,
                    x1BAA_GUARANTEED_PCT = x1BAA_GUARANTEED_PCT,
                    x1BAA_FTA_SERVIC_FEE_PCT = x1BAA_FTA_SERVIC_FEE_PCT,
                    x1BAA_SBA_SOURCE_CODE = x1BAA_SBA_SOURCE_CODE,
                    x1BAA_SBA_OBGR_NO = x1BAA_SBA_OBGR_NO,
                    x1BAA_SPEC_MAIL_CODE = x1BAA_SPEC_MAIL_CODE,
                    x1BAA_DATE_SOLD = x1BAA_DATE_SOLD,
                    x1BAA_SETTLEMENT_DATE = x1BAA_SETTLEMENT_DATE,
                    x1BAA_SERVICE_FEE_AMT = x1BAA_SERVICE_FEE_AMT,
                    x1BAA_SERVICE_FEE_PCT = x1BAA_SERVICE_FEE_PCT,
                    x1BAA_SPREAD_PMT_OPT = x1BAA_SPREAD_PMT_OPT,
                    x1BAA_SPREAD_PMT_OPT_LIT = x1BAA_SPREAD_PMT_OPT_LIT,
                    x103A_TITLE_CURR_DATE = x103A_TITLE_CURR_DATE,
                    x103A_POSTED_DATE = x103A_POSTED_DATE,
                    x103A_LAST_ACT_DATE = x103A_LAST_ACT_DATE,
                    x103A_LAST_CHG_DATE = x103A_LAST_CHG_DATE,
                    x103A_GUAR_AMT = x103A_GUAR_AMT,
                    x103A_COLLAT_VALUE = x103A_COLLAT_VALUE,
                    x103A_PAID_TO_PRIN = x103A_PAID_TO_PRIN,
                    x103A_USER_BALANCE = x103A_USER_BALANCE,
                    x103A_BOOK_VALUE = x103A_BOOK_VALUE,
                    x103A_SCHED_BALANCE = x103A_SCHED_BALANCE,
                    x103A_PART_AMT = x103A_PART_AMT,
                    x103A_AMT_TKNDWN = x103A_AMT_TKNDWN,
                    x103A_NET_BOOK_VALUE = x103A_NET_BOOK_VALUE,
                    x103A_PROCEEDS = x103A_PROCEEDS,
                    x103A_NET_PRIN_TDY = x103A_NET_PRIN_TDY,
                    x103A_NET_PARTS_TDY = x103A_NET_PARTS_TDY,
                    x103A_NET_COLLAT_ACTIVITY = x103A_NET_COLLAT_ACTIVITY,
                    x103A_NET_INT_TDY = x103A_NET_INT_TDY,
                    x103A_INTER_COMM = x103A_INTER_COMM,
                    x103A_R = x103A_R,
                    x103A_RS = x103A_RS,
                    x103A_RL = x103A_RL,
                    x103A_LINE_23_LIT = x103A_LINE_23_LIT,
                    x103B_PRIN_PD_TO_DT = x103B_PRIN_PD_TO_DT,
                    x103B_PRIN_LAST_BILL_DT = x103B_PRIN_LAST_BILL_DT,
                    x103B_PRIN_PREV_DUE_DT = x103B_PRIN_PREV_DUE_DT,
                    x103B_PRIN_PAID_MTD = x103B_PRIN_PAID_MTD,
                    x103B_PRIN_PAID_YTD = x103B_PRIN_PAID_YTD,
                    x103B_PRIN_PAID_NOT_BLD = x103B_PRIN_PAID_NOT_BLD,
                    x103B_PRIN_WAIVE_AMT = x103B_PRIN_WAIVE_AMT,
                    x103B_BILL_AGING_AMOUNT = x103B_BILL_AGING_AMOUNT,
                    x103B_MTHLY_CUM_BAL = x103B_MTHLY_CUM_BAL,
                    x103B_DATE_NEXT_DUE = x103B_DATE_NEXT_DUE,
                    x103B_PREV_YR_AVG_USE = x103B_PREV_YR_AVG_USE,
                    x103B_PRIN_BLD_NT_PD_LT = x103B_PRIN_BLD_NT_PD_LT,
                    x103B_PRIN_BLD_NOT_PAID = x103B_PRIN_BLD_NOT_PAID,
                    x103B_PRIN_PAST_DUE = x103B_PRIN_PAST_DUE,
                    x103B_CAPITALIZED_INT = x103B_CAPITALIZED_INT,
                    x103B_DISC_CODE = x103B_DISC_CODE,
                    x103B_MARGIN_PCT = x103B_MARGIN_PCT,
                    x103B_REDISC_CODE = x103B_REDISC_CODE,
                    x103B_ACCR_LIMIT_CODE = x103B_ACCR_LIMIT_CODE,
                    x103B_FLOAT_IND = x103B_FLOAT_IND,
                    x103B_RT_CHG_NOTICE = x103B_RT_CHG_NOTICE,
                    x103B_CUST_EXP_IND = x103B_CUST_EXP_IND,
                    x103B_EXCLUDE_CD = x103B_EXCLUDE_CD,
                    x103B_LC_REF_NUMBER = x103B_LC_REF_NUMBER,
                    x103B_PREPAY_PENALTY_IND = x103B_PREPAY_PENALTY_IND,
                    x103C_RENEW_TIMES = x103C_RENEW_TIMES,
                    x103C_RENEW_TYPE = x103C_RENEW_TYPE,
                    x103C_ORIG_MATUR_DATE = x103C_ORIG_MATUR_DATE,
                    x103C_ORIG_DISC_AMT = x103C_ORIG_DISC_AMT,
                    x103C_RENEW_PREV = x103C_RENEW_PREV,
                    x103C_RENEW_TO = x103C_RENEW_TO,
                    x103C_RENEWAL_POSTED_DT = x103C_RENEWAL_POSTED_DT,
                    x103C_REFINANCED_FROM_OBLN = x103C_REFINANCED_FROM_OBLN,
                    x103C_REFINANCED_TO_OBLN = x103C_REFINANCED_TO_OBLN,
                    x103C_ASSUMED_FROM_OBGR = x103C_ASSUMED_FROM_OBGR,
                    x103C_ASSUMED_TO_OBGR = x103C_ASSUMED_TO_OBGR,
                    x103C_ASSUMED_FROM_OBLN = x103C_ASSUMED_FROM_OBLN,
                    x103C_ASSUMED_TO_OBLN = x103C_ASSUMED_TO_OBLN,
                    x103C_DATE_LAST_EXTEND = x103C_DATE_LAST_EXTEND,
                    x103C_TIMES_EXTEND = x103C_TIMES_EXTEND,
                    x103C_MNTHS_EXTEND = x103C_MNTHS_EXTEND,
                    x103C_CLOSE_DT = x103C_CLOSE_DT,
                    x103C_CLOSE_AMT = x103C_CLOSE_AMT,
                    x103C_YESTERDAYS_CLOSE = x103C_YESTERDAYS_CLOSE,
                    x103C_HI_ADV_IND = x103C_HI_ADV_IND,
                    x103C_IMA_TKDWN_IND = x103C_IMA_TKDWN_IND,
                    x103C_FINAL_CLOSE_IND = x103C_FINAL_CLOSE_IND,
                    x103C_FINAL_CLOSE_PRIN_ADJ = x103C_FINAL_CLOSE_PRIN_ADJ,
                    x103C_FINAL_CLOSE_POST_DATE = x103C_FINAL_CLOSE_POST_DATE,
                    x103C_FINAL_CLOSE_PRIN_WVE = x103C_FINAL_CLOSE_PRIN_WVE,
                    x103C_WAIVE_EARN_IND = x103C_WAIVE_EARN_IND,
                    x103C_NON_RESTART_DATE = x103C_NON_RESTART_DATE,
                    x103C_OUT_DEBT_DATE = x103C_OUT_DEBT_DATE,
                    x103D_LAST_WEKLY_DATE = x103D_LAST_WEKLY_DATE,
                    x103D_LAST_DAILY_DATE = x103D_LAST_DAILY_DATE,
                    x103D_DIVISION = x103D_DIVISION,
                    x103D_REGION = x103D_REGION,
                    x103D_SUB_LOB = x103D_SUB_LOB,
                    x103D_SIC_CODE = x103D_SIC_CODE,
                    x103D_GEOG_CODE = x103D_GEOG_CODE,
                    x103D_PNLTY_FORMULA = x103D_PNLTY_FORMULA,
                    x103D_GROUP = x103D_GROUP,
                    x103D_MARKET = x103D_MARKET,
                    x103D_CNTL_BRK_U_HIERARCHY = x103D_CNTL_BRK_U_HIERARCHY,
                    x103D_REAM_INDICATOR = x103D_REAM_INDICATOR,
                    x103D_REAM_BASIS_IND = x103D_REAM_BASIS_IND,
                    x103D_REAM_FREQ_MONTHS = x103D_REAM_FREQ_MONTHS,
                    x103D_REAM_PRIORITY = x103D_REAM_PRIORITY,
                    x103D_REAM_NXT_SCHD_DT = x103D_REAM_NXT_SCHD_DT,
                    x103D_LAST_REAM_DATE = x103D_LAST_REAM_DATE,
                    x103D_REAM_PERIOD_DATE = x103D_REAM_PERIOD_DATE,
                    x103D_CUST_NOTIFY_DAYS = x103D_CUST_NOTIFY_DAYS,
                    x103D_REAM_ERR_EFF_DT = x103D_REAM_ERR_EFF_DT,
                    x103D_LAST_NOTICE_DATE = x103D_LAST_NOTICE_DATE,
                    x103D_CURR_BALLOON = x103D_CURR_BALLOON,
                    x103D_LAST_CHANGE_DATE = x103D_LAST_CHANGE_DATE,
                    x103D_ORIG_BALLOON = x103D_ORIG_BALLOON,
                    x103D_REDISCLOSE_DATE = x103D_REDISCLOSE_DATE,
                    x103D_TERM_OUT_STATUS = x103D_TERM_OUT_STATUS,
                    x103D_SCHED_BAL_ROUND = x103D_SCHED_BAL_ROUND,
                    x103D_LEGAL_STATUS = x103D_LEGAL_STATUS,
                    x103D_LEGAL_STATUS_DATE = x103D_LEGAL_STATUS_DATE,
                    x103D_ADVANCE_OPT = x103D_ADVANCE_OPT,
                    x103D_CURTAILMENT_OPT = x103D_CURTAILMENT_OPT,
                    x103D_UNAPPLIED_OPT = x103D_UNAPPLIED_OPT,
                    x103D_PMT_SPRD_SEQ = x103D_PMT_SPRD_SEQ,
                    x103D_MATURITY_PMT_SPRD = x103D_MATURITY_PMT_SPRD,
                    x103E_STAT_DATE = x103E_STAT_DATE,
                    x103E_CHG_OFF_DATE = x103E_CHG_OFF_DATE,
                    x103E_NON_PERFM_DT = x103E_NON_PERFM_DT,
                    x103E_CHARGE_OFF_STATUS = x103E_CHARGE_OFF_STATUS,
                    x103E_CHG_OFF_RECOV = x103E_CHG_OFF_RECOV,
                    x103E_RECOVERY_AMT_ITD = x103E_RECOVERY_AMT_ITD,
                    x103E_E_SUSP_AMORT_DT = x103E_E_SUSP_AMORT_DT,
                    x103E_NON_PERFM_OVRD = x103E_NON_PERFM_OVRD,
                    x103E_ACCRL_MNTR_FLAG = x103E_ACCRL_MNTR_FLAG,
                    x103E_NON_PERFM_IND = x103E_NON_PERFM_IND,
                    x103E_NON_ACCRL_DATE = x103E_NON_ACCRL_DATE,
                    x103E_NON_ACCRL_OVRD = x103E_NON_ACCRL_OVRD,
                    x103E_REDUCED_RT_IND = x103E_REDUCED_RT_IND,
                    x103E_RENEG_FLAG = x103E_RENEG_FLAG,
                    x103E_FROZEN_STAT_DATE = x103E_FROZEN_STAT_DATE,
                    x103E_FROZ_OPT = x103E_FROZ_OPT,
                    x103E_FROZ_CHG_DAYS = x103E_FROZ_CHG_DAYS,
                    x103E_FROZ_LEAD_DAYS = x103E_FROZ_LEAD_DAYS,
                    x103E_FROZ_AUTO_RESUM_DAYS = x103E_FROZ_AUTO_RESUM_DAYS,
                    x103E_FROZ_AUTO_RESUME_DATE = x103E_FROZ_AUTO_RESUME_DATE,
                    x103E_CHARGE_OFF_ITD = x103E_CHARGE_OFF_ITD,
                    x103E_IMPAIRMENT_IND = x103E_IMPAIRMENT_IND,
                    x103E_IMPAIRMENT_DATE = x103E_IMPAIRMENT_DATE,
                    x103E_DATE_LAST_IMPAIRED = x103E_DATE_LAST_IMPAIRED,
                    x103E_VALUATION_AMT = x103E_VALUATION_AMT,
                    x103E_VALUATION_ALLOWANCE = x103E_VALUATION_ALLOWANCE,
                    x103E_VALUATION_DATE = x103E_VALUATION_DATE,
                    x103E_VALUATION_IND = x103E_VALUATION_IND,
                    x103E_MARK_TO_MARKET_PCT = x103E_MARK_TO_MARKET_PCT,
                    x103E_ORIG_SUSPENSE_AMT = x103E_ORIG_SUSPENSE_AMT,
                    x103E_LOST_INCOME_MTD = x103E_LOST_INCOME_MTD,
                    x103E_PAID_NON_ACCRL_YTD = x103E_PAID_NON_ACCRL_YTD,
                    x103E_LOST_INCOME_QTD = x103E_LOST_INCOME_QTD,
                    x103E_LOST_INCOME_YTD = x103E_LOST_INCOME_YTD,
                    x103F_BKVAL_PRIN_BAL = x103F_BKVAL_PRIN_BAL,
                    x103F_BKVAL_ORIG_BAL = x103F_BKVAL_ORIG_BAL,
                    x103F_BKVAL_AMT_TKDOWN = x103F_BKVAL_AMT_TKDOWN,
                    x103F_EXAM_AMT_1 = x103F_EXAM_AMT_1,
                    x103F_BKVAL_INT_OVER = x103F_BKVAL_INT_OVER,
                    x103F_EXAM_TYPE_2 = x103F_EXAM_TYPE_2,
                    x103F_BKVAL_CHG_OFF_BAL = x103F_BKVAL_CHG_OFF_BAL,
                    x103F_EXAM_CLASS_2 = x103F_EXAM_CLASS_2,
                    x103F_BKVAL_USER_BAL = x103F_BKVAL_USER_BAL,
                    x103F_EXAM_DATE_2 = x103F_EXAM_DATE_2,
                    x103F_EXAM_AMT_2 = x103F_EXAM_AMT_2,
                    x103F_COUP_POST_DATE_REPL = x103F_COUP_POST_DATE_REPL,
                    x103F_COUP_REPL_1ST_DUE_DATE = x103F_COUP_REPL_1ST_DUE_DATE,
                    x103F_COUP_REORDER_NUMB = x103F_COUP_REORDER_NUMB,
                    x103F_COUP_ORDER_FREQ = x103F_COUP_ORDER_FREQ,
                    x103F_COUP_DATE_NEXT_ORDER = x103F_COUP_DATE_NEXT_ORDER,
                    x103F_NUMB_ORIG_PYMNTS = x103F_NUMB_ORIG_PYMNTS,
                    x103F_OBLGN_XREF_NO = x103F_OBLGN_XREF_NO,
                    x103G_PASTDUE_DATE = x103G_PASTDUE_DATE,
                    x103G_TOT_PAST_DUE_AMT = x103G_TOT_PAST_DUE_AMT,
                    x103G_CURR_PAST_DUE_DAYS = x103G_CURR_PAST_DUE_DAYS,
                    x103G_ADV_AFTER_MAT_OPT = x103G_ADV_AFTER_MAT_OPT,
                    x103G_PREV_COLLECT_STATUS = x103G_PREV_COLLECT_STATUS,
                    x103G_CURR_COLLECT_STATUS = x103G_CURR_COLLECT_STATUS,
                    x103G_TIMES_IN_COLLECTION = x103G_TIMES_IN_COLLECTION,
                    x103G_COLLECTION_UNIT = x103G_COLLECTION_UNIT,
                    x103G_COLLECTION_OFFICER = x103G_COLLECTION_OFFICER,
                    x103G_PENALTY_BKVAL_DATE = x103G_PENALTY_BKVAL_DATE,
                    x103G_PENALTY_CONV_DATE = x103G_PENALTY_CONV_DATE,
                    x103G_RET_CHECK_CTR = x103G_RET_CHECK_CTR,
                    x103G_TIMES_PAST_30_DAYS = x103G_TIMES_PAST_30_DAYS,
                    x103G_TIMES_PAST_60_DAYS = x103G_TIMES_PAST_60_DAYS,
                    x103G_DELINQ_15_COUNTER = x103G_DELINQ_15_COUNTER,
                    x103G_DELINQ_120_COUNTER = x103G_DELINQ_120_COUNTER,
                    x103G_TIMES_PAST_90_DAYS = x103G_TIMES_PAST_90_DAYS,
                    x103G_DELINQ_30_COUNTER = x103G_DELINQ_30_COUNTER,
                    x103G_DELINQ_150_COUNTER = x103G_DELINQ_150_COUNTER,
                    x103G_TIMES_PAST_120_DAYS = x103G_TIMES_PAST_120_DAYS,
                    x103G_DELINQ_60_COUNTER = x103G_DELINQ_60_COUNTER,
                    x103G_DELINQ_180_COUNTER = x103G_DELINQ_180_COUNTER,
                    x103G_TIMES_PAST_150_DAYS = x103G_TIMES_PAST_150_DAYS,
                    x103G_DELINQ_90_COUNTER = x103G_DELINQ_90_COUNTER,
                    x103G_MAT_TOLERANCE_PERCENT = x103G_MAT_TOLERANCE_PERCENT,
                    x103G_SETTLEMENT_DATE = x103G_SETTLEMENT_DATE,
                    x103G_MAT_TOLERANCE_AMT = x103G_MAT_TOLERANCE_AMT,
                    x103G_SETTLEMENT_PD = x103G_SETTLEMENT_PD,
                    x103G_LOAN_TYPE = x103G_LOAN_TYPE,
                    x103G_CUSIP_NO = x103G_CUSIP_NO,
                    x103G_SNC_CODE = x103G_SNC_CODE,
                    x103G_SNC_ID = x103G_SNC_ID,
                    x103H_COLL_SHRTGE_CD = x103H_COLL_SHRTGE_CD,
                    x103H_USER_CODE_1_TITLE = x103H_USER_CODE_1_TITLE,
                    x103H_COLL_SHRTGE_DATE = x103H_COLL_SHRTGE_DATE,
                    x103H_USER_DATE_2 = x103H_USER_DATE_2,
                    x103H_USER_CODE_2_TITLE = x103H_USER_CODE_2_TITLE,
                    x103H_USER_CODE_2 = x103H_USER_CODE_2,
                    x103H_COLL_UNDERMARGIN_DATE = x103H_COLL_UNDERMARGIN_DATE,
                    x103H_USER_CODE_3 = x103H_USER_CODE_3,
                    x103H_COMP_BAL_IND = x103H_COMP_BAL_IND,
                    x103H_USER_AMT = x103H_USER_AMT,
                    x103H_SMSA_CODE = x103H_SMSA_CODE,
                    x103H_USER_FIELD_1_TITLE = x103H_USER_FIELD_1_TITLE,
                    x103H_USER_FIELD_1 = x103H_USER_FIELD_1,
                    x103H_CENSUS_TRACT = x103H_CENSUS_TRACT,
                    x103H_HOEPA_STATUS = x103H_HOEPA_STATUS,
                    x103H_RATE_SPRD = x103H_RATE_SPRD,
                    x103H_PROPERTY_TYPE = x103H_PROPERTY_TYPE,
                    x103H_INCOME_REVENUE = x103H_INCOME_REVENUE,
                    x103H_PURCHASER_TP = x103H_PURCHASER_TP,
                    x103H_BUDGET_ID = x103H_BUDGET_ID,
                    x103H_MASTER_DOC = x103H_MASTER_DOC,
                    x103H_FC824 = x103H_FC824,
                    x103H_ACH_DELAY_DAYS = x103H_ACH_DELAY_DAYS,
                    x103H_FC826 = x103H_FC826,
                    x103H_DEFRD_DUE_DATE_IND = x103H_DEFRD_DUE_DATE_IND,
                    x103H_DEFRD_DUE_DATE_DAYS = x103H_DEFRD_DUE_DATE_DAYS,
                    x103H_UNIT_ACCR_IND = x103H_UNIT_ACCR_IND,
                    x103H_BALLOON_IND = x103H_BALLOON_IND,
                    x103H_CONVERSION_PCT = x103H_CONVERSION_PCT,
                    x103H_MATUR_BILL_IND = x103H_MATUR_BILL_IND,
                    x103H_RISK_WEIGHT_PCT = x103H_RISK_WEIGHT_PCT,
                    x103H_TAX_EQUIV_NO = x103H_TAX_EQUIV_NO,
                    x103H_OBLN_TAX_CLASS = x103H_OBLN_TAX_CLASS,
                    x103H_PRIN_OVERDUE = x103H_PRIN_OVERDUE,
                    x103H_INT_OVERDUE = x103H_INT_OVERDUE,
                    x103H_BILL_ALONE_IND = x103H_BILL_ALONE_IND,
                    x103H_DEAL_NUMBER = x103H_DEAL_NUMBER,
                    x103H_NAICS_CODE = x103H_NAICS_CODE,
                    x103K_USER_OFFICER_1 = x103K_USER_OFFICER_1,
                    x103K_USER_OFFICER_2 = x103K_USER_OFFICER_2,
                    x103K_AFS_ALPHA_2 = x103K_AFS_ALPHA_2,
                    x103K_USER_OFFICER_3 = x103K_USER_OFFICER_3,
                    x103K_AFS_ALPHA_3 = x103K_AFS_ALPHA_3,
                    x103K_USER_OFFICER_4 = x103K_USER_OFFICER_4,
                    x103K_AFS_ALPHA_4 = x103K_AFS_ALPHA_4,
                    x103K_AFS_ALPHA_5 = x103K_AFS_ALPHA_5,
                    x103K_PREV_TKDWN_FROM_OBLIGOR = x103K_PREV_TKDWN_FROM_OBLIGOR,
                    x103K_TIED_TO_POSTING_DATE = x103K_TIED_TO_POSTING_DATE,
                    x103K_PREV_TKDWN_FROM_OBLIGAT = x103K_PREV_TKDWN_FROM_OBLIGAT,
                    x103K_UNTIED_FROM_POSTING_DATE = x103K_UNTIED_FROM_POSTING_DATE,
                    x103K_PREV_PROCESS_TYPE = x103K_PREV_PROCESS_TYPE,
                    x103K_ORIG_TIE_UNTIE_ACTIV_DAT = x103K_ORIG_TIE_UNTIE_ACTIV_DAT,
                    x103K_CRED_BUREAU_ASSOC = x103K_CRED_BUREAU_ASSOC,
                    x103K_CRED_BUREAU_RPT_IND = x103K_CRED_BUREAU_RPT_IND,
                    x103K_CREDIT_SCORE_TYPE = x103K_CREDIT_SCORE_TYPE,
                    x103K_CREDIT_SCORE_REF_NUM = x103K_CREDIT_SCORE_REF_NUM,
                    x103K_CRED_BUREAU_STATUS_CODE = x103K_CRED_BUREAU_STATUS_CODE,
                    x103K_CRED_CONS_INFO_IND = x103K_CRED_CONS_INFO_IND,
                    x103K_CRED_COMP_COND_CD = x103K_CRED_COMP_COND_CD,
                    x103K_CRED_BUREAU_COMM_IND = x103K_CRED_BUREAU_COMM_IND,
                    x103K_ALT_REC_CD_1 = x103K_ALT_REC_CD_1,
                    x103K_ALT_ASSOC_CD_1 = x103K_ALT_ASSOC_CD_1,
                    x103K_DATE_LAST_PR_IN_PYMNT = x103K_DATE_LAST_PR_IN_PYMNT,
                    x103K_ALT_REC_CD_2 = x103K_ALT_REC_CD_2,
                    x103K_ALT_ASSOC_CD_2 = x103K_ALT_ASSOC_CD_2,
                    x103K_CR_BUR_PAST_DUE = x103K_CR_BUR_PAST_DUE,
                    x103K_ALT_REC_CD_3 = x103K_ALT_REC_CD_3,
                    x103K_ALT_ASSOC_CD_3 = x103K_ALT_ASSOC_CD_3,
                    x103L_CREDIT_SC = x103L_CREDIT_SC,
                    x103L_CREDIT_SC_DT = x103L_CREDIT_SC_DT,
                    x103L_CREDIT_SC_TYPE = x103L_CREDIT_SC_TYPE,
                    x103L_DEBT_INCOME_RATIO = x103L_DEBT_INCOME_RATIO,
                    x103L_CURRENT_LTV = x103L_CURRENT_LTV,
                    x103L_APPL_DATE = x103L_APPL_DATE,
                    x103L_DEBT_AMOUNT = x103L_DEBT_AMOUNT,
                    x103L_CONTRACT_ADDS = x103L_CONTRACT_ADDS,
                    x103L_LC_CAP_AMOUNT = x103L_LC_CAP_AMOUNT,
                    x103L_PRODUCT = x103L_PRODUCT,
                    x103L_CAMPAIGN = x103L_CAMPAIGN,
                    x103L_PROGRAM = x103L_PROGRAM,
                    x103L_APPL_SOURCE = x103L_APPL_SOURCE,
                    x103L_WORKPACKAGE_NO = x103L_WORKPACKAGE_NO,
                    x103L_APPL_OVERRIDE_IND = x103L_APPL_OVERRIDE_IND,
                    x103L_WORKPACKAGE_TYPE = x103L_WORKPACKAGE_TYPE,
                    x103L_FINAL_APPROVAL_OFFICER = x103L_FINAL_APPROVAL_OFFICER,
                    x103L_CREDIT_RVW_OFFICER = x103L_CREDIT_RVW_OFFICER,
                    x103L_CREDIT_LST_REV_DT = x103L_CREDIT_LST_REV_DT,
                    x103L_EXCEPT_APPROVAL_OFFICER = x103L_EXCEPT_APPROVAL_OFFICER,
                    x103L_OCCUPANCY = x103L_OCCUPANCY,
                    x103M_APPRAISAL_TYPE = x103M_APPRAISAL_TYPE,
                    x103M_APPRAISER = x103M_APPRAISER,
                    x103M_APPRAISAL_DATE = x103M_APPRAISAL_DATE,
                    x103M_APPRAISAL_AMT = x103M_APPRAISAL_AMT,
                    x103M_ORIG_RE_LTV = x103M_ORIG_RE_LTV,
                    x103M_ORIG_RE_APPL_AMT = x103M_ORIG_RE_APPL_AMT,
                    x103M_CURR_RE_LTV = x103M_CURR_RE_LTV,
                    x103M_CURR_RE_APPL_AMT = x103M_CURR_RE_APPL_AMT,
                    x103M_NUM_PROP = x103M_NUM_PROP,
                    x103M_TOT_OFF_SF = x103M_TOT_OFF_SF,
                    x103M_NUM_UNITS = x103M_NUM_UNITS,
                    x103M_TOT_RES_SF = x103M_TOT_RES_SF,
                    x103M_NUM_RES_ROOM = x103M_NUM_RES_ROOM,
                    x103M_TOT_RETAIL_SF = x103M_TOT_RETAIL_SF,
                    x103M_TOT_COMM_SF = x103M_TOT_COMM_SF,
                    x103M_TOT_ACREAGE = x103M_TOT_ACREAGE,
                    x103M_TOT_RENT_SF = x103M_TOT_RENT_SF,
                    x103M_TOT_BLDG_SF = x103M_TOT_BLDG_SF,
                    x103M_FIRST_LIEN_AMT = x103M_FIRST_LIEN_AMT,
                    x103M_LIEN_POSITION = x103M_LIEN_POSITION,
                    x103M_LIEN_HOLDER_NAME = x103M_LIEN_HOLDER_NAME,
                    x103M_OLD_LOAN_NUMBER = x103M_OLD_LOAN_NUMBER,
                    x103M_SYSTEM_CONV_FROM = x103M_SYSTEM_CONV_FROM,
                    x103N_AFS_COMM_OBLIGOR = x103N_AFS_COMM_OBLIGOR,
                    x103N_AFS_COMM_OBLIGATION = x103N_AFS_COMM_OBLIGATION,
                    x103N_U_NUMERIC3 = x103N_U_NUMERIC3,
                    x103N_ORIGINATING_RU = x103N_ORIGINATING_RU,
                    x103N_USER_STI_NUMERIC_A = x103N_USER_STI_NUMERIC_A,
                    x103N_LAST_REPRICE_INDEX = x103N_LAST_REPRICE_INDEX,
                    x103N_USER_STI_NUMERIC_B = x103N_USER_STI_NUMERIC_B,
                    x103N_CALL_DATE = x103N_CALL_DATE,
                    x103N_USER_ALPHA_5 = x103N_USER_ALPHA_5,
                    x103N_COMMIT_DATE = x103N_COMMIT_DATE,
                    x103O_CONTIGUOUS_PROPERTY_IND = x103O_CONTIGUOUS_PROPERTY_IND,
                    x103O_ORIG_AMORTIZATION_DATE = x103O_ORIG_AMORTIZATION_DATE,
                    x103O_LOAN_REN_CODE = x103O_LOAN_REN_CODE,
                    x103O_MODIFICATION_DATE = x103O_MODIFICATION_DATE,
                    x103O_RENEWAL_DATE = x103O_RENEWAL_DATE,
                    x103O_INDEX_NAME = x103O_INDEX_NAME,
                    x103O_ADV_NOTICE_PERIOD = x103O_ADV_NOTICE_PERIOD,
                    x103O_INDEX_RATE = x103O_INDEX_RATE,
                    x103O_REN_PAYMENT_TY = x103O_REN_PAYMENT_TY,
                    x103O_INDEX_DATE = x103O_INDEX_DATE,
                    x103O_SECONDARY_FIN_IND = x103O_SECONDARY_FIN_IND,
                    x103O_MARGIN1 = x103O_MARGIN1,
                    x103O_AMORTIZATION_TERM = x103O_AMORTIZATION_TERM,
                    x103O_FEE_PERCENT = x103O_FEE_PERCENT,
                    x103O_BALLOON_DATE = x103O_BALLOON_DATE,
                    x103O_FEE_AMOUNT = x103O_FEE_AMOUNT,
                    x103O_CALL_DATE = x103O_CALL_DATE,
                    x103O_FEE_BAL_TYPE = x103O_FEE_BAL_TYPE,
                    x103O_COMMENTS = x103O_COMMENTS,
                    x103O_REFI_BANK1 = x103O_REFI_BANK1,
                    x103O_REFI_OBLIGOR1 = x103O_REFI_OBLIGOR1,
                    x103O_REFI_OBLIGATION1 = x103O_REFI_OBLIGATION1,
                    x103O_REFI_AMOUNT1 = x103O_REFI_AMOUNT1,
                    x103O_REFI_BANK2 = x103O_REFI_BANK2,
                    x103O_REFI_OBLIGOR2 = x103O_REFI_OBLIGOR2,
                    x103O_REFI_OBLIGATION2 = x103O_REFI_OBLIGATION2,
                    x103O_REFI_AMOUNT2 = x103O_REFI_AMOUNT2,
                    x103O_REFI_BANK3 = x103O_REFI_BANK3,
                    x103O_REFI_OBLIGOR3 = x103O_REFI_OBLIGOR3,
                    x103O_REFI_OBLIGATION3 = x103O_REFI_OBLIGATION3,
                    x103O_REFI_AMOUNT3 = x103O_REFI_AMOUNT3,
                    x103O_REFI_BANK4 = x103O_REFI_BANK4,
                    x103O_REFI_OBLIGOR4 = x103O_REFI_OBLIGOR4,
                    x103O_REFI_OBLIGATION4 = x103O_REFI_OBLIGATION4,
                    x103O_REFI_AMOUNT4 = x103O_REFI_AMOUNT4,
                    x103O_REFI_BANK5 = x103O_REFI_BANK5,
                    x103O_REFI_OBLIGOR5 = x103O_REFI_OBLIGOR5,
                    x103O_REFI_OBLIGATION5 = x103O_REFI_OBLIGATION5,
                    x103O_REFI_AMOUNT5 = x103O_REFI_AMOUNT5,
                    x103P_TOTAL_EXPENSE = x103P_TOTAL_EXPENSE,
                    x103P_LAST_FISCAL_YEAR = x103P_LAST_FISCAL_YEAR,
                    x103P_NET_OPERATION_INCOME = x103P_NET_OPERATION_INCOME,
                    x103P_FISCAL_YEAR_MONTH = x103P_FISCAL_YEAR_MONTH,
                    x103P_TOTAL_DEBT_SERVICE = x103P_TOTAL_DEBT_SERVICE,
                    x103P_DEBT_SERVICE_CHARGE = x103P_DEBT_SERVICE_CHARGE,
                    x103P_GROSS_INCOME = x103P_GROSS_INCOME,
                    x103P_EXPENSE_RATIO = x103P_EXPENSE_RATIO,
                    x103P_ROOM_EGI = x103P_ROOM_EGI,
                    x103P_RENT_ROLL_DATE = x103P_RENT_ROLL_DATE,
                    x103P_SF_EGI = x103P_SF_EGI,
                    x103P_NOTE_RATE = x103P_NOTE_RATE,
                    x103P_LOAN_GRADE = x103P_LOAN_GRADE,
                    x103P_CD_CC_IND = x103P_CD_CC_IND,
                    x103P_SWAP_IND = x103P_SWAP_IND,
                    x103P_NON_RE_COLLATERAL_PERC = x103P_NON_RE_COLLATERAL_PERC,
                    x103P_RE_COLLATERAL_PERCENT = x103P_RE_COLLATERAL_PERCENT,
                    x103P_RE_LTV = x103P_RE_LTV,
                    x103P_LAST_INSPECT_DATE = x103P_LAST_INSPECT_DATE,
                    x103P_44XX_TOL_OVER_AMT = x103P_44XX_TOL_OVER_AMT,
                    x103P_44XX_TOL_SHORT_AMT = x103P_44XX_TOL_SHORT_AMT,
                    x103P_44XX_TOL_OVER_PCT = x103P_44XX_TOL_OVER_PCT,
                    x103P_44XX_TOL_SHORT_PCT = x103P_44XX_TOL_SHORT_PCT,
                    x103P_PMT_PRE_JAN = x103P_PMT_PRE_JAN,
                    x103P_PMT_PRE_FEB = x103P_PMT_PRE_FEB,
                    x103P_PMT_PRE_MAR = x103P_PMT_PRE_MAR,
                    x103P_PMT_PRE_APR = x103P_PMT_PRE_APR,
                    x103P_PMT_PRE_MAY = x103P_PMT_PRE_MAY,
                    x103P_PMT_PRE_JUN = x103P_PMT_PRE_JUN,
                    x103P_PMT_PRE_JUL = x103P_PMT_PRE_JUL,
                    x103P_PMT_PRE_AUG = x103P_PMT_PRE_AUG,
                    x103P_PMT_PRE_SEP = x103P_PMT_PRE_SEP,
                    x103P_PMT_PRE_OCT = x103P_PMT_PRE_OCT,
                    x103P_PMT_PRE_NOV = x103P_PMT_PRE_NOV,
                    x103P_PMT_PRE_DEC = x103P_PMT_PRE_DEC,
                    x103P_PMT_CUR_JAN = x103P_PMT_CUR_JAN,
                    x103P_PMT_CUR_FEB = x103P_PMT_CUR_FEB,
                    x103P_PMT_CUR_MAR = x103P_PMT_CUR_MAR,
                    x103P_PMT_CUR_APR = x103P_PMT_CUR_APR,
                    x103P_PMT_CUR_MAY = x103P_PMT_CUR_MAY,
                    x103P_PMT_CUR_JUN = x103P_PMT_CUR_JUN,
                    x103P_PMT_CUR_JUL = x103P_PMT_CUR_JUL,
                    x103P_PMT_CUR_AUG = x103P_PMT_CUR_AUG,
                    x103P_PMT_CUR_SEP = x103P_PMT_CUR_SEP,
                    x103P_PMT_CUR_OCT = x103P_PMT_CUR_OCT,
                    x103P_PMT_CUR_NOV = x103P_PMT_CUR_NOV,
                    x103P_PMT_CUR_DEC = x103P_PMT_CUR_DEC,
                    x103I_DATA_PRESENT_SW = x103I_DATA_PRESENT_SW,
                    x103I_INDIC_DATA_YEAR = x103I_INDIC_DATA_YEAR,
                    x103I_INDIC_DATA_TYPE = x103I_INDIC_DATA_TYPE,
                    x103I_INDIC_DATA_MAKE = x103I_INDIC_DATA_MAKE,
                    x103I_INDIC_DATA_MODEL = x103I_INDIC_DATA_MODEL,
                    x103I_INDIC_DATA_SERIAL = x103I_INDIC_DATA_SERIAL,
                    x103I_INDIC_DATA_ADDRESS_1 = x103I_INDIC_DATA_ADDRESS_1,
                    x103I_INDIC_DATA_ADDRESS_2 = x103I_INDIC_DATA_ADDRESS_2,
                    x103I_INDIC_DATA_CITY = x103I_INDIC_DATA_CITY,
                    x103I_INDIC_DATA_STATE = x103I_INDIC_DATA_STATE,
                    x103I_INDIC_DATA_ZIP_CODE = x103I_INDIC_DATA_ZIP_CODE,
                    x103I_INDIC_DATA_USER_AMOUNT = x103I_INDIC_DATA_USER_AMOUNT,
                    x103I_INDIC_DATA_USER_CODE = x103I_INDIC_DATA_USER_CODE,
                    x103I_INDIC_DATA_DATE_RECVD = x103I_INDIC_DATA_DATE_RECVD,
                    x103I_INDIC_DATA_DATE_REL = x103I_INDIC_DATA_DATE_REL,
                    x103I_INDIC_DATA_LOC_RECVD = x103I_INDIC_DATA_LOC_RECVD,
                    x103I_INDIC_DATA_LOC_HELD = x103I_INDIC_DATA_LOC_HELD,
                    x103I_DISPOSITION_ONE = x103I_DISPOSITION_ONE,
                    x103I_INDIC_DATA_ID_NUMBER = x103I_INDIC_DATA_ID_NUMBER,
                    x103I_DISPOSITION_TWO = x103I_DISPOSITION_TWO,
                    x103I_INDIC_DATA_FILING_REF = x103I_INDIC_DATA_FILING_REF,
                    x103I_DISPOSITION_THREE = x103I_DISPOSITION_THREE,
                    x103I_INDIC_DATA_DESC_1 = x103I_INDIC_DATA_DESC_1,
                    x103I_INDIC_DATA_DESC_2 = x103I_INDIC_DATA_DESC_2,
                    x103I_PDI_REQ_CODE = x103I_PDI_REQ_CODE,
                    x103I_PDI_STATUS_CODE = x103I_PDI_STATUS_CODE,
                    x103I_PDI_POLICY_NUMB = x103I_PDI_POLICY_NUMB,
                    x103I_PDI_STATUS_DATE = x103I_PDI_STATUS_DATE,
                    x103I_PDI_COMPANY = x103I_PDI_COMPANY,
                    x103I_PDI_EXP_DATE = x103I_PDI_EXP_DATE,
                    x103I_PDI_AGENT_NAME = x103I_PDI_AGENT_NAME,
                    x103J_DATA_PRESENT_SW = x103J_DATA_PRESENT_SW,
                    x103J_FORE_ABAND_POST_DATE = x103J_FORE_ABAND_POST_DATE,
                    x103J_FORE_ABAND_DATE = x103J_FORE_ABAND_DATE,
                    x103J_LIABILITY_IND = x103J_LIABILITY_IND,
                    x103J_OUTSTANDING_BAL = x103J_OUTSTANDING_BAL,
                    x103J_FORE_BID_PRICE = x103J_FORE_BID_PRICE,
                    x103J_APPRAISAL_VALUE = x103J_APPRAISAL_VALUE,
                    x103J_DESC_1 = x103J_DESC_1,
                    x103J_DESC_2 = x103J_DESC_2,
                    x103J_ODD_DAYS_INT_AMT = x103J_ODD_DAYS_INT_AMT,
                    x103J_DAYS_TO_CHG_PAYOFF = x103J_DAYS_TO_CHG_PAYOFF,
                    x103J_ODD_DAYS_EARN_IND = x103J_ODD_DAYS_EARN_IND,
                    x103J_DAYS_TO_CHG_INS = x103J_DAYS_TO_CHG_INS,
                    x103J_PART_PAYMENT = x103J_PART_PAYMENT,
                    x103J_NUMB_PAYMENTS_MADE = x103J_NUMB_PAYMENTS_MADE,
                    x103J_AMT_FINANCED = x103J_AMT_FINANCED,
                    x103J_COLL_RECD_IND = x103J_COLL_RECD_IND,
                    x103J_PREPAID_FIN_CHGS = x103J_PREPAID_FIN_CHGS,
                    x103J_VARY_RATE_IND = x103J_VARY_RATE_IND,
                    x103J_APR = x103J_APR,
                    x103J_APR_VERIF_IND = x103J_APR_VERIF_IND,
                    x103J_78TH_EARN_DAY = x103J_78TH_EARN_DAY,
                    x103J_78TH_EARN_DAY_INS = x103J_78TH_EARN_DAY_INS,
                    x103J_12_MONTH_PYMNT_HIST = x103J_12_MONTH_PYMNT_HIST
                };
            }
            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetObligationResponse>(Ex, request, "GetObligation");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }

        }

        /// <summary>
        /// Gets the obligation headers.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public GetObligationHeadersResponse GetObligationHeaders(GetObligationHeadersRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            var getObligationHeaderDocIn = new InquiryServicesContext.GetCurrentFutureObligationsInDocument
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

            string X121A_TITLE_CURR_DATE;
            short X121A_ENTRIES_IN_USE;


            X121A_TAB outputField = new X121A_TAB
            {
                X121A_AS_BAL_TYPE = string.Empty,
                X121A_AS_BAL_TYPE_LIT = string.Empty,
                X121A_AS_BASIS = string.Empty,
                X121A_AS_BASIS_LIT = string.Empty,
                X121A_AS_EARN_TYPE = string.Empty,
                X121A_AS_EARN_TYPE_LIT = string.Empty,
                X121A_AS_FM_TIER = 0m,
                X121A_AS_FROM_DT = string.Empty,
                X121A_AS_MEMO = string.Empty,
                X121A_AS_MEMO_LIT = string.Empty,
                X121A_AS_RATE = 0m,
                X121A_AS_TAX_CODE = string.Empty,
                X121A_AS_TAX_CODE_LIT = string.Empty,
                X121A_AS_TO_DT = string.Empty,
                X121A_AS_TO_TIER = 0m,
                X121A_BS_ACCR_TO = string.Empty,
                X121A_BS_BILL_DT = string.Empty,
                X121A_BS_BILL_PERIOD = string.Empty,
                X121A_BS_BILL_PERIOD_LIT = string.Empty,
                X121A_BS_COLL_METH = string.Empty,
                X121A_BS_COLL_METH_LIT = string.Empty,
                X121A_BS_CUST_BILL = string.Empty,
                X121A_BS_CUST_BILL_LIT = string.Empty,
                X121A_BS_DDA = string.Empty,
                X121A_BS_DUE_DT = string.Empty,
                X121A_BS_EXT_TYPE = string.Empty,
                X121A_BS_EXTEND_IND = string.Empty,
                X121A_BS_FROM_DT = string.Empty,
                X121A_BS_GRACE_PERIOD = string.Empty,
                X121A_BS_LEAD_DAYS = string.Empty,
                X121A_BS_MAT_COLL_METH = string.Empty,
                X121A_BS_MAT_COLL_METH_LIT = string.Empty,
                X121A_BS_PRIORITY_CD = string.Empty,
                X121A_BS_REPAY_TP = string.Empty,
                X121A_BS_REPAY_TP_LIT = string.Empty,
                X121A_BS_SPEC_MAIL = string.Empty,
                X121A_BS_TO_DT = string.Empty,
                X121A_BS_TRANS_ID = string.Empty,
                X121A_FILLER_2 = string.Empty,
                X121A_FILLER_2_A = string.Empty,
                X121A_FILLER_2_B = string.Empty,
                X121A_FILLER_2_C = string.Empty,
                X121A_FILLER_3 = string.Empty,
                X121A_FILLER_3_A = string.Empty,
                X121A_FILLER_3_B = string.Empty,
                X121A_FILLER_3_B2 = string.Empty,
                X121A_FILLER_3_B3 = string.Empty,
                X121A_FILLER_3_D = string.Empty,
                X121A_HDG_CHG_CODE = string.Empty,
                X121A_HDR_TYPE_LITERAL = string.Empty,
                X121A_PS_ALT_CAL_IND = string.Empty,
                X121A_PS_ALT_CAL_LIT = string.Empty,
                X121A_PS_ANNV_DT = string.Empty,
                X121A_PS_BREAKAGE = string.Empty,
                X121A_PS_CEILING = 0m,
                X121A_PS_CHG_DAY = string.Empty,
                X121A_PS_CHG_DAY_LIT_1 = string.Empty,
                X121A_PS_CHG_DAY_LIT_2 = string.Empty,
                X121A_PS_FACTOR1 = string.Empty,
                X121A_PS_FACTOR1_LIT = string.Empty,
                X121A_PS_FACTOR2 = string.Empty,
                X121A_PS_FACTOR2_LIT = string.Empty,
                X121A_PS_FLOOR = 0m,
                X121A_PS_FROM_DT = string.Empty,
                X121A_PS_MOD_BUS = string.Empty,
                X121A_PS_NBR_MNTHS = string.Empty,
                X121A_PS_PRIME = string.Empty,
                X121A_PS_RELAT1 = string.Empty,
                X121A_PS_RELAT2 = string.Empty,
                X121A_PS_REPOSITION = string.Empty,
                X121A_PS_TO_DT = string.Empty,
                X121A_TAX_IMA_LIT = string.Empty,
                X121B_DEFERRED_LITERAL = string.Empty,
                X121B_FILLER_01 = string.Empty,
                X121B_FILLER_23 = string.Empty,
                X121B_INT_ADJ_MTD_NOT_THIS_MO = 0m,
                X121B_INT_ADJ_YTD_NOT_THIS_YR = 0m,
                X121B_INT_CHRG_OFF = 0m,
                X121B_INT_ERND_IN_SUSPENSE_MTD = 0m,
                X121B_INT_ERND_IN_SUSPENSE_YTD = 0m,
                X121B_INT_HDR_PREV_ACCR_TO_DTE = string.Empty,
                X121B_INTEREST_ACC_ROUND = 0m,
                X121B_INTEREST_ACCRUAL_DATE = string.Empty,
                X121B_INTEREST_ADJ_EARN_BTD = 0m,
                X121B_INTEREST_ADJ_TO_ITD_DECR = 0m,
                X121B_INTEREST_ADJ_TO_ITD_INCR = 0m,
                X121B_INTEREST_BIL_ROUND = 0m,
                X121B_INTEREST_BILL_NOT_REC = 0m,
                X121B_INTEREST_DAILY_EARNS = 0m,
                X121B_INTEREST_DATE_PAID_TO = string.Empty,
                X121B_INTEREST_DEF_EARN_DT = string.Empty,
                X121B_INTEREST_DEFER_INCOME = 0m,
                X121B_INTEREST_EARNED_BTD = 0m,
                X121B_INTEREST_EARNED_ITD = 0m,
                X121B_INTEREST_EARNED_MTD = 0m,
                X121B_INTEREST_EARNED_YTD = 0m,
                X121B_INTEREST_ERD_SUSPENSE = 0m,
                X121B_INTEREST_LAST_BILL_DT = string.Empty,
                X121B_INTEREST_PAID_ITD = 0m,
                X121B_INTEREST_PAID_MTD = 0m,
                X121B_INTEREST_PAID_SUSPENS = 0m,
                X121B_INTEREST_PAID_TO_PRIN = 0m,
                X121B_INTEREST_PAID_YTD = 0m,
                X121B_INTEREST_PAST_DUE = 0m,
                X121B_INTEREST_PAST_DUE_STS = 0,
                X121B_INTEREST_PD_PRIOR_YR = 0m,
                X121B_INTEREST_PREV_DUE_DAT = string.Empty,
                X121B_INTEREST_START_BAL = 0m,
                X121B_NEGATIVE_AMORT_AMOUNT = 0m,
                X121B_NON_ACCRL_PD_INCOME = 0m,
                X121B_ORIG_SUSPEN_AMOUNT = 0m,
                X121B_PAST_DUE_LIT = string.Empty,
                X121B_RECEIVABLE = 0m,
                X121D_ADD_ON_EARN_DATE = string.Empty,
                X121D_ANTICIP_ERNGS = 0m,
                X121D_APR_EXCL_IND = string.Empty,
                X121D_APR_EXCL_IND_LIT = string.Empty,
                X121D_CLOSE_ADJ_TYPE = string.Empty,
                X121D_CLOSE_ADJ_TYPE_LIT = string.Empty,
                X121D_DELAY_DAYS = 0,
                X121D_EARNINGS_LIT = string.Empty,
                X121D_FIELD_NAME = string.Empty,
                X121D_FIELD_NAME_2 = string.Empty,
                X121D_FINAL_CLOSE_ADJ = 0m,
                X121D_HDR_POINTER_TYPE = string.Empty,
                X121D_HDR_POINTER_TYPE_LIT = string.Empty,
                X121D_INT_CAPITALI_ZED = 0m,
                X121D_INT_METHOD_DEFERRED = 0m,
                X121D_INT_PITD_NOT_RECOG = 0m,
                X121D_INTEREST_ORIG_DISC = 0m,
                X121D_INTEREST_ORIG_TERM = 0,
                X121D_INTEREST_PD_NOT_REPORTED = 0m,
                X121D_INTEREST_PD_REPORTED = 0m,
                X121D_INTEREST_REBATE_DSBUR = 0m,
                X121D_INTEREST_REMAIN_TERM = 0,
                X121D_INTEREST_W_AIVED_MTD = 0m,
                X121D_INTEREST_W_AIVED_YTD = 0m,
                X121D_INTEREST_WAIVED = 0m,
                X121D_MIN_EARN_AMOUNT = 0m,
                X121D_MIN_EARN_CLOSE_AMT = 0m,
                X121D_MIN_EARN_DAY = string.Empty,
                X121D_MIN_EARN_DAY_LIT = string.Empty,
                X121D_MIN_EARN_OVERRIDE = string.Empty,
                X121D_MIN_EARN_OVERRIDE_LIT = string.Empty,
                X121D_MIN_RBTE_AMOUNT = 0m,
                X121D_MIN_RBTE_CHG_CD_IND = string.Empty,
                X121D_MIN_RBTE_CHG_CD_IND_LIT = string.Empty,
                X121D_MIN_RBTE_CODE = string.Empty,
                X121D_MIN_RBTE_OVERRIDE = string.Empty,
                X121D_MIN_RBTE_OVERRIDE_LIT = string.Empty,
                X121D_NET_ACTIVITY_TODAY = 0m,
                X121D_NEXT_REPRICE_DATE = string.Empty,
                X121D_REBATE_BASE_RATE = 0,
                X121D_REBATE_IND = string.Empty,
                X121D_REBATE_IND_LIT = string.Empty,
                X121D_REBATE_METHOD = string.Empty,
                X121D_REBATE_METHOD_LIT = string.Empty,
                X121D_UNACCR_MIN_EARN = 0m,
                X121F_ASSESSED_ITD = 0m,
                X121F_ASSESSED_MTD = 0m,
                X121F_ASSESSED_YTD = 0m,
                X121F_DATA_PRESENT_SW = string.Empty,
                X121F_DATE_LST_ASSESS = string.Empty,
                X121F_EDF_CHARGE = 0m,
                X121F_EDF_LMT_CODE = string.Empty,
                X121F_EDF_LMT_CODE_LITERAL = string.Empty,
                X121F_EDF_METHOD = string.Empty,
                X121F_EDF_METHOD_LITERAL = string.Empty,
                X121F_EVENT_TYPE = string.Empty,
                X121F_EVENT_TYPE_LITERAL = string.Empty,
                X121F_MAX_ASSESS = string.Empty,
                X121F_MIN_ASSESS = string.Empty,
                X121F_NXT_ASSESS_DATE = string.Empty,
                X121F_OCCURS_CHARGE = 0,
                X121F_PERIOD = 0,
                X121F_PERIOD_LITERAL = string.Empty

            };
            X121A_TAB[] outputs = new X121A_TAB[14];
            for (int i = 0; i < 14; i++)
            {
                outputs[i] = outputField;
            }

            try
            {
                inq.GetCurrentFutureObligations(ref getObligationHeaderDocIn.LUW_ID,
                           ref getObligationHeaderDocIn.LUW_REQUEST_CODE,
                           ref getObligationHeaderDocIn.LUW_BATCH_ID,
                           ref getObligationHeaderDocIn.LUW_BANK,
                           ref getObligationHeaderDocIn.LUW_OBLIGOR,
                           ref getObligationHeaderDocIn.LUW_OBLIGATION,
                           ref getObligationHeaderDocIn.LUW_ITEM_NBR,
                           ref getObligationHeaderDocIn.SEG_COUNTER,
                           ref getObligationHeaderDocIn.LUW_HEADER_FILLER,
                           ref getObligationHeaderDocIn.LUW_CALLING_APPL,
                           ref getObligationHeaderDocIn.LUW_LENGTH,
                           ref errors,
                           out X121A_TITLE_CURR_DATE,
                           out X121A_ENTRIES_IN_USE,
                           out outputs,
                           ref ctx
                       );

                var obligationHeaderArray = Array.ConvertAll<X121A_TAB, HeaderInfo>(outputs, delegate(X121A_TAB output)
                {
                    var obligationHeader = new HeaderInfo()
                    {
                        X121A_AS_BAL_TYPE = string.Empty,
                        X121A_AS_BAL_TYPE_LIT = output.X121A_AS_BAL_TYPE_LIT,
                        X121A_AS_BASIS = output.X121A_AS_BASIS,
                        X121A_AS_BASIS_LIT = output.X121A_AS_BASIS_LIT,
                        X121A_AS_EARN_TYPE = output.X121A_AS_EARN_TYPE,
                        X121A_AS_EARN_TYPE_LIT = output.X121A_AS_EARN_TYPE_LIT,
                        X121A_AS_FM_TIER = output.X121A_AS_FM_TIER,
                        X121A_AS_FROM_DT = output.X121A_AS_FROM_DT,
                        X121A_AS_MEMO = output.X121A_AS_MEMO,
                        X121A_AS_MEMO_LIT = output.X121A_AS_MEMO_LIT,
                        X121A_AS_RATE = output.X121A_AS_RATE,
                        X121A_AS_TAX_CODE = output.X121A_AS_TAX_CODE,
                        X121A_AS_TAX_CODE_LIT = output.X121A_AS_TAX_CODE_LIT,
                        X121A_AS_TO_DT = output.X121A_AS_TO_DT,
                        X121A_AS_TO_TIER = output.X121A_AS_TO_TIER,
                        X121A_BS_ACCR_TO = output.X121A_BS_ACCR_TO,
                        X121A_BS_BILL_DT = output.X121A_BS_BILL_DT,
                        X121A_BS_BILL_PERIOD = output.X121A_BS_BILL_PERIOD,
                        X121A_BS_BILL_PERIOD_LIT = output.X121A_BS_BILL_PERIOD_LIT,
                        X121A_BS_COLL_METH = output.X121A_BS_COLL_METH,
                        X121A_BS_COLL_METH_LIT = output.X121A_BS_COLL_METH_LIT,
                        X121A_BS_CUST_BILL = output.X121A_BS_CUST_BILL,
                        X121A_BS_CUST_BILL_LIT = output.X121A_BS_CUST_BILL_LIT,
                        X121A_BS_DDA = output.X121A_BS_DDA,
                        X121A_BS_DUE_DT = output.X121A_BS_DUE_DT,
                        X121A_BS_EXT_TYPE = output.X121A_BS_EXT_TYPE,
                        X121A_BS_EXTEND_IND = output.X121A_BS_EXTEND_IND,
                        X121A_BS_FROM_DT = output.X121A_BS_FROM_DT,
                        X121A_BS_GRACE_PERIOD = output.X121A_BS_GRACE_PERIOD,
                        X121A_BS_LEAD_DAYS = output.X121A_BS_LEAD_DAYS,
                        X121A_BS_MAT_COLL_METH = output.X121A_BS_MAT_COLL_METH,
                        X121A_BS_MAT_COLL_METH_LIT = output.X121A_BS_MAT_COLL_METH_LIT,
                        X121A_BS_PRIORITY_CD = output.X121A_BS_PRIORITY_CD,
                        X121A_BS_REPAY_TP = output.X121A_BS_REPAY_TP,
                        X121A_BS_REPAY_TP_LIT = output.X121A_BS_REPAY_TP_LIT,
                        X121A_BS_SPEC_MAIL = output.X121A_BS_SPEC_MAIL,
                        X121A_BS_TO_DT = output.X121A_BS_TO_DT,
                        X121A_BS_TRANS_ID = output.X121A_BS_TRANS_ID,
                        X121A_FILLER_2 = output.X121A_FILLER_2,
                        X121A_FILLER_2_A = output.X121A_FILLER_2_A,
                        X121A_FILLER_2_B = output.X121A_FILLER_2_B,
                        X121A_FILLER_2_C = output.X121A_FILLER_2_C,
                        X121A_FILLER_3 = output.X121A_FILLER_3,
                        X121A_FILLER_3_A = output.X121A_FILLER_3_A,
                        X121A_FILLER_3_B = output.X121A_FILLER_3_B,
                        X121A_FILLER_3_B2 = output.X121A_FILLER_3_B2,
                        X121A_FILLER_3_B3 = output.X121A_FILLER_3_B3,
                        X121A_FILLER_3_D = output.X121A_FILLER_3_D,
                        X121A_HDG_CHG_CODE = output.X121A_HDG_CHG_CODE,
                        X121A_HDR_TYPE_LITERAL = output.X121A_HDR_TYPE_LITERAL,
                        X121A_PS_ALT_CAL_IND = output.X121A_PS_ALT_CAL_IND,
                        X121A_PS_ALT_CAL_LIT = output.X121A_PS_ALT_CAL_LIT,
                        X121A_PS_ANNV_DT = output.X121A_PS_ANNV_DT,
                        X121A_PS_BREAKAGE = output.X121A_PS_BREAKAGE,
                        X121A_PS_CEILING = output.X121A_PS_CEILING,
                        X121A_PS_CHG_DAY = output.X121A_PS_CHG_DAY,
                        X121A_PS_CHG_DAY_LIT_1 = output.X121A_PS_CHG_DAY_LIT_1,
                        X121A_PS_CHG_DAY_LIT_2 = output.X121A_PS_CHG_DAY_LIT_2,
                        X121A_PS_FACTOR1 = output.X121A_PS_FACTOR1,
                        X121A_PS_FACTOR1_LIT = output.X121A_PS_FACTOR1_LIT,
                        X121A_PS_FACTOR2 = output.X121A_PS_FACTOR2,
                        X121A_PS_FACTOR2_LIT = output.X121A_PS_FACTOR2_LIT,
                        X121A_PS_FLOOR = output.X121A_PS_FLOOR,
                        X121A_PS_FROM_DT = output.X121A_PS_FROM_DT,
                        X121A_PS_MOD_BUS = output.X121A_PS_MOD_BUS,
                        X121A_PS_NBR_MNTHS = output.X121A_PS_NBR_MNTHS,
                        X121A_PS_PRIME = output.X121A_PS_PRIME,
                        X121A_PS_RELAT1 = output.X121A_PS_RELAT1,
                        X121A_PS_RELAT2 = output.X121A_PS_RELAT2,
                        X121A_PS_REPOSITION = output.X121A_PS_REPOSITION,
                        X121A_PS_TO_DT = output.X121A_PS_TO_DT,
                        X121A_TAX_IMA_LIT = output.X121A_TAX_IMA_LIT,
                        X121B_DEFERRED_LITERAL = output.X121B_DEFERRED_LITERAL,
                        X121B_FILLER_01 = output.X121B_FILLER_01,
                        X121B_FILLER_23 = output.X121B_FILLER_23,
                        X121B_INT_ADJ_MTD_NOT_THIS_MO = output.X121B_INT_ADJ_MTD_NOT_THIS_MO,
                        X121B_INT_ADJ_YTD_NOT_THIS_YR = output.X121B_INT_ADJ_YTD_NOT_THIS_YR,
                        X121B_INT_CHRG_OFF = output.X121B_INT_CHRG_OFF,
                        X121B_INT_ERND_IN_SUSPENSE_MTD = output.X121B_INT_ERND_IN_SUSPENSE_MTD,
                        X121B_INT_ERND_IN_SUSPENSE_YTD = output.X121B_INT_ERND_IN_SUSPENSE_YTD,
                        X121B_INT_HDR_PREV_ACCR_TO_DTE = output.X121B_INT_HDR_PREV_ACCR_TO_DTE,
                        X121B_INTEREST_ACC_ROUND = output.X121B_INTEREST_ACC_ROUND,
                        X121B_INTEREST_ACCRUAL_DATE = output.X121B_INTEREST_ACCRUAL_DATE,
                        X121B_INTEREST_ADJ_EARN_BTD = output.X121B_INTEREST_ADJ_EARN_BTD,
                        X121B_INTEREST_ADJ_TO_ITD_DECR = output.X121B_INTEREST_ADJ_TO_ITD_DECR,
                        X121B_INTEREST_ADJ_TO_ITD_INCR = output.X121B_INTEREST_ADJ_TO_ITD_INCR,
                        X121B_INTEREST_BIL_ROUND = output.X121B_INTEREST_BIL_ROUND,
                        X121B_INTEREST_BILL_NOT_REC = output.X121B_INTEREST_BILL_NOT_REC,
                        X121B_INTEREST_DAILY_EARNS = output.X121B_INTEREST_DAILY_EARNS,
                        X121B_INTEREST_DATE_PAID_TO = output.X121B_INTEREST_DATE_PAID_TO,
                        X121B_INTEREST_DEF_EARN_DT = output.X121B_INTEREST_DEF_EARN_DT,
                        X121B_INTEREST_DEFER_INCOME = output.X121B_INTEREST_DEFER_INCOME,
                        X121B_INTEREST_EARNED_BTD = output.X121B_INTEREST_EARNED_BTD,
                        X121B_INTEREST_EARNED_ITD = output.X121B_INTEREST_EARNED_ITD,
                        X121B_INTEREST_EARNED_MTD = output.X121B_INTEREST_EARNED_MTD,
                        X121B_INTEREST_EARNED_YTD = output.X121B_INTEREST_EARNED_YTD,
                        X121B_INTEREST_ERD_SUSPENSE = output.X121B_INTEREST_ERD_SUSPENSE,
                        X121B_INTEREST_LAST_BILL_DT = output.X121B_INTEREST_LAST_BILL_DT,
                        X121B_INTEREST_PAID_ITD = output.X121B_INTEREST_PAID_ITD,
                        X121B_INTEREST_PAID_MTD = output.X121B_INTEREST_PAID_MTD,
                        X121B_INTEREST_PAID_SUSPENS = output.X121B_INTEREST_PAID_SUSPENS,
                        X121B_INTEREST_PAID_TO_PRIN = output.X121B_INTEREST_PAID_TO_PRIN,
                        X121B_INTEREST_PAID_YTD = output.X121B_INTEREST_PAID_YTD,
                        X121B_INTEREST_PAST_DUE = output.X121B_INTEREST_PAST_DUE,
                        X121B_INTEREST_PAST_DUE_STS = output.X121B_INTEREST_PAST_DUE_STS,
                        X121B_INTEREST_PD_PRIOR_YR = output.X121B_INTEREST_PD_PRIOR_YR,
                        X121B_INTEREST_PREV_DUE_DAT = output.X121B_INTEREST_PREV_DUE_DAT,
                        X121B_INTEREST_START_BAL = output.X121B_INTEREST_START_BAL,
                        X121B_NEGATIVE_AMORT_AMOUNT = output.X121B_NEGATIVE_AMORT_AMOUNT,
                        X121B_NON_ACCRL_PD_INCOME = output.X121B_NON_ACCRL_PD_INCOME,
                        X121B_ORIG_SUSPEN_AMOUNT = output.X121B_ORIG_SUSPEN_AMOUNT,
                        X121B_PAST_DUE_LIT = output.X121B_PAST_DUE_LIT,
                        X121B_RECEIVABLE = output.X121B_RECEIVABLE,
                        X121D_ADD_ON_EARN_DATE = output.X121D_ADD_ON_EARN_DATE,
                        X121D_ANTICIP_ERNGS = output.X121D_ANTICIP_ERNGS,
                        X121D_APR_EXCL_IND = output.X121D_APR_EXCL_IND,
                        X121D_APR_EXCL_IND_LIT = output.X121D_APR_EXCL_IND_LIT,
                        X121D_CLOSE_ADJ_TYPE = output.X121D_CLOSE_ADJ_TYPE,
                        X121D_CLOSE_ADJ_TYPE_LIT = output.X121D_CLOSE_ADJ_TYPE_LIT,
                        X121D_DELAY_DAYS = output.X121D_DELAY_DAYS,
                        X121D_EARNINGS_LIT = output.X121D_EARNINGS_LIT,
                        X121D_FIELD_NAME = output.X121D_FIELD_NAME,
                        X121D_FIELD_NAME_2 = output.X121D_FIELD_NAME_2,
                        X121D_FINAL_CLOSE_ADJ = output.X121D_FINAL_CLOSE_ADJ,
                        X121D_HDR_POINTER_TYPE = output.X121D_HDR_POINTER_TYPE,
                        X121D_HDR_POINTER_TYPE_LIT = output.X121D_HDR_POINTER_TYPE_LIT,
                        X121D_INT_CAPITALI_ZED = output.X121D_INT_CAPITALI_ZED,
                        X121D_INT_METHOD_DEFERRED = output.X121D_INT_METHOD_DEFERRED,
                        X121D_INT_PITD_NOT_RECOG = output.X121D_INT_PITD_NOT_RECOG,
                        X121D_INTEREST_ORIG_DISC = output.X121D_INTEREST_ORIG_DISC,
                        X121D_INTEREST_ORIG_TERM = output.X121D_INTEREST_ORIG_TERM,
                        X121D_INTEREST_PD_NOT_REPORTED = output.X121D_INTEREST_PD_NOT_REPORTED,
                        X121D_INTEREST_PD_REPORTED = output.X121D_INTEREST_PD_REPORTED,
                        X121D_INTEREST_REBATE_DSBUR = output.X121D_INTEREST_REBATE_DSBUR,
                        X121D_INTEREST_REMAIN_TERM = output.X121D_INTEREST_REMAIN_TERM,
                        X121D_INTEREST_W_AIVED_MTD = output.X121D_INTEREST_W_AIVED_MTD,
                        X121D_INTEREST_W_AIVED_YTD = output.X121D_INTEREST_W_AIVED_YTD,
                        X121D_INTEREST_WAIVED = output.X121D_INTEREST_WAIVED,
                        X121D_MIN_EARN_AMOUNT = output.X121D_MIN_EARN_AMOUNT,
                        X121D_MIN_EARN_CLOSE_AMT = output.X121D_MIN_EARN_CLOSE_AMT,
                        X121D_MIN_EARN_DAY = output.X121D_MIN_EARN_DAY,
                        X121D_MIN_EARN_DAY_LIT = output.X121D_MIN_EARN_DAY_LIT,
                        X121D_MIN_EARN_OVERRIDE = output.X121D_MIN_EARN_OVERRIDE,
                        X121D_MIN_EARN_OVERRIDE_LIT = output.X121D_MIN_EARN_OVERRIDE_LIT,
                        X121D_MIN_RBTE_AMOUNT = output.X121D_MIN_RBTE_AMOUNT,
                        X121D_MIN_RBTE_CHG_CD_IND = output.X121D_MIN_RBTE_CHG_CD_IND,
                        X121D_MIN_RBTE_CHG_CD_IND_LIT = output.X121D_MIN_RBTE_CHG_CD_IND_LIT,
                        X121D_MIN_RBTE_CODE = output.X121D_MIN_RBTE_CODE,
                        X121D_MIN_RBTE_OVERRIDE = output.X121D_MIN_RBTE_OVERRIDE,
                        X121D_MIN_RBTE_OVERRIDE_LIT = output.X121D_MIN_RBTE_OVERRIDE_LIT,
                        X121D_NET_ACTIVITY_TODAY = output.X121D_NET_ACTIVITY_TODAY,
                        X121D_NEXT_REPRICE_DATE = output.X121D_NEXT_REPRICE_DATE,
                        X121D_REBATE_BASE_RATE = output.X121D_REBATE_BASE_RATE,
                        X121D_REBATE_IND = output.X121D_REBATE_IND,
                        X121D_REBATE_IND_LIT = output.X121D_REBATE_IND_LIT,
                        X121D_REBATE_METHOD = output.X121D_REBATE_METHOD,
                        X121D_REBATE_METHOD_LIT = output.X121D_REBATE_METHOD_LIT,
                        X121D_UNACCR_MIN_EARN = output.X121D_UNACCR_MIN_EARN,
                        X121F_ASSESSED_ITD = output.X121F_ASSESSED_ITD,
                        X121F_ASSESSED_MTD = output.X121F_ASSESSED_MTD,
                        X121F_ASSESSED_YTD = output.X121F_ASSESSED_YTD,
                        X121F_DATA_PRESENT_SW = output.X121F_DATA_PRESENT_SW,
                        X121F_DATE_LST_ASSESS = output.X121F_DATE_LST_ASSESS,
                        X121F_EDF_CHARGE = output.X121F_EDF_CHARGE,
                        X121F_EDF_LMT_CODE = output.X121F_EDF_LMT_CODE,
                        X121F_EDF_LMT_CODE_LITERAL = output.X121F_EDF_LMT_CODE_LITERAL,
                        X121F_EDF_METHOD = output.X121F_EDF_METHOD,
                        X121F_EDF_METHOD_LITERAL = output.X121F_EDF_METHOD_LITERAL,
                        X121F_EVENT_TYPE = output.X121F_EVENT_TYPE,
                        X121F_EVENT_TYPE_LITERAL = output.X121F_EVENT_TYPE_LITERAL,
                        X121F_MAX_ASSESS = output.X121F_MAX_ASSESS,
                        X121F_MIN_ASSESS = output.X121F_MIN_ASSESS,
                        X121F_NXT_ASSESS_DATE = output.X121F_NXT_ASSESS_DATE,
                        X121F_OCCURS_CHARGE = output.X121F_OCCURS_CHARGE,
                        X121F_PERIOD = output.X121F_PERIOD,
                        X121F_PERIOD_LITERAL = output.X121F_PERIOD_LITERAL
                    };
                    return obligationHeader;

                });

                return new GetObligationHeadersResponse() { HeaderInfoList = obligationHeaderArray.ToList(), Errors = errors };
            }
            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetObligationHeadersResponse>(Ex, request, "GetObligationHeaders");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }

        }

        /// <summary>
        /// Gets the participations.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetParticipationsResponse GetParticipations(GetParticipationsRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            var getParticipationsDocIn = new InquiryServicesContext.GetParticipationsInDocument
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
            string x141A_OBGAT;
            string x141A_OBGOR;

            try
            {
                inq.GetParticipations(ref getParticipationsDocIn.LUW_ID,
                                ref getParticipationsDocIn.LUW_REQUEST_CODE,
                                ref getParticipationsDocIn.LUW_BATCH_ID,
                                ref getParticipationsDocIn.LUW_BANK,
                                ref getParticipationsDocIn.LUW_OBLIGOR,
                                ref getParticipationsDocIn.LUW_OBLIGATION,
                                ref getParticipationsDocIn.LUW_ITEM_NBR,
                                ref getParticipationsDocIn.SEG_COUNTER,
                                ref getParticipationsDocIn.LUW_HEADER_FILLER,
                                ref getParticipationsDocIn.LUW_CALLING_APPL,
                                ref getParticipationsDocIn.LUW_LENGTH,
                                ref errors,
                                out x141A_OBGAT,
                                out x141A_OBGOR,
                                ref ctx);

                return new GetParticipationsResponse()
                {
                    Errors = errors,
                    x141A_OBGAT = x141A_OBGAT,
                    x141A_OBGOR = x141A_OBGOR
                };
            }

            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetParticipationsResponse>(Ex, request, "GetParticipations");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }
        }

        /// <summary>
        /// Gets the indirect liabilities.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetIndirectLiabilitiesResponse GetIndirectLiabilities(GetIndirectLiabilitiesRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;

            InquiryServicesContext.LUW_152A_TABLE outputField = new InquiryServicesContext.LUW_152A_TABLE { LUW_152A_EFF_DT = string.Empty, LUW_152A_EXP_DT = string.Empty, LUW_152A_LIMIT = string.Empty, LUW_152A_LITERAL = string.Empty, LUW_152A_OBGAT_NUMB = string.Empty, LUW_152A_OBGOR = string.Empty, LUW_152A_OBLIGOR_NAME = string.Empty, LUW_152A_PCT = string.Empty, LUW_152A_PD_IND_OPT = string.Empty, LUW_152A_REF_CD = string.Empty };
            InquiryServicesContext.LUW_152A_TABLE[] outputs = new InquiryServicesContext.LUW_152A_TABLE[200];

            for (int i = 0; i < 200; i++)
            {
                outputs[i] = outputField;
            }
            var getIndirectLiabilitiesDocIn = new InquiryServicesContext.GetIndirectInDocument
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
                inq.GetIndirect(
                    ref getIndirectLiabilitiesDocIn.LUW_ID,
                    ref getIndirectLiabilitiesDocIn.LUW_REQUEST_CODE,
                    ref getIndirectLiabilitiesDocIn.LUW_BATCH_ID,
                    ref getIndirectLiabilitiesDocIn.LUW_BANK,
                    ref getIndirectLiabilitiesDocIn.LUW_OBLIGOR,
                    ref getIndirectLiabilitiesDocIn.LUW_OBLIGATION,
                    ref getIndirectLiabilitiesDocIn.LUW_ITEM_NBR,
                    ref getIndirectLiabilitiesDocIn.SEG_COUNTER,
                    ref getIndirectLiabilitiesDocIn.LUW_HEADER_FILLER,
                    ref getIndirectLiabilitiesDocIn.LUW_CALLING_APPL,
                    ref getIndirectLiabilitiesDocIn.LUW_LENGTH,
                    ref errors,
                    out outputs,
                    ref ctx);

                var getIndirectLibilties = Array.ConvertAll<InquiryServicesContext.LUW_152A_TABLE, IndirectLiabilities>(outputs, delegate(InquiryServicesContext.LUW_152A_TABLE output)
                {
                    var getIndirect = new IndirectLiabilities()
                    {
                        LUW_152A_EFF_DT = output.LUW_152A_EFF_DT,
                        LUW_152A_EXP_DT = output.LUW_152A_EXP_DT,
                        LUW_152A_LIMIT = output.LUW_152A_LIMIT,
                        LUW_152A_LITERAL = output.LUW_152A_LITERAL,
                        LUW_152A_OBGAT_NUMB = output.LUW_152A_OBGAT_NUMB,
                        LUW_152A_OBGOR = output.LUW_152A_OBGOR,
                        LUW_152A_OBLIGOR_NAME = output.LUW_152A_OBLIGOR_NAME,
                        LUW_152A_PCT = output.LUW_152A_PCT,
                        LUW_152A_PD_IND_OPT = output.LUW_152A_PD_IND_OPT,
                        LUW_152A_REF_CD = output.LUW_152A_REF_CD
                    };

                    return getIndirect;
                });
                return new GetIndirectLiabilitiesResponse() { IndirectLiabilityDetails = getIndirectLibilties.ToList(), Errors = errors };
            }
            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetIndirectLiabilitiesResponse>(Ex, request, "GetIndirectLiabilities");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }
        }

        /// <summary>
        /// Gets the accrual schedules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetAccrualSchedulesResponse GetAccrualSchedules(GetAccrualSchedulesRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            string x131A_LINE24_MESSAGE = null;

            InquiryServicesContext.LUW_131A_TABLE_000 outputField = new InquiryServicesContext.LUW_131A_TABLE_000 { x131A_CHARGE_CODE_A = string.Empty, x131A_EFF_FM_DT_A = string.Empty, x131A_EFF_TO_DT_A = string.Empty, x131A_MEMO_ITEM_A = string.Empty, x131A_RATE_A = string.Empty, x131A_BAL_TYPE_A = string.Empty, x131A_FM_TIER_AMT_PCT_A = string.Empty, x131A_EARN_TYPE_A = string.Empty, x131A_TO_TIER_AMT_A = string.Empty, x131A_BASIS_A = string.Empty, x131A_TAX_CODE_A = string.Empty };
            InquiryServicesContext.LUW_131A_TABLE_000[] outputs = new InquiryServicesContext.LUW_131A_TABLE_000[152];

            for (int i = 0; i < 152; i++)
            {
                outputs[i] = outputField;
            }
            var getAccrualSchedulesDocIn = new InquiryServicesContext.GetAccrualSchedulesInDocument
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
                inq.GetAccrualSchedules(
                    ref getAccrualSchedulesDocIn.LUW_ID,
                    ref getAccrualSchedulesDocIn.LUW_REQUEST_CODE,
                    ref getAccrualSchedulesDocIn.LUW_BATCH_ID,
                    ref getAccrualSchedulesDocIn.LUW_BANK,
                    ref getAccrualSchedulesDocIn.LUW_OBLIGOR,
                    ref getAccrualSchedulesDocIn.LUW_OBLIGATION,
                    ref getAccrualSchedulesDocIn.LUW_ITEM_NBR,
                    ref getAccrualSchedulesDocIn.SEG_COUNTER,
                    ref getAccrualSchedulesDocIn.LUW_HEADER_FILLER,
                    ref getAccrualSchedulesDocIn.LUW_CALLING_APPL,
                    ref getAccrualSchedulesDocIn.LUW_LENGTH,
                    ref errors,
                    out outputs,
                    out x131A_LINE24_MESSAGE,
                    ref ctx);

                var getAccrualSchedule = Array.ConvertAll<InquiryServicesContext.LUW_131A_TABLE_000, AccrualSchedulesDetails>(outputs, delegate(InquiryServicesContext.LUW_131A_TABLE_000 output)
                {
                    var getaccrual = new AccrualSchedulesDetails()
                    {
                        x131A_BAL_TYPE_A = output.x131A_BAL_TYPE_A,
                        x131A_BASIS_A = output.x131A_BASIS_A,
                        x131A_CHARGE_CODE_A = output.x131A_CHARGE_CODE_A,
                        x131A_EARN_TYPE_A = output.x131A_EARN_TYPE_A,
                        x131A_EFF_FM_DT_A = output.x131A_EFF_FM_DT_A,
                        x131A_EFF_TO_DT_A = output.x131A_EFF_TO_DT_A,
                        x131A_FM_TIER_AMT_PCT_A = output.x131A_FM_TIER_AMT_PCT_A,
                        x131A_MEMO_ITEM_A = output.x131A_MEMO_ITEM_A,
                        x131A_RATE_A = output.x131A_RATE_A,
                        x131A_TAX_CODE_A = output.x131A_TAX_CODE_A,
                        x131A_TO_TIER_AMT_A = output.x131A_TO_TIER_AMT_A
                    };

                    return getaccrual;
                });
                return new GetAccrualSchedulesResponse() { accrualSchedulesDetails = getAccrualSchedule.ToList(), Errors = errors };
            }
            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetAccrualSchedulesResponse>(Ex, request, "GetAccrualSchedules");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }
        }

        /// <summary>
        /// Gets the billing schedules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetBillingSchedulesResponse GetBillingSchedules(GetBillingSchedulesRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            string x133A_LINE24_MESSAGE = null;

            InquiryServicesContext.LUW_133A_TABLE_000 outputField =
                new InquiryServicesContext.LUW_133A_TABLE_000
                {
                    x133A_CHG_CODE_A = string.Empty,
                    x133A_ACCR_LMT_CD_A = string.Empty,
                    x133A_BILL_LMT_CD_A = string.Empty,
                    x133A_EFF_FROM_DATE_A = string.Empty,
                    x133A_EFF_TO_DATE_A = string.Empty,
                    x133A_SPEC_MAIL_A = string.Empty,
                    x133A_ACCRU_TO_A = string.Empty,
                    x133A_DUE_DATE_A = string.Empty,
                    x133A_LEAD_DAYS_A = string.Empty,
                    x133A_CUST_BILL_A = string.Empty,
                    x133A_REPAY_TYPE_A = string.Empty,
                    x133A_COLL_METH_A = string.Empty,
                    x133A_DDA_A = string.Empty,
                    x133A_BILL_PER_A = string.Empty,
                    x133A_TRANSIT_A = string.Empty,
                    x133A_MAT_COLL_METH_A = string.Empty
                };
            InquiryServicesContext.LUW_133A_TABLE_000[] outputs = new InquiryServicesContext.LUW_133A_TABLE_000[142];

            for (int i = 0; i < 142; i++)
            {
                outputs[i] = outputField;
            }
            var getBillingSchedulesDocIn = new InquiryServicesContext.GetBillingSchedulesInDocument
            {

                LUW_ID = request.Luw,
                LUW_REQUEST_CODE = request.RestartRequestCode,
                LUW_BATCH_ID = request.BatchID,
                LUW_BANK = request.BankId,
                LUW_OBLIGOR = request.ObligorNumber,
                LUW_OBLIGATION = request.ObligationNumber,
                LUW_ITEM_NBR = request.ItemNumber,
                SEG_COUNTER = request.Segment,
                LUW_HEADER_FILLER = string.Empty,
                LUW_CALLING_APPL = Constants.LUW_HEADER_CALLING_APPL,
                LUW_LENGTH = request.DataLength,
                LUW_ERROR_MESSAGES = request.Errors
            };
            try
            {
                inq.GetBillingSchedules(
                    ref getBillingSchedulesDocIn.LUW_ID,
                    ref getBillingSchedulesDocIn.LUW_REQUEST_CODE,
                    ref getBillingSchedulesDocIn.LUW_BATCH_ID,
                    ref getBillingSchedulesDocIn.LUW_BANK,
                    ref getBillingSchedulesDocIn.LUW_OBLIGOR,
                    ref getBillingSchedulesDocIn.LUW_OBLIGATION,
                    ref getBillingSchedulesDocIn.LUW_ITEM_NBR,
                    ref getBillingSchedulesDocIn.SEG_COUNTER,
                    ref getBillingSchedulesDocIn.LUW_HEADER_FILLER,
                    ref getBillingSchedulesDocIn.LUW_CALLING_APPL,
                    ref getBillingSchedulesDocIn.LUW_LENGTH,
                    ref errors,
                    out outputs,
                    out x133A_LINE24_MESSAGE,
                    ref ctx);

                var getBillingSchedule = Array.ConvertAll<InquiryServicesContext.LUW_133A_TABLE_000, BillingSchedulesDetails>(outputs, delegate(InquiryServicesContext.LUW_133A_TABLE_000 output)
                {
                    var getbilling = new BillingSchedulesDetails()
                    {
                        x133A_CHG_CODE_A = output.x133A_CHG_CODE_A,
                        x133A_ACCR_LMT_CD_A = output.x133A_ACCR_LMT_CD_A,
                        x133A_BILL_LMT_CD_A = output.x133A_BILL_LMT_CD_A,
                        x133A_EFF_FROM_DATE_A = output.x133A_EFF_FROM_DATE_A,
                        x133A_EFF_TO_DATE_A = output.x133A_EFF_TO_DATE_A,
                        x133A_SPEC_MAIL_A = output.x133A_SPEC_MAIL_A,
                        x133A_ACCRU_TO_A = output.x133A_ACCRU_TO_A,
                        x133A_DUE_DATE_A = output.x133A_DUE_DATE_A,
                        x133A_LEAD_DAYS_A = output.x133A_LEAD_DAYS_A,
                        x133A_CUST_BILL_A = output.x133A_CUST_BILL_A,
                        x133A_REPAY_TYPE_A = output.x133A_REPAY_TYPE_A,
                        x133A_COLL_METH_A = output.x133A_COLL_METH_A,
                        x133A_DDA_A = output.x133A_DDA_A,
                        x133A_BILL_PER_A = output.x133A_BILL_PER_A,
                        x133A_TRANSIT_A = output.x133A_TRANSIT_A,
                        x133A_MAT_COLL_METH_A = output.x133A_MAT_COLL_METH_A

                    };

                    return getbilling;
                });
                return new GetBillingSchedulesResponse() { billingSchedulesDetails = getBillingSchedule.ToList(), Errors = errors };
            }
            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetBillingSchedulesResponse>(Ex, request, "GetBillingSchedules");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }
        }

        /// <summary>
        /// Gets the prime schedules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetPrimeSchedulesResponse GetPrimeSchedules(GetPrimeSchedulesRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            string x137A_LINE24_MESSAGE = null;

            InquiryServicesContext.LUW_137A_TABLE_000 outputField = new InquiryServicesContext.LUW_137A_TABLE_000 { x137A_ANNV_DT_A = string.Empty, x137A_CEILING_A = string.Empty, x137A_CHANGE_DAY_A = string.Empty, x137A_CHG_CODE_A = string.Empty, x137A_EFF_FROM_DATE_A = string.Empty, x137A_EFF_TO_DATE_A = string.Empty, x137A_FACTOR1_A = string.Empty, x137A_FLOOR_A = string.Empty, x137A_NBR_MNTHS_A = string.Empty, x137A_PRIME_A = string.Empty, x137A_RELATION1_A = string.Empty };
            InquiryServicesContext.LUW_137A_TABLE_000[] outputs = new InquiryServicesContext.LUW_137A_TABLE_000[162];

            for (int i = 0; i < 162; i++)
            {
                outputs[i] = outputField;
            }
            var getPrimeSchedulesDocIn = new InquiryServicesContext.GetPrimeSchedulesInDocument
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
                inq.GetPrimeSchedules(
                    ref getPrimeSchedulesDocIn.LUW_ID,
                    ref getPrimeSchedulesDocIn.LUW_REQUEST_CODE,
                    ref getPrimeSchedulesDocIn.LUW_BATCH_ID,
                    ref getPrimeSchedulesDocIn.LUW_BANK,
                    ref getPrimeSchedulesDocIn.LUW_OBLIGOR,
                    ref getPrimeSchedulesDocIn.LUW_OBLIGATION,
                    ref getPrimeSchedulesDocIn.LUW_ITEM_NBR,
                    ref getPrimeSchedulesDocIn.SEG_COUNTER,
                    ref getPrimeSchedulesDocIn.LUW_HEADER_FILLER,
                    ref getPrimeSchedulesDocIn.LUW_CALLING_APPL,
                    ref getPrimeSchedulesDocIn.LUW_LENGTH,
                    ref errors,
                    out outputs,
                    out x137A_LINE24_MESSAGE,
                    ref ctx);

                var getPrimeSchedule = Array.ConvertAll<InquiryServicesContext.LUW_137A_TABLE_000, PrimeSchedulesDetails>(outputs, delegate(InquiryServicesContext.LUW_137A_TABLE_000 output)
                {
                    var getprime = new PrimeSchedulesDetails()
                    {
                        x137A_ANNV_DT_A = output.x137A_ANNV_DT_A,
                        x137A_CEILING_A = output.x137A_CEILING_A,
                        x137A_CHANGE_DAY_A = output.x137A_CHANGE_DAY_A,
                        x137A_CHG_CODE_A = output.x137A_CHG_CODE_A,
                        x137A_EFF_FROM_DATE_A = output.x137A_EFF_FROM_DATE_A,
                        x137A_EFF_TO_DATE_A = output.x137A_EFF_TO_DATE_A,
                        x137A_FACTOR1_A = output.x137A_FACTOR1_A,
                        x137A_FLOOR_A = output.x137A_FLOOR_A,
                        x137A_NBR_MNTHS_A = output.x137A_NBR_MNTHS_A,
                        x137A_PRIME_A = output.x137A_PRIME_A,
                        x137A_RELATION1_A = output.x137A_RELATION1_A
                    };

                    return getprime;
                });
                return new GetPrimeSchedulesResponse() { primeSchedulesDetails = getPrimeSchedule.ToList(), Errors = errors };
            }
            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetPrimeSchedulesResponse>(Ex, request, "GetPrimeSchedules");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }
        }

        /// <summary>
        /// Gets the principal repayment schedules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetPrincipalRepaySchedulesResponse GetPrincipalRepaymentSchedules(GetPrincipalRepaySchedulesRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            string x135A_LINE24_MESSAGE = null;


            InquiryServicesContext.LUW_135A_TABLE_000 outputField = new InquiryServicesContext.LUW_135A_TABLE_000 { x135A_AMT_DUE_A = string.Empty, x135A_BILL_FREQ_A = string.Empty, x135A_BILL_LMT_CD_A = string.Empty, x135A_CHG_CODE_A = string.Empty, x135A_COLL_METH_A = string.Empty, x135A_DDA_A = string.Empty, x135A_DUE_DT_A = string.Empty, x135A_FM_DT_A = string.Empty, x135A_LEAD_DAYS_A = string.Empty, x135A_MAT_COLL_METH_A = string.Empty, x135A_REPAY_TYPE_A = string.Empty, x135A_SPEC_MAIL_A = string.Empty, x135A_TO_DT_A = string.Empty, x135A_TRANSIT_A = string.Empty };

            InquiryServicesContext.LUW_135A_TABLE_000[] outputs = new InquiryServicesContext.LUW_135A_TABLE_000[147];

            for (int i = 0; i < 147; i++)
            {
                outputs[i] = outputField;
            }
            var getPrincipalRepaymentSchedulesDocIn = new InquiryServicesContext.GetPrincipleRepaymentSchedulesInDocument
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
                inq.GetPrincipleRepaymentSchedules(
                    ref getPrincipalRepaymentSchedulesDocIn.LUW_ID,
                    ref getPrincipalRepaymentSchedulesDocIn.LUW_REQUEST_CODE,
                    ref getPrincipalRepaymentSchedulesDocIn.LUW_BATCH_ID,
                    ref getPrincipalRepaymentSchedulesDocIn.LUW_BANK,
                    ref getPrincipalRepaymentSchedulesDocIn.LUW_OBLIGOR,
                    ref getPrincipalRepaymentSchedulesDocIn.LUW_OBLIGATION,
                    ref getPrincipalRepaymentSchedulesDocIn.LUW_ITEM_NBR,
                    ref getPrincipalRepaymentSchedulesDocIn.SEG_COUNTER,
                    ref getPrincipalRepaymentSchedulesDocIn.LUW_HEADER_FILLER,
                    ref getPrincipalRepaymentSchedulesDocIn.LUW_CALLING_APPL,
                    ref getPrincipalRepaymentSchedulesDocIn.LUW_LENGTH,
                    ref errors,
                    out outputs,
                    out x135A_LINE24_MESSAGE,
                    ref ctx);

                var getPrincipalRepaymentSchedules = Array.ConvertAll<InquiryServicesContext.LUW_135A_TABLE_000, GetPrincipalRepaySchedules>(outputs, delegate(InquiryServicesContext.LUW_135A_TABLE_000 output)
                {

                    var getPrincipalRepayment = new GetPrincipalRepaySchedules()
                   {
                       x135A_AMT_DUE_A = output.x135A_AMT_DUE_A.Length > 0 ? decimal.Parse(output.x135A_AMT_DUE_A) / 100 : 0M,
                       x135A_BILL_FREQ_A = output.x135A_BILL_FREQ_A,
                       x135A_BILL_LMT_CD_A = output.x135A_BILL_LMT_CD_A,
                       x135A_CHG_CODE_A = output.x135A_CHG_CODE_A,
                       x135A_COLL_METH_A = output.x135A_COLL_METH_A,
                       x135A_DDA_A = output.x135A_DDA_A,
                       x135A_DUE_DT_A = output.x135A_DUE_DT_A,
                       x135A_FM_DT_A = output.x135A_FM_DT_A,
                       x135A_LEAD_DAYS_A = output.x135A_LEAD_DAYS_A,
                       x135A_MAT_COLL_METH_A = output.x135A_MAT_COLL_METH_A,
                       x135A_REPAY_TYPE_A = output.x135A_REPAY_TYPE_A,
                       x135A_SPEC_MAIL_A = output.x135A_SPEC_MAIL_A,
                       x135A_TO_DT_A = output.x135A_TO_DT_A,
                       x135A_TRANSIT_A = output.x135A_TRANSIT_A

                   };

                    return getPrincipalRepayment;
                });
                return new GetPrincipalRepaySchedulesResponse() { getPrincipalRepaySchedules = getPrincipalRepaymentSchedules.ToList(), Errors = errors };
            }
            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetPrincipalRepaySchedulesResponse>(Ex, request, "GetPrincipalRepaySchedules");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }

        }

        /// <summary>
        /// Gets the collateral for obligor.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetCollateralForObligorResponse GetCollateralForObligor(GetCollateralForObligorRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            string errors = null;
            string outputBlock = string.Empty;
            int noOfRequery = 0;
            REQUEST_0189_FIELD outputField = new REQUEST_0189_FIELD { x189A_DESC = string.Empty, x189A_MODEL_DESC = string.Empty, x189A_OBLN_ITEM = string.Empty, x189A_TYPE = string.Empty };
            REQUEST_0189_FIELD[] outputs = new REQUEST_0189_FIELD[120];
            for (int i = 0; i < 120; i++)
            {
                outputs[i] = outputField;
            }
            var getCollateralForDocIn = new InquiryServicesContext.GetCollateralForObligorInDocument
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
                SEG_COUNTER = request.Segment
            };


            try
            {
                var collateralList = GetCollateralArrayForObligor(ref ctx, ref errors, ref outputs, getCollateralForDocIn);

                //Need to requery for more data if segcounter is populated
                bool isRequery = int.TryParse(getCollateralForDocIn.SEG_COUNTER, out noOfRequery);
                if (isRequery && noOfRequery > 0)
                {
                    //Concat the results
                    FastConcat<CollateralDetail> collateralObligorArray = new FastConcat<CollateralDetail>();
                    collateralObligorArray.Add(collateralList);

                    while (noOfRequery > 0)
                    {
                        //Set a new requery LUW ID
                        getCollateralForDocIn.LUW_ID = Constants.GET_COLL_OBLGR_REQUERY_LUW_ID;
                        var reQueryCollarteralList = GetCollateralArrayForObligor(ref ctx, ref errors, ref outputs, getCollateralForDocIn);

                        //Append requery collateral list to the concat list
                        collateralObligorArray.Add(reQueryCollarteralList);
                        isRequery = int.TryParse(getCollateralForDocIn.SEG_COUNTER, out noOfRequery);
                    }

                    return new GetCollateralForObligorResponse() { CollateralList = collateralObligorArray.ToList(), Errors = errors };

                }


                return new GetCollateralForObligorResponse() { CollateralList = collateralList.ToList(), Errors = errors };

            }

            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetCollateralForObligorResponse>(Ex, request, "GetCollateralForObligor");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }

        }

        /// <summary>
        /// Gets the collateral array for obligor.
        /// </summary>
        /// <param name="ctx">The CTX.</param>
        /// <param name="errors">The errors.</param>
        /// <param name="outputs">The outputs.</param>
        /// <param name="getCollateralForDocIn">The get collateral for document in.</param>
        /// <returns></returns>
        private CollateralDetail[] GetCollateralArrayForObligor(ref ClientContext ctx, ref string errors, ref REQUEST_0189_FIELD[] outputs, GetCollateralForObligorInDocument getCollateralForDocIn)
        {
            inq.GetCollateralForObligor(ref getCollateralForDocIn.LUW_ID,
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
                out outputs,
                ref ctx);

            var collateralList = Array.ConvertAll<REQUEST_0189_FIELD, CollateralDetail>(outputs, delegate(REQUEST_0189_FIELD output)
            {
                CollateralDetail collateral = new CollateralDetail();
                collateral.x189A_OBLN_ITEM = output.x189A_OBLN_ITEM;
                collateral.x189A_TYPE = output.x189A_TYPE;
                collateral.x189A_MODEL_DESC = output.x189A_MODEL_DESC;
                collateral.x189A_DESC = output.x189A_DESC;
                return collateral;

            });
            return collateralList;
        }

        /// <summary>
        /// Gets the prime rate.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public GetPrimeRateResponse GetPrimeRate(GetPrimeRateRequest request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            double LUW_RATE;
            string errors = null;
            var getPrimeRateDocIn = new InquiryServicesContext.GetPrimeRateInDocument
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
                LUW_EFF_DATE = request.LUW_EFF_DATE,
                LUW_RATE_NUMBER = request.LUW_RATE_NUMBER
            };


            try
            {

                inq.GetPrimeRate(ref getPrimeRateDocIn.LUW_ID,
                    ref getPrimeRateDocIn.LUW_REQUEST_CODE,
                    ref getPrimeRateDocIn.LUW_BATCH_ID,
                    ref getPrimeRateDocIn.LUW_BANK,
                    ref getPrimeRateDocIn.LUW_OBLIGOR,
                    ref getPrimeRateDocIn.LUW_OBLIGATION,
                    ref getPrimeRateDocIn.LUW_ITEM_NBR,
                    ref getPrimeRateDocIn.SEG_COUNTER,
                    ref getPrimeRateDocIn.LUW_HEADER_FILLER,
                    ref getPrimeRateDocIn.LUW_CALLING_APPL,
                    ref getPrimeRateDocIn.LUW_LENGTH,
                    ref errors,
                    ref getPrimeRateDocIn.LUW_RATE_NUMBER,
                    ref getPrimeRateDocIn.LUW_EFF_DATE,
                    out LUW_RATE,
                    ref ctx);

                return new GetPrimeRateResponse() { LUW_RATE = LUW_RATE, Errors = errors };

            }

            catch (Microsoft.HostIntegration.TI.CustomTIException Ex)
            {
                return HandleHISException<GetPrimeRateResponse>(Ex, request, "GetPrimeRate");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                throw;
            }
        }



    }
}
