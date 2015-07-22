
using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetObligationSummaryHandler
    /// </summary>
    public class GetObligationSummaryHandler : IRequestHandler<GetObligationSummaryRequest, GetObligationSummaryResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObligationSummaryHandler"/> class.
        /// </summary>
        public GetObligationSummaryHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get ObligationSummary info
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetObligationSummaryResponse> ExecuteAsync(GetObligationSummaryRequest request)
        {
            var getObligationSummaryResponse = await Task.Factory.StartNew(() =>
                _repo.GetObligationSummary(request));

            return getObligationSummaryResponse;
        }

    }
}
