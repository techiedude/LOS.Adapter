
using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetParticipationsHandler
    /// </summary>
    public class GetParticipationsHandler : IRequestHandler<GetParticipationsRequest, GetParticipationsResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetParticipationsHandler"/> class.
        /// </summary>
        public GetParticipationsHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get alternate name and address for obligor
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetParticipationsResponse> ExecuteAsync(GetParticipationsRequest request)
        {
            var getParticipations = await Task.Factory.StartNew(() =>
                _repo.GetParticipations(request));

            return getParticipations;
        }

    }
}
