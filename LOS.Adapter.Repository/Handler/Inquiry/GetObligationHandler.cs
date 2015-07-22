
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;
using System.Threading.Tasks;
namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetObligationHandler
    /// </summary>
    public class GetObligationHandler : IRequestHandler<GetObligationRequest, GetObligationResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObligationHandler"/> class.
        /// </summary>
        public GetObligationHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get ObligationSummary info
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetObligationResponse> ExecuteAsync(GetObligationRequest request)
        {
            var getObligationResponse = await Task.Factory.StartNew(() =>
                _repo.GetObligation(request));

            return getObligationResponse;
        }

    }
}
