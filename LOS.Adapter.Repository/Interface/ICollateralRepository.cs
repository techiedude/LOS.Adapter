
namespace LOS.Adapter.Data.Services.Interface
{
    /// <summary>
    /// ICollateralRepository
    /// </summary>
    public interface ICollateralRepository
    {
        /// <summary>
        /// Creates the collateral.
        /// </summary>
        /// <param name="request">The request.</param>
        void CreateCollateral(CreateCollateralCommand request);

        void CreateCollateralTie(CreateCollateralTieCommand request);
    }
}
