
using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetAlternateNameAndAddressHandler
    /// </summary>
    public class GetAlternateNameAndAddressHandler : IRequestHandler<GetAlternateNameAndAddressRequest, GetAlternateNameAndAddressResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAlternateNameAndAddressHandler"/> class.
        /// </summary>
        public GetAlternateNameAndAddressHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get alternate name and address for obligor
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetAlternateNameAndAddressResponse> ExecuteAsync(GetAlternateNameAndAddressRequest request)
        {
            var getAlternateNameAddResponse = await Task.Factory.StartNew(() =>
                _repo.GetAlternateNameAndAddress(request));

            return getAlternateNameAddResponse;
        }

    }
}
