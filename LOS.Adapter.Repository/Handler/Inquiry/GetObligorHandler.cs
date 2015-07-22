
using System.Threading.Tasks;
using LOS.Adapter.CQS;
using LOS.Adapter.Data.Services.Interface;
using LOS.Adapter.Data.Services.Query;
using LOS.Adapter.Data.Services.Repository;

namespace LOS.Adapter.Data.Services.Handler
{
    /// <summary>
    /// GetObligorHandler
    /// </summary>
    public class GetObligorHandler : IRequestHandler<GetObligorRequest, GetObligorResponse>
    {
        IInquiryRepository _repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObligorHandler"/> class.
        /// </summary>
        public GetObligorHandler()
        {
            _repo = new InquiryRepository();
        }


        /// <summary>
        /// Executes request asynchronously to get obligor info
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public async Task<GetObligorResponse> ExecuteAsync(GetObligorRequest request)
        {
            var getObligorResponse = await Task.Factory.StartNew(() =>
                _repo.GetObligor(request));

            return getObligorResponse;
        }

    }
}
