
using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetIndirectLiabilitiesHandler
    /// </summary>
    public class GetIndirectLiabilitiesHandler : IRequestHandler<GetIndirectLiabilitiesRequest, GetIndirectLiabilitiesResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIndirectLiabilitiesHandler"/> class.
        /// </summary>
        public GetIndirectLiabilitiesHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get alternate name and address for obligor
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetIndirectLiabilitiesResponse> ExecuteAsync(GetIndirectLiabilitiesRequest request)
        {
            var getIndirectLiabilities = await Task.Factory.StartNew(() =>
                _repo.GetIndirectLiabilities(request));

            return getIndirectLiabilities;
        }

    }
}
