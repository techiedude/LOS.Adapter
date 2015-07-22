using CollateralServicesContext;
using LOS.Adapter.Data.Services.Extensions;
using LOS.Adapter.Data.Services.Interface;
using Microsoft.HostIntegration.TI;
using System;

namespace LOS.Adapter.Data.Services.Repository
{
    /// <summary>
    /// Collateral Repository for handling collateral operations
    /// </summary>
    public class CollateralRepository : BaseRepository, ICollateralRepository
    {
        private ICollateral srv;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollateralRepository"/> class.
        /// </summary>
        public CollateralRepository()
        {
            srv = new Collateral();
        }
        /// <summary>
        /// Creates the collateral.
        /// </summary>
        /// <param name="request">The request.</param>
        public void CreateCollateral(CreateCollateralCommand request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);

            CreateCollateralInDocument doc = new CreateCollateralInDocument
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
                x1501_ADVANCE_PCT = request.x1501_ADVANCE_PCT,
                x1501_COLL_TYPE = request.x1501_COLL_TYPE,
                x1501_CUSIP_NBR = request.x1501_CUSIP_NBR,
                x1501_DATE_RCVD = request.x1501_DATE_RCVD,
                x1501_DDA_1 = request.x1501_DDA_1,
                x1501_DESCRIPTION1 = request.x1501_DESCRIPTION1,
                x1501_DESCRIPTION2 = request.x1501_DESCRIPTION2,
                x1501_EFF_DATE = request.x1501_EFF_DATE,
                x1501_EXPIRE_DATE = request.x1501_EXPIRE_DATE,
                x1501_FUNCTION_TYPE = request.x1501_FUNCTION_TYPE,
                x1501_LOCATION_HELD = request.x1501_LOCATION_HELD,
                x1501_LOCATION_RCVD = request.x1501_LOCATION_RCVD,
                x1501_MAX_LEND_VALUE = request.x1501_MAX_LEND_VALUE,
                x1501_NBR_PIECES = request.x1501_NBR_PIECES,
                x1501_NBR_UNITS = request.x1501_NBR_UNITS,
                x1501_REG_U_ADV_PCT = request.x1501_REG_U_ADV_PCT,
                x1501_SAFEKEEPING_CD = request.x1501_SAFEKEEPING_CD,
                x1501_UNIT_PRICE = request.x1501_UNIT_PRICE,
                x1508_COUPON_FREQ = request.x1508_COUPON_FREQ,
                x1508_FIRST_COUPON_AMT = request.x1508_FIRST_COUPON_AMT,
                x1508_GEOTRAC_IND = request.x1508_GEOTRAC_IND,
                x1508_GEOTRAC_NBR = request.x1508_GEOTRAC_NBR,
                x1508_NEXT_COUPON_DATE = request.x1508_NEXT_COUPON_DATE,
                x1508_REGULAR_COUPON_AMT = request.x1508_REGULAR_COUPON_AMT

            };

            try
            {
                srv.CreateCollateral(ref doc.LUW_ID,
                                    ref doc.LUW_REQUEST_CODE,
                                    ref doc.LUW_BATCH_ID,
                                    ref doc.LUW_BANK,
                                    ref doc.LUW_OBLIGOR,
                                    ref doc.LUW_OBLIGATION,
                                    ref doc.LUW_ITEM_NBR,
                                    ref doc.SEG_COUNTER,
                                    ref doc.LUW_HEADER_RESTRICTIONS,
                                    ref doc.LUW_LENGTH,
                                    ref doc.LUW_ERROR_MESSAGES,
                                    ref doc.x1501_FUNCTION_TYPE,
                                    ref doc.x1501_CUSIP_NBR,
                                    ref doc.x1501_COLL_TYPE,
                                    ref doc.x1501_ADVANCE_PCT,
                                    ref doc.x1501_REG_U_ADV_PCT,
                                    ref doc.x1501_NBR_UNITS,
                                    ref doc.x1501_UNIT_PRICE,
                                    ref doc.x1501_NBR_PIECES,
                                    ref doc.x1501_DESCRIPTION1,
                                    ref doc.x1501_DESCRIPTION2,
                                    ref doc.x1501_LOCATION_RCVD,
                                    ref doc.x1501_LOCATION_HELD,
                                    ref doc.x1501_EFF_DATE,
                                    ref doc.x1501_DATE_RCVD,
                                    ref doc.x1501_EXPIRE_DATE,
                                    ref doc.x1501_SAFEKEEPING_CD,
                                    ref doc.x1501_MAX_LEND_VALUE,
                                    ref doc.x1501_DDA_1,
                                    ref doc.x1508_COUPON_FREQ,
                                    ref doc.x1508_NEXT_COUPON_DATE,
                                    ref doc.x1508_FIRST_COUPON_AMT,
                                    ref doc.x1508_REGULAR_COUPON_AMT,
                                    ref doc.x1508_GEOTRAC_NBR,
                                    ref doc.x1508_GEOTRAC_IND,
                                    ref ctx);

                request.Errors = doc.LUW_ERROR_MESSAGES;
                request.ItemNumber = doc.LUW_ITEM_NBR;

            }
            catch (CustomTIException Ex)
            {
                HandleHISException<CreateCollateralCommand>(request, Ex, "CreateCollateral");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                request.Errors = msg;
                throw;
            }
        }



        /// <summary>
        /// Creates the collateral tie.
        /// </summary>
        /// <param name="request">The request.</param>
        public void CreateCollateralTie(CreateCollateralTieCommand request)
        {
            ClientContext ctx = GetClientContext(request.User, request.Password);
            //Checks
            if (!ValidateCollateralTieRequest(request))
            {
                return;
            }

            //check for specific counts
            if (!request.FUTURE_SPECIFIC_ITEMS.IsNullOrEmpty<REQUEST_1192_FIELDS>())
            {
                request.FUTURE_SPECIFIC_ITEMS.AddOrTrimExcess<REQUEST_1192_FIELDS>(Constants.CREATE_COLL_TIE_ITEMS_COUNT);
            }
            if (!request.CURRENT_SPECIFIC_ITEMS.IsNullOrEmpty<REQUEST_1392_FIELDS>())
            {
                request.CURRENT_SPECIFIC_ITEMS.AddOrTrimExcess<REQUEST_1392_FIELDS>(Constants.CREATE_COLL_TIE_ITEMS_COUNT);
            }


            var get1192Fields = Array.ConvertAll<REQUEST_1192_FIELDS, CollateralServicesContext.REQUEST_1192_FIELDS>(request.FUTURE_SPECIFIC_ITEMS.ToArray(), delegate(REQUEST_1192_FIELDS output)
            {
                var get1192Field = new CollateralServicesContext.REQUEST_1192_FIELDS()
                {
                    x1192_EFF_FROM_DATE = output.x1192_EFF_FROM_DATE,
                    x1192_SUPPORT_ITEM = output.x1192_SUPPORT_ITEM,
                    x1192_SUPPORT_OBLIGOR = output.x1192_SUPPORT_OBLIGOR,
                    x1192_SUPPORT_TYPE = output.x1192_SUPPORT_TYPE
                };

                return get1192Field;
            });

            var get1392Fields = Array.ConvertAll<REQUEST_1392_FIELDS, CollateralServicesContext.REQUEST_1392_FIELDS>(request.CURRENT_SPECIFIC_ITEMS.ToArray(), delegate(REQUEST_1392_FIELDS output)
            {
                var get1392Field = new CollateralServicesContext.REQUEST_1392_FIELDS()
                {
                    x1392_EFF_FROM_DATE = output.x1392_EFF_FROM_DATE,
                    x1392_SUPPORT_ITEM = output.x1392_SUPPORT_ITEM,
                    x1392_SUPPORT_OBLIGOR = output.x1392_SUPPORT_OBLIGOR,
                    x1392_SUPPORT_TYPE = output.x1392_SUPPORT_TYPE
                };

                return get1392Field;
            });

            CreateCollateralTieInDocument doc = new CreateCollateralTieInDocument
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
                FAILING_OCCURS_NUMBER = request.FAILING_OCCURS_NUMBER,
                REQUEST_FAILED_SW = request.REQUEST_FAILED_SW,
                REQUEST_1192_FIELDS = get1192Fields,
                REQUEST_1392_FIELDS = get1392Fields


            };

            try
            {
                srv.CreateCollateralTie(ref doc.LUW_ID,
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
                                    ref doc.REQUEST_FAILED_SW,
                                    ref doc.FAILING_OCCURS_NUMBER,
                                    ref doc.REQUEST_1192_FIELDS,
                                    ref doc.REQUEST_1392_FIELDS,
                                    ref ctx);

                request.Errors = doc.LUW_ERROR_MESSAGES;
                //Note: Need to check if there are any other fields that need to be mapped back to the request
                //object for further operation

            }
            catch (CustomTIException Ex)
            {
                HandleHISException<CreateCollateralTieCommand>(request, Ex, "CreateCollateralTieCommand");
            }
            catch (Exception ee)
            {
                string msg = ee.Message;
                request.Errors = msg;
                throw;
            }

        }

        /// <summary>
        /// Validates the collateral tie request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        private bool ValidateCollateralTieRequest(CreateCollateralTieCommand request)
        {
            //Checks
            if ((request.FUTURE_SPECIFIC_ITEMS.IsNullOrEmpty<REQUEST_1192_FIELDS>() && request.CURRENT_SPECIFIC_ITEMS.IsNullOrEmpty<REQUEST_1392_FIELDS>()))
            {
                request.Errors = "Current Specific Items and Future Specific Items both cannot be empty or null";
                return false;
            }
            //NOTE: Need to verify if both Current and Future specific items can be populated at the same time
            if ((!request.FUTURE_SPECIFIC_ITEMS.IsNullOrEmpty<REQUEST_1192_FIELDS>() && !request.CURRENT_SPECIFIC_ITEMS.IsNullOrEmpty<REQUEST_1392_FIELDS>()))
            {
                request.Errors = "Current Specific Items and Future Specific Items both cannot be populated";
                return false;
            }

            else if (!request.FUTURE_SPECIFIC_ITEMS.IsNullOrEmpty<REQUEST_1192_FIELDS>() && request.RestartRequestCode == Constants.CREATE_COLL_TIE_REQCODE_1192)
            {
                request.Errors = String.Format("Future Specific Items requires a RequestRestartCode of {0}", Constants.CREATE_COLL_TIE_REQCODE_1192);
                return false;
            }
            else if (!request.CURRENT_SPECIFIC_ITEMS.IsNullOrEmpty<REQUEST_1392_FIELDS>() && request.RestartRequestCode == Constants.CREATE_COLL_TIE_REQCODE_1392)
            {
                request.Errors = String.Format("Current Specific Items requires a RequestRestartCode of {0}", Constants.CREATE_COLL_TIE_REQCODE_1392);
                return false;
            }

            return true;
        }



    }
}
