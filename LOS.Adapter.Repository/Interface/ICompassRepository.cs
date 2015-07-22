

using LOS.Adapter.Data.Services.Query;
namespace LOS.Adapter.Data.Services
{
    public interface ICompassRepository
    {

        void GetCollateralIndicative();
        GetCollateralForObligorResponse GetCollateralForObligor(GetCollateralForObligorRequest getCollateralForDocIn);
        void UpdateObligor();
        void GetObligor();
        void GetAlternateNameAndAddress();
        void OpenBatch();
        void CloseBatch();
        void CreateAlternateNameAndAddress();
        void GetObligationNumber();
        void GetObligationSummary();
        void CreateObligor();
        void GetAccrualSchedules();
        void CreateCollateralTies();
        void CreateExceptionMessage();
        void GetBillingSchedules();
        void GetRepaymentSchedules();
        void GetObligorTicklers();
        void GetFutureTicklers();
        void GetCurrentTicklers();
        void GetPrimeSchedule();
        void GetParticipations();
        void GetObligation();
        void CreateSchedules();
        void UpdateELOC();
        void CreateObligorTickler();
        void CreateFutureTickler();
        void CreateCurrentTickler();
        void GetPrimeRate();
        void RenewCurrentNewObligation();
        void RenewCurrentSameObligation();
        void CreateFutureFeeSchedule();
        void CreateCollateral();
        void GetRenewalBalance();
        void CreateIndirectLiability();
        void GetIndirectLiabilities();
        void GetExceptionMessages();
        void GetBatchTransactionListing();
        void UpdateBatchTotals();
        void UpdateBatchTransactions();
        void CreateAccrualFeeSchedules();
        void CreateFutureObligation();
        void CreateELOC();
        void RenewFutureObligation();

    }

}
