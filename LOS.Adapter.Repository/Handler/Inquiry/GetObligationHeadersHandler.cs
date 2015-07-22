
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;
using System.Threading.Tasks;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetObligationHeadersHandler
    /// </summary>
    public class GetObligationHeadersHandler : IRequestHandler<GetObligationHeadersRequest, GetObligationHeadersResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObligationHeadersHandler"/> class.
        /// </summary>
        public GetObligationHeadersHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get ObligationSummary info
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetObligationHeadersResponse> ExecuteAsync(GetObligationHeadersRequest request)
        {
            var getObligationHeadersResponse = await Task.Factory.StartNew(() =>
                _repo.GetObligationHeaders(request));

            return getObligationHeadersResponse;
        }

    }
}
