
using LOS.Adapter.Data.Services.Query;

namespace LOS.Adapter.Data.Services.Interface
{
    /// <summary>
    /// IInquiryRepository
    /// </summary>
    public interface IInquiryRepository
    {

        /// <summary>
        /// Gets the obligation headers.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetObligationHeadersResponse GetObligationHeaders(GetObligationHeadersRequest request);
        /// <summary>
        /// Gets the collateral indicative.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetCollateralIndicativeResponse GetCollateralIndicative(GetCollateralIndicativeRequest request);

        /// <summary>
        /// Gets the Collateral Supporting.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetCollateralSupportingResponse GetCollateralSupportingObligation(GetCollateralSupportingRequest request);

        /// <summary>
        /// Gets the Collateral Ties.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetCollateralTiesResponse GetCollateralTies(GetCollateralTiesRequest request);
        /// <summary>
        /// Gets the obligor.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetObligorResponse GetObligor(GetObligorRequest request);
        /// <summary>
        /// Gets the obligor obligations.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetObligationSummaryResponse GetObligationSummary(GetObligationSummaryRequest request);

        /// <summary>
        /// Gets the obligation.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetObligationResponse GetObligation(GetObligationRequest request);
        /// <summary>
        /// Gets the alternate name and address.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetAlternateNameAndAddressResponse GetAlternateNameAndAddress(GetAlternateNameAndAddressRequest request);
        /// <summary>
        /// Gets the participations.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetParticipationsResponse GetParticipations(GetParticipationsRequest request);
        /// <summary>
        /// Gets the indirect liabilities.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetIndirectLiabilitiesResponse GetIndirectLiabilities(GetIndirectLiabilitiesRequest request);// Get Indirect
        /// <summary>
        /// Gets the accrual schedules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetAccrualSchedulesResponse GetAccrualSchedules(GetAccrualSchedulesRequest request);
        /// <summary>
        /// Gets the billing schedules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetBillingSchedulesResponse GetBillingSchedules(GetBillingSchedulesRequest request);
        /// <summary>
        /// Gets the principal repayment schedules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetPrincipalRepaySchedulesResponse GetPrincipalRepaymentSchedules(GetPrincipalRepaySchedulesRequest request);
        /// <summary>
        /// Gets the prime schedules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetPrimeSchedulesResponse GetPrimeSchedules(GetPrimeSchedulesRequest request);
        /// <summary>
        /// Gets the collateral for obligor.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetCollateralForObligorResponse GetCollateralForObligor(GetCollateralForObligorRequest request);
        /// <summary>
        /// Gets the prime rate.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        GetPrimeRateResponse GetPrimeRate(GetPrimeRateRequest request);

    }
}
