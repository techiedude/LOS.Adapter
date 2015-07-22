
using LOS.Adapter.Data.Services.Query;
namespace LOS.Adapter.Data.Services.Interface
{
    /// <summary>
    /// IObligorRepository
    /// </summary>
    public interface IObligorRepository
    {

        /// <summary>
        /// Creates the obligor.
        /// </summary>
        /// <param name="request">The request.</param>
        void CreateObligor(CreateObligorCommand request);
        /// <summary>
        /// Updates the name and address.
        /// </summary>
        void UpdateNameAndAddress();
        /// <summary>
        /// Creates the alternate name and address.
        /// </summary>
        void CreateAlternateNameAndAddress(CreateAlternateNameAndAddressCommand request);
        /// <summary>
        /// Updates the alternate name and address.
        /// </summary>
        void UpdateAlternateNameAndAddress();//new
        /// <summary>
        /// Updates the obligor.
        /// </summary>
        void UpdateObligor(); //is it same as update obligor indicative??

    }
}
